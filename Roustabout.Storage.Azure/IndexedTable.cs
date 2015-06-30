using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsAzure.ChronoTableStorage;

namespace Roustabout.Storage.Azure
{

    public class IndexedTable : IDisposable //<T> where T : TableEntity
    {
        private CloudTable table;
        internal MasterIndexRepo masterIndexRepo;

        private List<TableOperation> ops = new List<TableOperation>();
        private CloudTable _geo;
        private CloudTable _log;
        private CloudTable _timetable;

        public Type OperationType { get; set; }


        public IndexedTable(CloudTable table, MasterIndexRepo masterIndexRepo)
        {
            // TODO: Complete member initialization
            this.table = table;

            _geo = masterIndexRepo._csr.GetTableClient().GetTableReference(table.Name + "geo");
            _geo.CreateIfNotExists();


            _log = masterIndexRepo._csr.GetTableClient().GetTableReference(table.Name + "log");
            _log.CreateIfNotExists();

            _timetable = masterIndexRepo._csr.GetTableClient().GetTableReference(table.Name + "time");
            _timetable.CreateIfNotExists();


            this.masterIndexRepo = masterIndexRepo;
        }

        internal void Log(TableEntity ent, string name, Type type, string logstring, object[] param)
        {
            var ts = RowKey.CreateReverseChronological(DateTime.UtcNow);
            var tsindex = new LogEntity { PartitionKey = ent.PartitionKey, RowKey = ts, Type = type.FullName, Log = string.Format( logstring, param) };
            _log.Execute(TableOperation.InsertOrReplace(tsindex));
        }

        internal void SetTime(TableEntity ent, string table, Type type, DateTime dateTime)
        {
            var ts = RowKey.CreateReverseChronological(dateTime);
            var tsindex = new IndexEntity { PartitionKey = ts, RowKey = ts, Table = table, Type = type.FullName, RemRowKey = ent.RowKey, RemPartKey = ent.PartitionKey };
            _timetable.Execute(TableOperation.InsertOrReplace(tsindex));
        }

        internal void SetGeo(double lat, double lng, TableEntity ent, string table, Type t1)
        {
            var index = new IndexEntity { PartitionKey = string.Format("{0}-{1}", lat.ToString().Replace('-', 'N'), ShortGuid.NewGuid()), RowKey = string.Format("{0}-{1}", lng.ToString().Replace('-', 'N'), ShortGuid.NewGuid()), Table = table, Type = t1.FullName, RemRowKey = ent.RowKey, RemPartKey = ent.PartitionKey };
            _geo.Execute(TableOperation.InsertOrReplace(index));
        }


        public async Task Update(TableEntity ent)
        {
            await table.ExecuteAsync(TableOperation.InsertOrMerge(ent));
        }

        public ObjectOperation Add(TableEntity ent, params string[] ids)
        {


            var op = new ObjectOperation(ent, table, masterIndexRepo, OpType.Add, this);
            if (ids.Length > 0)
            {
                foreach (var id in ids)
                {
                    op.AddEntID(id);
                }
            }
            else
            {
                op.AddEntID(ent.PartitionKey);
            }

            return op;
        }


        public string TableName { get { return table.Name; } }

        public void Dispose()
        {

        }

        public async Task<DynamicTableEntity> Get(string id)
        {

            IndexEntity idx = await masterIndexRepo.GetIndexPointer(id);

            if (idx == null)
            {
                return null;
            }


            //MethodInfo MI = typeof(TableOperation).GetMethod("Retrieve");
            //MethodInfo genericMethod = MI.MakeGenericMethod(new[] { Type.GetType(idx.Type) });
            //var operation = (TableOperation)genericMethod.Invoke(null, new object[] {});

            var res = await table.ExecuteAsync(TableOperation.Retrieve(idx.RemPartKey, idx.RemRowKey));
            if (res == null)
            {
                masterIndexRepo.ClearIndexes(idx);
            }


            return (DynamicTableEntity)res.Result;
        }

        internal IEnumerable<DynamicTableEntity> Query(string formatstring, string[] pars)
        {

            return this.table.ExecuteQuery(new TableQuery().Where(string.Format(formatstring, pars))).ToList();

        }


        public object DynamicMap(Type map, DynamicTableEntity ent)
        {
            var obj = Activator.CreateInstance(map);

            obj.GetType().GetProperty("PartitionKey").SetValue(obj, ent.PartitionKey);
            obj.GetType().GetProperty("RowKey").SetValue(obj, ent.RowKey);
            obj.GetType().GetProperty("Timestamp").SetValue(obj, ent.Timestamp);
            obj.GetType().GetProperty("ETag").SetValue(obj, ent.ETag);



            foreach (var prop in ent.Properties)
            {

                var pi = obj.GetType().GetProperty(prop.Key);

                switch (prop.Value.PropertyType)
                {



                    case EdmType.Binary:
                        pi.SetValue(obj, prop.Value.BinaryValue);
                        break;
                    case EdmType.Boolean:
                        pi.SetValue(obj, prop.Value.BooleanValue.Value);
                        break;
                    case EdmType.DateTime:
                        pi.SetValue(obj, prop.Value.DateTime.Value);
                        break;
                    case EdmType.Double:
                        pi.SetValue(obj, prop.Value.DoubleValue.Value);
                        break;
                    case EdmType.Guid:
                        pi.SetValue(obj, prop.Value.GuidValue.Value);
                        break;
                    case EdmType.Int32:
                        pi.SetValue(obj, prop.Value.Int32Value.Value);
                        break;
                    case EdmType.Int64:
                        pi.SetValue(obj, prop.Value.Int64Value.Value);
                        break;
                    case EdmType.String:
                        pi.SetValue(obj, prop.Value.StringValue);
                        break;
                    default:
                        break;
                }
            }



            return obj;
        }

        internal async Task<DynamicTableEntity> GetDirect(string partkey, string rowkey)
        {
            return (DynamicTableEntity)(await this.table.ExecuteAsync(TableOperation.Retrieve(partkey, rowkey))).Result;

        }

        internal async Task RemoveDirect(string partkey, string rowkey)
        {
            var obj = (DynamicTableEntity)(await this.table.ExecuteAsync(TableOperation.Retrieve(partkey, rowkey))).Result;

            await masterIndexRepo.RemoveIndexes(obj);

            await this.table.ExecuteAsync(TableOperation.Delete(obj));


            // remove geo

            var geopointers = _geo.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("RemPartKey eq '{0}' and RemRowKey eq '{1}'", obj.PartitionKey, obj.RowKey))).ToList();

            foreach (var ptr in geopointers)
            {
                await _geo.ExecuteAsync(TableOperation.Delete(ptr));
            }


            // remove timestamp

            var tspointers = _timetable.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("RemPartKey eq '{0}' and RemRowKey eq '{1}'", obj.PartitionKey, obj.RowKey))).ToList();

            foreach (var ptr in tspointers)
            {
                await _timetable.ExecuteAsync(TableOperation.Delete(ptr));
            }

        }

        internal void Clean()
        {
            table.DeleteIfExists();
            
            table.CreateIfNotExists();

            _geo.DeleteIfExists();
            
            _geo.CreateIfNotExists();

            _log.DeleteIfExists();
            
            _log.CreateIfNotExists();

            _timetable.DeleteIfExists();
            
            _timetable.CreateIfNotExists();

        }


        internal async Task<IEnumerable<IndexEntity>> GetGeoIndexes(BoundingBox.BoundingBoxInfo bb, string table)
        {
            return await Task.Run<IEnumerable<IndexEntity>>(() =>
            {


                var indexlist = _geo.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("{0}  and Table eq '{1}'", bb, table)).Take(100)).ToList();
                return indexlist;
            });

        }


        internal async Task<IEnumerable<DynamicTableEntity>> GetLatest(int count)
        {

            var idxlist = _timetable.ExecuteQuery(new TableQuery<IndexEntity>().InOrder().Take(count)).ToList();
            //idxlist.Reverse();


            IEnumerable<DynamicTableEntity> ol = await GetBulk(idxlist.Take(count).Select(i => new Tuple<string, string>(i.RemPartKey, i.RemRowKey)));
            return ol;

        }

        internal async Task<IEnumerable<DynamicTableEntity>> Near(double lat, double lng, double distance)
        {
            var bb = BoundingBox.GetBoundingBox(new BoundingBox.MapPoint { Latitude = lat, Longitude = lng }, distance);

            var idxlist = await GetGeoIndexes(bb, this.table.Name);
            //var ol = new ConcurrentBag<DynamicTableEntity>();




            IEnumerable<DynamicTableEntity> ol = await GetBulk(idxlist.Take(100).Select(i => new Tuple<string, string>(i.RemPartKey, i.RemRowKey)));


            //foreach (var item in idxlist.Take(100))
            //{

            //    var itm = await GetDirect(item.RemPartKey, item.RemRowKey);
            //    if (itm != null)
            //    {
            //        ol.Add(itm);
            //    }
            //}

            //idxlist.Take(100).AsParallel().ForAll(item =>
            //{

            //    GetDirect(item.RemPartKey, item.RemRowKey).ContinueWith((itm) =>
            //    {
            //        if (itm.Result != null)
            //        {
            //            ol.Add(itm.Result);
            //        }
            //    });


            //    //var itm = await GetDirect(item.RemPartKey, item.RemRowKey);
            //    //if (itm != null)
            //    //{
            //    //    ol.Add(itm);
            //    //}
            //});

            return ol.ToList();

        }

        public async Task<IEnumerable<DynamicTableEntity>> GetBulk(IEnumerable<Tuple<string, string>> enumerable)
        {
            // build out query string

            if (enumerable.Count() == 0)
            {
                return new List<DynamicTableEntity>();

            }

            return await Task.Run<IEnumerable<DynamicTableEntity>>(() =>
            {

                var apart = Partitioner.Create(0, enumerable.Count(), 30);



                var bag = new ConcurrentBag<DynamicTableEntity>();

                Parallel.ForEach(apart, (range, loopState) =>
                {



                    // sub query builder
                    var sb = new StringBuilder();
                    for (int i = range.Item1; i < range.Item2; i++)
                    {
                        sb.AppendFormat("(PartitionKey eq '{0}' and RowKey eq '{1}')", enumerable.ElementAt(i).Item1, enumerable.ElementAt(i).Item2);


                        sb.Append(" or ");
                    }






                    sb.Replace(" or ", "", sb.Length - 5, 5);


                    var query = sb.ToString();

                    var ol = this.table.ExecuteQuery(new TableQuery().Where(query)).ToList();
                    foreach (var itm in ol)
                    {
                        bag.Add(itm);
                    }


                });










                return bag.ToList();

            });

        }

        internal async Task Delete<T>(T obj) where T : TableEntity
        {
            await RemoveDirect(obj.PartitionKey, obj.RowKey);
        }
    }

    public enum OpType
    {
        Add,
        Update,
        Delete,
        Read
    }
}

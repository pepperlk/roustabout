
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsAzure.ChronoTableStorage;

namespace Roustabout.Storage.Azure
{





    public class MasterIndexRepo
    {
        internal CloudStorageRepo _csr;
        private CloudTable _index;
        //private CloudTable _geo;
        private CloudTable _log;
        private CloudTable _events;

        public MasterMetrics Metrics { get; set; }

        public MasterIndexRepo(CloudStorageRepo csr)
        {
            _csr = csr;
            _index = _csr.GetTableClient().GetTableReference("mstrindex");
            

            //_geo = _csr.GetTableClient().GetTableReference("mstrgeo");
            //_geo.CreateIfNotExists();

             
            _log = _csr.GetTableClient().GetTableReference("mstrlog");
            


            _events = _csr.GetTableClient().GetTableReference("mstrevents");


//#if DEBUG
            _index.CreateIfNotExists();
            _log.CreateIfNotExists();
            _events.CreateIfNotExists();

//#endif


            Metrics = new MasterMetrics(this, _events);

        }


        public void SetIndex(string id, TableEntity ent, string table, Type t1)
        {
             
            var index = new IndexEntity { PartitionKey = id, RowKey = id, Table = table, Type = t1.FullName, RemRowKey = ent.RowKey, RemPartKey = ent.PartitionKey };
            _index.Execute(TableOperation.InsertOrReplace(index));
             
        }


     

        public void CleanUp()
        {
            _index.DeleteIfExists();
        
            _index.CreateIfNotExists();

            _log.DeleteIfExists();
    
            _log.CreateIfNotExists();

            //_geo.DeleteIfExists();
            //_geo.CreateIfNotExists();
        }

        public async Task< object> Get(string id)
        {
            var ptr = await GetIndexPointer(id);

            if (ptr != null)
            {
                var table = _csr.GetTableClient().GetTableReference(ptr.Table);

                table.CreateIfNotExists();


                var it = new IndexedTable(table, this);
                var obj = await it.GetDirect(ptr.RemPartKey, ptr.RemRowKey);
                var type = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes().Where(t => t.FullName == ptr.Type)).FirstOrDefault();

                var outobj = it.DynamicMap(type, obj);
                return outobj;



            }

            return null;
        }


        public void SetLinkIndex(TableEntity ent1, TableEntity ent2, string table1, string table2, Type t1, Type t2)
        {
            //if (!time.HasValue)
            //{
            //    time = DateTime.UtcNow;
            //}
            //if (time.HasValue && time.Value.Kind != DateTimeKind.Utc)
            //{
            //    time = time.Value.ToUniversalTime();
            //}


            var fwdlink = new IndexEntity { PartitionKey = "link_" + ent1.PartitionKey, RowKey = "link_" + ent2.PartitionKey, Table = table1, Type = t2.FullName, RemRowKey = ent2.RowKey, RemPartKey = ent2.PartitionKey };
            _index.Execute(TableOperation.InsertOrReplace(fwdlink));
            var revlink = new IndexEntity { PartitionKey = "link_" + ent2.PartitionKey, RowKey = "link_" + ent1.PartitionKey, Table = table2, Type = t1.FullName, RemRowKey = ent1.RowKey, RemPartKey = ent1.PartitionKey };
            _index.Execute(TableOperation.InsertOrReplace(revlink));




        }

        internal void AutoID(TableEntity ent)
        {



            ent.PartitionKey = ShortGuid.NewGuid();
            ent.RowKey = ShortGuid.NewGuid();
        }



        public void SetChildOFID(TableEntity ent1, string table1, string id, Type t1)
        { 
            var fwdlink = new IndexEntity { PartitionKey = "link_" + id.ToAzureKey(), RowKey = "link_" + ent1.PartitionKey, Table = table1, Type = t1.FullName, RemRowKey = ent1.RowKey, RemPartKey = ent1.PartitionKey };
            _index.Execute(TableOperation.InsertOrReplace(fwdlink));
        }


        public static string TableNameParse(string name)
        {

            return name.ToLower().Replace("entity", "").Replace(".", "").Replace("_", "").Replace("-", "");

        }

        public async Task<IndexedTable<T>> GetTable<T>() where T : TableEntity
        {
            return await Task.Run<IndexedTable<T>>(() =>
            {
                return new IndexedTable<T>(GetTableFromType(typeof(T)));
            });


        }


        internal IndexedTable GetTableFromType(Type type)
        {
            var table = _csr.GetTableClient().GetTableReference(TableNameParse(type.Name));

            table.CreateIfNotExists();


            var it = new IndexedTable(table, this);
            it.OperationType = type;
            return it;
        }

        internal async Task<IndexEntity> GetIndexPointer(string id)
        {
            return await Task.Run<IndexEntity>(() =>
            {
                return _index.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("PartitionKey eq '{0}'", id))).ToList().FirstOrDefault();
            });
        }


        internal void ClearIndexes(IndexEntity idx)
        {
            var pointers = _index.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("RemPartKey eq '{0}' and RemRowKey eq '{1}'", idx.RemPartKey, idx.RemRowKey))).ToList();

            foreach (var ptr in pointers)
            {
                _index.Execute(TableOperation.Delete(ptr));
            }


            var pointers2 = _index.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("PartitionKey eq 'link_{0}' and RowKey eq 'link_{1}'", idx.RemPartKey, idx.RemRowKey))).ToList();

            foreach (var ptr in pointers2)
            {
                _index.Execute(TableOperation.Delete(ptr));
            }
        }

       

        internal async Task RemoveIndexes(DynamicTableEntity obj)
        {
            var pointers = _index.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("RemPartKey eq '{0}' and RemRowKey eq '{1}'", obj.PartitionKey, obj.RowKey))).ToList();

            foreach (var ptr in pointers)
            {
                await _index.ExecuteAsync(TableOperation.Delete(ptr));
            }


            var pointers2 = _index.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("PartitionKey eq 'link_{0}' and RowKey eq 'link_{1}'", obj.PartitionKey, obj.RowKey))).ToList();

            foreach (var ptr in pointers2)
            {
                await _index.ExecuteAsync(TableOperation.Delete(ptr));
            }


            // remove geo
          




            // remove logs



        }


      

        public LinkOperation GetChildren(TableEntity parent)
        {
            var linkop = new LinkOperation(parent, this);
            linkop.PopulateChildren();
            return linkop;
        }

        internal IEnumerable<IndexEntity> GetChildrenIndexOf(TableEntity parent)
        {
            return _index.ExecuteQuery(new TableQuery<IndexEntity>().Where(string.Format("PartitionKey eq '{0}'", "link_" + parent.PartitionKey))).ToList();
        }


   

        public async Task<IEnumerable<T1>> GetChildrenByID<T1>(string id) where T1 : TableEntity

        {
            //var ol = new List<T1>();
            var indexes = _index.ExecuteQuery(new TableQuery<IndexEntity>().InOrder(string.Format("PartitionKey eq '{0}'", "link_" + id)).Take(20)).ToList();//.GroupBy(i => i.Type);


            var table = await this.GetTable<T1>();


            //foreach (var group in indexes)
            //{

            //    if (group.FirstOrDefault().Type != typeof(T1).FullName) { continue; }


            IEnumerable<T1> ol = await table.GetBulk(indexes.Take(100).Select(i => new Tuple<string, string>(i.RemPartKey, i.RemRowKey)));


            //foreach (var index in indexes)
            //{




            //    var item = await table.GetDirect(index.RemPartKey, index.RemRowKey);
            //    ol.Add(item);

            //}
            // }

            return ol;
        }

        public async Task<IEnumerable<T1>> GetChildren<T1>(TableEntity parent) where T1 : TableEntity
        {
            var ol = new List<T1>();
            var indexes = this.GetChildrenIndexOf(parent).GroupBy(i => i.Type);

            foreach (var group in indexes)
            {

                if (group.FirstOrDefault().Type != typeof(T1).FullName) { continue; }

                var table = await this.GetTable<T1>();



                foreach (var index in group)
                {
                    var item = await table.GetDirect(index.RemPartKey, index.RemRowKey);
                    ol.Add(item);

                }
            }

            return ol;

        }

        public IEnumerable<LogEntity> GetLog(TableEntity ent)
        {
            return null;
        }




        public async Task TrackEvent(string aggid, string category, string action, int value)
        {
            await TrackEvent(aggid, category, action, value, DateTime.UtcNow);
        }

        public async Task TrackEvent(string aggid, string category, string action, int value, DateTime timestamp)
        {
            var eventent = new EventEntity()
            {
                PartitionKey = aggid.ToAzureKey(),
                RowKey = RowKey.CreateReverseChronological(timestamp),
                Category = category,
                Action = action, 
                Value = value,
            };


            await _events.ExecuteAsync(TableOperation.Insert(eventent));



        }

    }



}

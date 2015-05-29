using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Storage.Azure
{
    public class IndexedTable<T> where T : TableEntity
    {
        private IndexedTable _idxtable;
        public IndexedTable(IndexedTable idxtable)
        {
            _idxtable = idxtable;
        }

        public ObjectOperation Add(T obj, params string[] ids)
        {
            return _idxtable.Add(obj, ids);
        }

        public async Task<T> Get(string id)
        {
            var obj = await _idxtable.Get(id);
            if (obj == null)
            {
                return null;
            }

            var o = DynamicMap(obj);

            return o;
        }

        public T DynamicMap(DynamicTableEntity ent)
        {

            return (T)_idxtable.DynamicMap(typeof(T), ent);


        }


        public IEnumerable<T> Query(string formatstring, params string[] pars)
        {
            return _idxtable.Query(formatstring, pars).OrderByDescending(t => t.Timestamp).Select(o => DynamicMap(o));
        }

        internal async Task<T> GetDirect(string partkey, string rowkey)
        {
            return DynamicMap(await _idxtable.GetDirect(partkey, rowkey));
        }

        internal async Task RemoveDirect(string partkey, string rowkey)
        {

            await _idxtable.RemoveDirect(partkey, rowkey);

        }

        public void Clean()
        {
            _idxtable.Clean();
        }

        public async Task<IEnumerable<T>> Near(double lat, double lng, double distance = 30)
        {



            var ol = await _idxtable.Near(lat, lng, distance);
            var retlist = new List<T>();
            foreach (var item in ol)
            {
                retlist.Add(DynamicMap(item));
            }

            return retlist;

        }

        public async Task Delete(T obj)
        {


            await _idxtable.Delete(obj);


        }

        public async Task<IEnumerable<T>> GetLatest(int count = 20)
        {
            var ol = await _idxtable.GetLatest(count);
            var retlist = new List<T>();
            foreach (var item in ol)
            {
                retlist.Add(DynamicMap(item));
            }

            return retlist;
        }
    }
}

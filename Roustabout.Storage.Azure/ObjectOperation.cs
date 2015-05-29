using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Storage.Azure
{
    public class ObjectOperation : IDisposable
    {
        private TableEntity ent;
        private CloudTable table;
        private MasterIndexRepo masterIndexRepo;
        private OpType _optype;
        private IndexedTable _itable;
        private List<string> _entids;
        private List<string> _logstoadd;
        private List<Action> _actions;

        public ObjectOperation(TableEntity ent, CloudTable table, MasterIndexRepo masterIndexRepo, OpType optype, IndexedTable itable)
        {
            // TODO: Complete member initialization
            this._optype = optype;
            this.ent = ent;
            this.table = table;
            this.masterIndexRepo = masterIndexRepo;
            _itable = itable;

            this._entids = new List<string>();
            this._logstoadd = new List<string>();
            this._actions = new List<Action>();

        }
        public void Dispose()
        {
            switch (this._optype)
            {
                case OpType.Add:
                    //this._actions.Add(() =>
                    //{
                    table.Execute(TableOperation.InsertOrReplace(ent));
                    //});
                    FinalizeOp();

                    break;
                case OpType.Update:
                    break;
                case OpType.Delete:
                    break;
                case OpType.Read:
                    break;
                default:
                    break;
            }
        }

      
        public void Write()
        {
           

                this.Dispose();

           
        }


        private void FinalizeOp()
        {
             
            //foreach (var o in _actions)
            //{
            //    o();
                
            //}



            this._actions.AsParallel().ForAll((o) =>
            {
                o();

            });


        }

        public void Link<T>(T obj) where T : TableEntity
        {

            //this._actions.Add(() =>
            //{


            var remtable = masterIndexRepo.GetTableFromType(obj.GetType());
            masterIndexRepo.SetLinkIndex(this.ent, obj, table.Name, remtable.TableName, ent.GetType(), typeof(T));
            //});
        }

        public void Log(string logstring, params object[] param)
        {

            //this._actions.Add(() =>
            //{
            _itable.Log(this.ent, table.Name, this.ent.GetType(), logstring, param);
            //});





        }

        public void TimeStamp(DateTime dateTime)
        {
            //this._actions.Add(() =>
            //{
            _itable.SetTime(this.ent, table.Name, this.ent.GetType(), dateTime);
            //});
        }



        public void LinkAsChildOfID(string id)
        {
            //this._actions.Add(() =>
            //{
            masterIndexRepo.SetChildOFID(this.ent, table.Name, id, this.ent.GetType());
            //});
        }

        public void Geo(double lat, double lng)
        {
            //this._actions.Add(() =>
            //{
            _itable.SetGeo(lat, lng, this.ent, table.Name, this.ent.GetType());
            //});


        }

        internal void AddEntID(string id)
        {

            //this._actions.Add(() =>
            //{
            masterIndexRepo.SetIndex(id, ent, table.Name, ent.GetType());
            //});


            //this._entids.Add(id);
        }

       
    }
}

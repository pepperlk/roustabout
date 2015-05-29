using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roustabout.Inject;
using Microsoft.WindowsAzure.Storage.Table;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Roustabout.Tests
{
    [TestClass]
    public class AzureTests
    {
        [TestMethod]
        public void RepoTest()
        {

            var csr = RB.Get<Roustabout.Storage.Azure.CloudStorageRepo>();




            var ent = new ParentEnt();
            ent.AutoID();




        }


        [TestMethod]
        public void OrderTest()
        {

            var csr = RB.Get<Roustabout.Storage.Azure.CloudStorageRepo>();
            var t1 = csr.GetTableClient().GetTableReference("test1");
            t1.DeleteIfExists();
            t1.CreateIfNotExists();


            var sw = Stopwatch.StartNew();

            for (int i = 0; i < 500; i++)
            {
                var ent = new ParentEnt();
                ent.AutoID(i % 2);

                ent.Title = i.ToString();

                t1.Execute(TableOperation.Insert(ent));

            }
            var elapsed = sw.ElapsedMilliseconds;



            var orderlist = t1.ExecuteQuery(new TableQuery<ParentEnt>().InOrder()).ToList();




        }



        [TestMethod]
        public async Task ModelTest()
        {


            var mir = RB.Get<Roustabout.Storage.Azure.MasterIndexRepo>();
            mir.CleanUp();
            var table = await mir.GetTable<ParentEnt>();
            table.Clean();

            var last = "";
            var sw = Stopwatch.StartNew();



            //Parallel.For(0, 100, (i) =>
            //{
            //    var ent = new ParentEnt();
            //    ent.AutoID();

            //    ent.Title = i.ToString();

            //    using (var op = table.Add(ent))
            //    {
            //        op.TimeStamp(DateTime.UtcNow);
            //        op.Geo(41.1456, -104.8019);
            //        op.Log("Object Added");
            //    }

            //    last = ent.PartitionKey;
            //});


            for (int i = 0; i < 1000; i++)
            {
                var ent = new ParentEnt();
                ent.AutoID();

                ent.Title = i.ToString();

                var op = table.Add(ent);

                op.TimeStamp(DateTime.UtcNow);
                op.Geo(41.1456, -104.8019);
                op.Log("Object Added");
                op.Write();


                last = ent.PartitionKey;
            }

            var elapsed = sw.ElapsedMilliseconds;
            sw = Stopwatch.StartNew();
            var obj = await mir.Get(last);
            var singleelapsed = sw.ElapsedMilliseconds;

            sw = Stopwatch.StartNew();
            var nearby = await table.Near(41.1456, -104.8019);
            var geoelapsed = sw.ElapsedMilliseconds;

            sw = Stopwatch.StartNew();
            await table.Delete((ParentEnt)obj);
            var delelapsed = sw.ElapsedMilliseconds;


            sw = Stopwatch.StartNew();
            var latest = await table.GetLatest(10);
            var latestelapsed = sw.ElapsedMilliseconds;
            Trace.WriteLine(latest.Count());

            Trace.WriteLine(string.Format("{0} : {1} : {2} : {3} : {4}", elapsed, singleelapsed, geoelapsed, delelapsed, latestelapsed));



        }








        [TestMethod]
        public async Task BulkInsertTest()
        {


            var mir = RB.Get<Roustabout.Storage.Azure.MasterIndexRepo>();
            mir.CleanUp();
            var table = await mir.GetTable<ParentEnt>();
            table.Clean();

            var last = "";
            var sw = Stopwatch.StartNew();

            var oplist = new List<Storage.Azure.ObjectOperation>();

            for (int i = 0; i < 100000; i++)
            {
                var ent = new ParentEnt();
                ent.AutoID();

                ent.Title = i.ToString();

                var op = table.Add(ent);

                op.TimeStamp(DateTime.UtcNow);
                op.Geo(41.1456, -104.8019);
                op.Log("Object Added");
                op.LinkAsChildOfID("test");
                op.Write();

                //oplist.Add(op);

                last = ent.PartitionKey;
            }


            //foreach (var o in oplist)
            //{
            //     o.Write();
            //}


            //oplist.AsParallel().ForAll(o => o.Write().GetAwaiter().GetResult());



            var elapsed = sw.ElapsedMilliseconds;
            sw = Stopwatch.StartNew();
            var obj = await mir.Get(last);
            var singleelapsed = sw.ElapsedMilliseconds;

            sw = Stopwatch.StartNew();
            var nearby = await table.Near(41.1456, -104.8019);
            var geoelapsed = sw.ElapsedMilliseconds;

            sw = Stopwatch.StartNew();
            await table.Delete((ParentEnt)obj);
            var delelapsed = sw.ElapsedMilliseconds;


            sw = Stopwatch.StartNew();
            var latest = await table.GetLatest(100);
            var latestelapsed = sw.ElapsedMilliseconds;
            Trace.WriteLine(latest.Count());



            //sw = Stopwatch.StartNew();
            //var byhash = await mir.GetChildrenByID<ParentEnt>("test");
            //var hashelapsed = sw.ElapsedMilliseconds;
            //Trace.WriteLine(byhash.Count());

            Trace.WriteLine(string.Format("{0} : {1} : {2} : {3} : {4} : {5}", elapsed, singleelapsed, geoelapsed, delelapsed, latestelapsed, 0));



        }


        [TestMethod]
        public void MetricsTest()
        {
            

            var mir = RB.Get<Roustabout.Storage.Azure.MasterIndexRepo>();
            mir.CleanUp();
            var ol = new List<Task>();
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                ol.Add( mir.TrackEvent("aggid", "categoy", "action", 1));
            }

            Task.WaitAll(ol.ToArray());
            var elapsed = sw.Elapsed;
            



        }


    }
    public class ParentEnt : TableEntity
    {
        public string Title { get; set; }
    }
}

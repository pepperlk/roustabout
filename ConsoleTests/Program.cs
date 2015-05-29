using Microsoft.WindowsAzure.Storage.Table;
using Roustabout.Inject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTests
{
    public class ParentEnt : TableEntity
    {
        public string Title { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //PerfTest().GetAwaiter().GetResult();
            MetricsTest();


            Console.Read();
        }



        static async Task PerfTest()
        {
            var mir = RB.Get<Roustabout.Storage.Azure.MasterIndexRepo>();
            mir.CleanUp();
            var table = await mir.GetTable<ParentEnt>();
            table.Clean();

            //Thread.Sleep(2000);



            var total = 5000;
         


            var last = "";
            Console.Write("Starting Write");
            var sw = Stopwatch.StartNew();



          
            
            for (int i = 0; i < total; i++)
            {

              

                var ent = new ParentEnt();
                ent.AutoID();
                //ent.AutoIDGuid();

                ent.Title = i.ToString();

                var op = table.Add(ent);

                op.TimeStamp(DateTime.UtcNow);
               // op.Geo(41.1456, -104.8019);
                //op.Log("Object Added");
                op.Write();

                Console.Clear();
                Console.Write((i + 1) + "/" + total);
                last = ent.PartitionKey;
       
            }








            var elapsed = sw.ElapsedMilliseconds;

            Console.Write("Write Complete: " + elapsed);

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

            Console.WriteLine("");
            Console.WriteLine(string.Format("{0} : {1} : {2} : {3} : {4}", elapsed, singleelapsed, geoelapsed, delelapsed, latestelapsed));
            Trace.WriteLine(string.Format("{0} : {1} : {2} : {3} : {4}", elapsed, singleelapsed, geoelapsed, delelapsed, latestelapsed));
           

        }

        static void MetricsTest()
        {

            var mir = RB.Get<Roustabout.Storage.Azure.MasterIndexRepo>();
            //mir.CleanUp();
            var ol = new List<Task>();
            var sw = Stopwatch.StartNew();

            var total = 10000;
            for (int i = 0; i < total; i++)
            {

                //ol.Add(Task.Run(() =>
                //{

                //ol.Add(


                    mir.TrackEvent("aggid" + (i % 2), "categoy" + (i % 5), "action" + (i % 3), 1).GetAwaiter().GetResult();
                    
                    
                    //);

                Console.Clear();
                Console.Write((i + 1) + "/" + total);
                //Thread.Sleep(5);

                //}));
            }






            Console.WriteLine("");
          //Task.WaitAll(ol.ToArray());
          var elapsed = sw.Elapsed;
            Console.WriteLine(elapsed.Milliseconds);

            sw = Stopwatch.StartNew();
            var results = mir.Metrics.GetEvents("aggid1", "", "Action2", DateTime.UtcNow.AddDays(-2), DateTime.UtcNow);
            elapsed = sw.Elapsed;
            Console.WriteLine(elapsed.Milliseconds);
            Console.WriteLine("Count: " + results.Sum(o=> o.Value));

        }
    }
}

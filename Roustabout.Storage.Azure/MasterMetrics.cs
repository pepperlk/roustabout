using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Text;
using WindowsAzure.ChronoTableStorage;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Roustabout.Storage.Azure
{
    public class MasterMetrics
    {
        private CloudTable _eventsTable;
        private MasterIndexRepo _masterIndexRepo;

        public MasterMetrics(MasterIndexRepo masterIndexRepo, CloudTable eventsTable)
        {
            _eventsTable = eventsTable;

            this._masterIndexRepo = masterIndexRepo;
        }

        public Dictionary<string, int> GetEvents(string id, string cat, string action, DateTime start, DateTime end)
        {
            var q = new StringBuilder();
            if (!string.IsNullOrEmpty(id))
            {
                if(q.Length > 0)
                {
                    q.Append(" and ");
                }

                q.AppendFormat("(PartitionKey eq '{0}')", id);

            }



            q.AppendFormat("{0} ({1})", q.Length == 0 ? "" : " and ",
                ChronologicalTableQuery.GenerateFilterCondition(
                      QueryDateReverseChronologicalComparisons.AfterOrEqual, start) + " and " + 
                                          ChronologicalTableQuery.GenerateFilterCondition(
                                              QueryDateReverseChronologicalComparisons.BeforeOrEqual, end));




            if (!string.IsNullOrEmpty(cat))
            {
                if (q.Length > 0)
                {
                    q.Append(" and ");
                }

                q.AppendFormat("(Category eq '{0}')", cat);
            }


            if (!string.IsNullOrEmpty(action))
            {
                if (q.Length > 0)
                {
                    q.Append(" and ");
                }

                q.AppendFormat("(Action eq '{0}')", action);
            }



            var events = _eventsTable.ExecuteQuery(new TableQuery<EventEntity>().Where(q.ToString())).ToList();

            IEnumerable<IGrouping<DateTime, EventEntity>> processlist = null;

            // by week 

            // by day DEfault
            processlist = events.GroupBy(e => e.Timestamp.Date);

            // by hour

            var outdic = new Dictionary<string, int>();
            foreach (var item in processlist)
            {
                outdic[item.Key.ToString("o")] = item.Sum(i => i.Value);
            }


            return outdic;
        }
    }
}
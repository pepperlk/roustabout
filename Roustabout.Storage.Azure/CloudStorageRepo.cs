using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.WindowsAzure.Storage.Table;
using Roustabout.Storage.Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WindowsAzure.ChronoTableStorage;

namespace System
{
    public static class StringHelper
    {
        public static string ToAzureKey(this string input)
        {
            var re = new Regex(@"[?@#/:\\;\s]\s*", RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase);
            return re.Replace(input, "_");
        }
    }

    




}



namespace Microsoft.WindowsAzure.Storage.Table
{
    public static class TableEntityHelper
    {
        public static void AutoID(this TableEntity ent, int generatorid = 0, DateTime? time = null)
        {
            /// var id = string.Format("{0:D19}", DateTime.MaxValue.Ticks - DateTime.UtcNow.Ticks) + ShortGuid.NewGuid();

            ent.PartitionKey = new IdGen.IdGenerator(generatorid).CreateId().ToString();
            if (!time.HasValue)
            {
                time = DateTime.UtcNow;
            }

            ent.RowKey = RowKey.CreateReverseChronological(time.GetValueOrDefault());

        }


        public static void AutoIDGuid(this TableEntity ent, DateTime? time = null)
        {
            /// var id = string.Format("{0:D19}", DateTime.MaxValue.Ticks - DateTime.UtcNow.Ticks) + ShortGuid.NewGuid();

            ent.PartitionKey = Guid.NewGuid().ToString();
            if (!time.HasValue)
            {
                time = DateTime.UtcNow;
            }

            ent.RowKey = RowKey.CreateReverseChronological(time.GetValueOrDefault());

        }


        public static TableQuery<T> InOrder<T>(this TableQuery<T> ent, string where = "") where T : ITableEntity
        {
            if (string.IsNullOrEmpty(where))
            {
                ent.Where(ChronologicalTableQuery.GenerateFilterCondition(QueryDateReverseChronologicalComparisons.BeforeOrEqual, DateTime.UtcNow));
            }
            else
            {
                ent.Where(TableQuery.CombineFilters(ChronologicalTableQuery.GenerateFilterCondition(QueryDateReverseChronologicalComparisons.BeforeOrEqual, DateTime.UtcNow), "and", where ));
            }
            return ent;
        }


        public static TableQuery InOrder(this TableQuery ent, string where = "") 
        {
            if (string.IsNullOrEmpty(where))
            {
                ent.Where(ChronologicalTableQuery.GenerateFilterCondition(QueryDateReverseChronologicalComparisons.BeforeOrEqual, DateTime.UtcNow));
            }
            else
            {
                ent.Where(TableQuery.CombineFilters(where, "and", ChronologicalTableQuery.GenerateFilterCondition(QueryDateReverseChronologicalComparisons.BeforeOrEqual, DateTime.UtcNow)));
            }
            return ent;
        }
    }
}



namespace Roustabout.Storage.Azure
{

    public static class MiscExtensions
    {
        // Ex: collection.TakeLast(5);
        public static IEnumerable<T> TakeLast<T>(IEnumerable<T> source, int N)
        {
            return source.Skip(Math.Max(0, source.Count() - N));
        }
    }

    public class CloudStorageRepo
    {

        private CloudStorageAccount _account;
        private CloudTableClient _tableClient;
        private CloudQueueClient _queueClient;
        private CloudBlobClient _blobcli;

        public CloudStorageRepo()
        {



            _account = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("RB.Storage.Azure"));

            CloudTableClient tableClient = new CloudTableClient(_account.TableEndpoint, _account.Credentials)
            {
                // Values supported can be AtomPub, Json, JsonFullMetadata or JsonNoMetadata
                //                PayloadFormat = TablePayloadFormat.JsonNoMetadata

            };
            tableClient.DefaultRequestOptions.PayloadFormat = TablePayloadFormat.JsonNoMetadata;
            tableClient.DefaultRequestOptions.MaximumExecutionTime = TimeSpan.FromSeconds(10);
            


             _tableClient = tableClient;// _account.CreateCloudTableClient();
            //_tableClient = _account.CreateCloudTableClient();
            _queueClient = _account.CreateCloudQueueClient();
            _blobcli = _account.CreateCloudBlobClient();

        }

        public CloudTableClient GetTableClient()
        {
            return _tableClient;
        }




        public CloudQueueClient GetQueueClient()
        {
            return _queueClient;
        }


        public CloudStorageAccount GetAccount()
        {
            return _account;
        }


        public CloudBlobClient GetBlobClient()
        {
            return _blobcli;
        }
    }
}

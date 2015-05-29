using Microsoft.WindowsAzure.Storage.Table;

namespace Roustabout.Storage.Azure
{
    public class EventEntity : TableEntity
    {
        public EventEntity()
        {
        }

        public string Action { get; set; }
        public string Category { get;  set; }
        public int Value { get;  set; }
    }
}
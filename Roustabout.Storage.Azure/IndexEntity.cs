using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Storage.Azure
{
    public class IndexEntity : TableEntity
    {

        public string RemPartKey { get; set; }

        public string RemRowKey { get; set; }

        public string Type { get; set; }

        public string Table { get; set; }
    }
}

using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Storage.Azure
{
    public class LogEntity : TableEntity
    {
        public string Log { get; set; }
        public string Type { get; set; }
    }
}

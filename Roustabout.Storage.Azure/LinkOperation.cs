using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Storage.Azure
{
    public class LinkOperation
    {
        private TableEntity parent;
        private MasterIndexRepo masterIndexRepo;
        private string id;

        public Dictionary<Type, List<object>> Children { get; set; }

        public LinkOperation(TableEntity parent, MasterIndexRepo masterIndexRepo)
        {
            // TODO: Complete member initialization
            this.parent = parent;
            this.masterIndexRepo = masterIndexRepo;
        }

      

        internal void PopulateChildren()
        {


            Children = new Dictionary<Type, List<object>>();


            

            var indexes = masterIndexRepo.GetChildrenIndexOf(parent).GroupBy(i => i.Type);

            foreach (var group in indexes)
            {
                var table = masterIndexRepo.GetTableFromType(Type.GetType(group.FirstOrDefault().Type));

                Children[Type.GetType(group.FirstOrDefault().Type)] = new List<object>();

                foreach (var index in group)
                {
                    var item = table.Get(index.PartitionKey);
                    Children[Type.GetType(group.FirstOrDefault().Type)].Add(item);

                }
            }



        }
    }
}

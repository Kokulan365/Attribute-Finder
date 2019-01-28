using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeFinder.Model
{
    public class AttributeViewModel
    {
        public string DisplayName { get; set; }
        public string LogicalName { get; set; }
        public string AttributeType { get; set; }
        public string SchemaName { get; set; }

        public string EntityLogicalName { get; set; }
        public string EntityDisplayName { get; set; }

    }
}

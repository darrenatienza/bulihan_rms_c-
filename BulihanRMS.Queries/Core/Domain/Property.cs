using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class Property
    {
        public Property() { }
        public int PropertyID { get; set; }
        public string Description { get; set; }
        public int Quantiy { get; set; }
        public string Remarks { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public int  PropertyTypeID { get; set; }
        
    }
}

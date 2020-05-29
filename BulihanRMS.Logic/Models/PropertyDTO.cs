using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class PropertyDTO
    {
        public PropertyDTO() { }
        public int ID { get; internal set; }

        public string Description { get; set; }


        public int PropertyTypeID { get; set; }

        public int Quantiy { get; set; }

        public string Remarks { get; set; }
    }
    public class PropertyListDTO
    {
        public PropertyListDTO() { }

        public string PropertyTypeDescription { get; set; }
        public int Quantity { get; set; }
        public string Remarks { get; set; }


        public int ID { get; set; }

        public string Description { get; set; }
    }
}

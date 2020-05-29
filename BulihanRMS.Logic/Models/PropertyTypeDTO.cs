using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class PropertyTypeDTO
    {
        public PropertyTypeDTO() { }
        public int ID { get; internal set; }

        public string Description { get; set; }
  
    }
    public class PropertyTypeListDTO
    {
        public PropertyTypeListDTO() { }

        public string Description { get; set; }
        

        public int ID { get; set; }
    }
}

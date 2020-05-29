using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class ChildrenDTO
    {
        public ChildrenDTO() { }
        public int ID { get; internal set; }


        public string FullName { get; set; }

        public string Age { get; set; }

        public string Occupation { get; set; }

        public int PersonalInfoID { internal get; set; }
    }
    public class ChildrenListDTO
    {
        public ChildrenListDTO() { }


        public string FullName { get; set; }

        public string Age { get; set; }

        public string Occupation { get; set; }

        public int ID { get; set; }
    }
}

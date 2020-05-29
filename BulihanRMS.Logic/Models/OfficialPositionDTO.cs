using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class OfficialPositionDTO
    {
        public OfficialPositionDTO() { }
        public int ID { get; internal set; }


        public string FullName { get; set; }

        public string Age { get; set; }

        public string Occupation { get; set; }

        public int PersonalInfoID { internal get; set; }
    }
    public class OfficialPositionListDTO
    {
        public OfficialPositionListDTO() { }


        public string FullName { get; set; }

        public string Age { get; set; }

        public string Occupation { get; set; }

        public int ID { get; set; }

        public string Description { get; set; }
    }
}

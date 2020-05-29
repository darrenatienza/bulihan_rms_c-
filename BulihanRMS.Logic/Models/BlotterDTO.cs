using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class BlotterDTO
    {
        public BlotterDTO() { }
        public int ID { get; internal set; }
        public DateTime Date { get; internal set; }
        public string What { get; set; }

        public string Where { get; set; }

        public string When { get; set; }

        public int PersonalInfoID { get; set; }
    }
    public class BlotterDTOV2
    {
        public BlotterDTOV2() { }
        public int ID { get; internal set; }
        public DateTime Date { get; internal set; }
        public string What { get; set; }

        public string Where { get; set; }

        public string When { get; set; }

        public string FullName { get; set; }
    }
    public class BlotterListDTO
    {
        public BlotterListDTO() { }

        public DateTime Date { get; set; }
        public string FullName { get; set; }

        public int ID { get; set; }
    }
}

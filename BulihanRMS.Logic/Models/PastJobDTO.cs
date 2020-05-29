using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class PastJobDTO
    {
        public PastJobDTO() { }
        public int ID { get; internal set; }


        
        public int PersonalInfoID { internal get; set; }

        public string Description { get; set; }

        public string InclusiveDate { get; set; }

        public string Salary { get; set; }

        public string ReasonOfLeaving { get; set; }
    }
    public class PastJobListDTO
    {
        public PastJobListDTO() { }

        public int ID { get; internal set; }

        public string Description { get; set; }

        public string InclusiveDate { get; set; }

        public string ReasonOfLeaving { get; set; }

        public string Salary { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class PastJob
    {
        public PastJob() { }
        public int PastJobID { get; set; }
        public string Description { get; set; }
        public string InclusiveDate { get; set; }
        public string Salary { get; set; }
        public string ReasonOfLeaving { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public int PersonalInfoID { get; set; }
    }
}

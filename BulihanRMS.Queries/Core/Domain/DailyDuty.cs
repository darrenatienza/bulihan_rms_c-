using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class DailyDuty
    {
        public DailyDuty() { }
        public int DailyDutyID { get; set; }
        public DateTime Date { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public  int PersonalInfoID { get; set; }
        public DateTime? In { get; set; }
        public DateTime? Out { get; set; }
        
    }
}

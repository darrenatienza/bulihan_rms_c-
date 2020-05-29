using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class DailyDutyDTO
    {
        public DailyDutyDTO() { }
        public int ID { get; internal set; }

        public int PersonalInfoID { get; set; }


        public DateTime? In { get; set; }

        public DateTime? Out { get; set; }

        public DateTime Date { get; set; }
    }
    public class DailyDutyListDTO
    {
        public DailyDutyListDTO() { }

        public int ID { get; set; }

        public DateTime? In { get; set; }

        public DateTime? Out { get; set; }

        public string FullName { get; set; }

        public DateTime Date { get; set; }
    }
}

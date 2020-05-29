using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class DashboardSummaryDTO
    {
        public DashboardSummaryDTO() { }
        public int PersonalInfoTodayCount { get; set; }
        public int PersonalInfoWeeklyCount { get; set; }
        public int PersonalInfoMonthlyCount { get; set; }
        public int PersonalInfoTotalCount { get; set; }

        public int BrgyClearanceTodayCount { get; set; }
        public int BrgyClearanceWeeklyCount { get; set; }
        public int BrgyClearanceMonthlyCount { get; set; }

        public int BizClearanceTodayCount { get; set; }
        public int BizClearanceWeeklyCount { get; set; }
        public int BizClearanceMonthlyCount { get; set; }
    }
   
}

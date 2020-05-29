using BulihanRMS.Queries.Core.Domain;
using BulihanRMS.Queries.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BulihanRMS.Queries.Persistence.Repositories
{
    public class BusinessClearanceRepo : Repository<BusinessClearance>, IBusinessClearanceRepo
    {
        public BusinessClearanceRepo(DataContext context)
            : base(context)
        {
        }
        
        public DataContext DataContext
        {
            get
            {
                return Context as DataContext;
            }
        }

        public BusinessClearance GetV2(int id)
        {
            return DataContext.BusinessClearances
                 .Include(x => x.PersonalInfo)
                 .FirstOrDefault(x => x.BusinessClearanceID == id);
        }


        public IEnumerable<BusinessClearance> GetAllBy(DateTime date, string criteria)
        {
            return DataContext.BusinessClearances
                 .Include(x => x.PersonalInfo)
                 .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(date) && x.PersonalInfo.Name.Contains(criteria));
        }


        public int GetMonthlyCount()
        {
            return DataContext.BusinessClearances
                 .Include(x => x.PersonalInfo)
                 .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp).Value.Month == DbFunctions.TruncateTime(DateTime.Now).Value.Month && DbFunctions.TruncateTime(x.CreateTimeStamp).Value.Year == DbFunctions.TruncateTime(DateTime.Now).Value.Year).Count();
        }


        public int GetTodayCount()
        {
            return DataContext.BusinessClearances
                  .Include(x => x.PersonalInfo)
                  .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(DateTime.Now)).Count();
        }

        public int GetWeeklyCount()
        {
            var firstDayofWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            var lastDayofWeek = firstDayofWeek.AddDays(7);
            return DataContext.BusinessClearances
                  .Include(x => x.PersonalInfo)
                  .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) >= DbFunctions.TruncateTime(firstDayofWeek) 
                      && DbFunctions.TruncateTime(x.CreateTimeStamp) <= DbFunctions.TruncateTime(lastDayofWeek)).Count();
        }


    }
    

   
}

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
    public class DailyDutyRepo : Repository<DailyDuty>, IDailyDutyRepo
    {
        public DailyDutyRepo(DataContext context)
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



        public IEnumerable<DailyDuty> GetAllBy(string criteria)
        {
            return DataContext.DailyDuties.Where(r => r.PersonalInfo.Name.Contains(criteria));
        }


        public IEnumerable<DailyDuty> GetAllBy(DateTime date, string criteria)
        {
            return DataContext.DailyDuties.Include(r => r.PersonalInfo).Where(r => DbFunctions.TruncateTime(r.Date).Value.Month == DbFunctions.TruncateTime(date).Value.Month
                && DbFunctions.TruncateTime(r.Date).Value.Year == DbFunctions.TruncateTime(date).Value.Year
                && r.PersonalInfo.Name.Contains(criteria));
        }
    }

   
}

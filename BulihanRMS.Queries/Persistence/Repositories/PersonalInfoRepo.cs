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
    public class PersonalInfoRepo : Repository<PersonalInfo>, IPersonalInfoRepo
    {
        public PersonalInfoRepo(DataContext context)
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

        public IEnumerable<PersonalInfo> GetAll(string criteria)
        {
            return DataContext.PersonalInfos.Where(r => r.Name.Contains(criteria)).ToList();
        }


        public DateTime GetBirthday(int personalInfoID)
        {
            return DataContext.PersonalInfos.Where(r => r.PersonalInfoID == personalInfoID).Select(r => r.Birthday).FirstOrDefault();
        }


        public int GetMonthlyCount()
        {
            return DataContext.PersonalInfos

                  .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp).Value.Month == DbFunctions.TruncateTime(DateTime.Now).Value.Month
                      && DbFunctions.TruncateTime(x.CreateTimeStamp).Value.Year == DbFunctions.TruncateTime(DateTime.Now).Value.Year).Count();
        }

        public int GetTodayCount()
        {
            return DataContext.PersonalInfos
                  .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(DateTime.Now)).Count();
        }

        public int GetWeeklyCount()
        {
            var firstDayofWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            var lastDayofWeek = firstDayofWeek.AddDays(7);
            return DataContext.PersonalInfos
                  .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) >= DbFunctions.TruncateTime(firstDayofWeek)
                      && DbFunctions.TruncateTime(x.CreateTimeStamp) <= DbFunctions.TruncateTime(lastDayofWeek)).Count();
        }

        public IEnumerable<PersonalInfo> GetAll(string criteria, bool isResidence)
        {
            return DataContext.PersonalInfos.Where(r => r.Name.Contains(criteria) && r.IsResidence == isResidence).ToList();
        }


        public IEnumerable<PersonalInfo> GetAll(string criteria, bool isResidence, bool isWorker)
        {
            return DataContext.PersonalInfos.Where(r => r.Name.Contains(criteria) && (r.IsResidence == isResidence && r.IsWorker == isWorker)).ToList();
        }


        public IEnumerable<PersonalInfo> GetWorkers()
        {
            return DataContext.PersonalInfos.Where(r => r.IsWorker).ToList();
        }


        public int GetTotalResidentCount()
        {
            return DataContext.PersonalInfos
                  .Where(x => x.IsResidence).Count();
        }
    }

   
}

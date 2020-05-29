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
    public class IndigencyRepo : Repository<Indigency>, IIndigencyRepo
    {
        public IndigencyRepo(DataContext context)
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

        public IEnumerable<Indigency> GetAllBy(DateTime date, string criteria)
        {
            return DataContext.Indigencies
                 .Include(x => x.PersonalInfo)
                 .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(date) && x.PersonalInfo.Name.Contains(criteria));
        }


        public Indigency GetV2(int id)
        {
            return DataContext.Indigencies
              .Include(x => x.PersonalInfo)
              .FirstOrDefault(x => x.IndigencyID == id);
        }
    }

   
}

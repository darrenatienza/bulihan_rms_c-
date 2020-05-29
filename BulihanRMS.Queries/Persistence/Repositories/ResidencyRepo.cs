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
    public class ResidencyRepo : Repository<Residency>, IResidencyRepo
    {
        public ResidencyRepo(DataContext context)
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



        public IEnumerable<Residency> GetAllBy(DateTime date, string criteria)
        {
            return DataContext.Residencies
                .Include(x => x.PersonalInfo)
                .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(date) && x.PersonalInfo.Name.Contains(criteria));
        }


        public Residency GetV2(int id)
        {
            return DataContext.Residencies
               .Include(x => x.PersonalInfo)
               .FirstOrDefault(x => x.ResidencyID == id);
        }
    }

   
}

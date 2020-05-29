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
    public class OfficialRepo : Repository<Official>, IOfficialRepo
    {
        public OfficialRepo(DataContext context)
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


        public IEnumerable<Official> GetAllBy(string criteria)
        {
            return DataContext.Officials.Include(r => r.OfficialGroup).Include(r => r.OfficialPosition)
                .Include(r => r.PersonalInfo)
                .Where(r => r.PersonalInfo.Name.Contains(criteria) || r.OfficialPosition.Description.Contains(criteria));
        }


        public Official GetByOfficialPosition(string officialPosition)
        {
            return DataContext.Officials
                 .Include(r => r.PersonalInfo)
                 .FirstOrDefault(r => r.OfficialPosition.Description.Contains(officialPosition));
        }
    }

   
}

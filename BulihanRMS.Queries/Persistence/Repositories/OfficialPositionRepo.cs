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
    public class OfficialPositionRepo : Repository<OfficialPosition>, IOfficialPositionRepo
    {
        public OfficialPositionRepo(DataContext context)
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

        public IEnumerable<OfficialPosition> GetAllBy(string criteria)
        {
            return DataContext.OfficialPositions.Where(r => r.Description.Contains(criteria)).ToList();
        }
    }

   
}

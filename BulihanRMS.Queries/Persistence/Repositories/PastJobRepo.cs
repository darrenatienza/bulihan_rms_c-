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
    public class PastJobRepo : Repository<PastJob>, IPastJobRepo
    {
        public PastJobRepo(DataContext context)
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

        public IEnumerable<PastJob> GetAllBy(int personalInfoID)
        {
            return DataContext.PastJobs.Where(r => r.PersonalInfoID == personalInfoID).ToList();
        }
    }

   
}

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
    public class BlotterRepo : Repository<Blotter>, IBlotterRepo
    {
        public BlotterRepo(DataContext context)
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



        public IEnumerable<Blotter> GetAllBy(DateTime date, string criteria)
        {
            return DataContext.Blotters.Include(x => x.PersonalInfo).Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(date) && x.PersonalInfo.Name.Contains(criteria));
        }


        public Blotter GetV2(int blotterID)
        {
            return DataContext.Blotters.Include(x => x.PersonalInfo).FirstOrDefault(x => x.BlotterID == blotterID);
        }
    }

   
}

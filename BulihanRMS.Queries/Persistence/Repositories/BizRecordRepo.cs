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
    public class BizRecordRepo : Repository<BizRecord>, IBizRecordRepo
    {
        public BizRecordRepo(DataContext context)
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


        public IEnumerable<BizRecord> GetAllBy(string criteria)
        {
            return DataContext.BizRecords.Include(x => x.PersonalInfo).Where(x => x.BusinessName.Contains(criteria) && x.PersonalInfo.Name.Contains(criteria)).ToList();
        }


        public BizRecord GetBy(int id)
        {
            return DataContext.BizRecords.Include(x => x.PersonalInfo).Include(x => x.BizWorker.Select(y => y.PersonalInfo)).FirstOrDefault(x => x.BizRecordID == id);
        }
    }

   
}

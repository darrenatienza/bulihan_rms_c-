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
    public class ChildrenRepo : Repository<Children>, IChildrenRepo
    {
        public ChildrenRepo(DataContext context)
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

        public IEnumerable<Children> GetAllBy(int personalInfoID)
        {
            return DataContext.Childrens.Where(r => r.PersonalInfoID == personalInfoID).ToList();
        }
    }

   
}

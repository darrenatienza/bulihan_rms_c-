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
    public class PropertyRepo : Repository<Property>, IPropertyRepo
    {
        public PropertyRepo(DataContext context)
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



        public IEnumerable<Property> GetAllBy(string criteria)
        {
            return DataContext.Properties.Include(r => r.PropertyType).Where(r => r.Description.Contains(criteria));
        }
    }

   
}

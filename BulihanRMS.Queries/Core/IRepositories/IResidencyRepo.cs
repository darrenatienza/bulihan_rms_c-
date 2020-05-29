using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.IRepositories
{
    public interface IResidencyRepo : IRepository<Residency>
    {
        IEnumerable<Residency> GetAllBy(DateTime date, string criteria);

        Residency GetV2(int id);
    }
}

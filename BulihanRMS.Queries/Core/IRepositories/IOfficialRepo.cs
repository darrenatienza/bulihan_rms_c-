using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.IRepositories
{
    public interface IOfficialRepo : IRepository<Official>
    {

        IEnumerable<Official> GetAllBy(string criteria);

        Official GetByOfficialPosition(string officialPosition);
    }
}

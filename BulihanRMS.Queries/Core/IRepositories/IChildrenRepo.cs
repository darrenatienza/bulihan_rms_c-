using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.IRepositories
{
    public interface IChildrenRepo : IRepository<Children>
    {

        IEnumerable<Children> GetAllBy(int personalInfoID);
    }
}

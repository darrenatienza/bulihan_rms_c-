using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.IRepositories
{
    public interface IDailyDutyRepo : IRepository<DailyDuty>
    {


        IEnumerable<DailyDuty> GetAllBy(string criteria);

        IEnumerable<DailyDuty> GetAllBy(DateTime date, string criteria);
    }
}

using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.IRepositories
{
    public interface IBusinessClearanceRepo : IRepository<BusinessClearance>
    {



        BusinessClearance GetV2(int id);

        IEnumerable<BusinessClearance> GetAllBy(DateTime date, string criteria);

        int GetMonthlyCount();

        int GetTodayCount();

        int GetWeeklyCount();
    }
}

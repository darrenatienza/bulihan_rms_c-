using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.IRepositories
{
    public interface IBarangayClearanceRepo : IRepository<BarangayClearance>
    {



        IEnumerable<BarangayClearance> GetAllBy(DateTime date, string criteria);

        BarangayClearance GetV2(int id);

        int GetMonthlyCount();

        int GetTodayCount();

        int GetWeeklyCount();
    }
}

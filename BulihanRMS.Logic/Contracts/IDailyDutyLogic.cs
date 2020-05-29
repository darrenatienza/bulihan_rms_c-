using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IDailyDutyLogic : ILogic<DailyDutyDTO>
    {

        IEnumerable<DailyDutyListDTO> GetAllBy(string criteria);
        IEnumerable<DailyDutyListDTO> GetAllBy(DateTime date, string criteria);
    }
}

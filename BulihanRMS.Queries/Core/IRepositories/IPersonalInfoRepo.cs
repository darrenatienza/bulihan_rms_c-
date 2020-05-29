using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.IRepositories
{
    public interface IPersonalInfoRepo : IRepository<PersonalInfo>
    {

        IEnumerable<PersonalInfo> GetAll(string criteria, bool isResidence);

        DateTime GetBirthday(int personalInfoID);

        int GetMonthlyCount();

        int GetTodayCount();

        int GetWeeklyCount();

        IEnumerable<PersonalInfo> GetAll(string criteria, bool isResidence, bool isWorker);

        IEnumerable<PersonalInfo> GetWorkers();

        int GetTotalResidentCount();
    }
}

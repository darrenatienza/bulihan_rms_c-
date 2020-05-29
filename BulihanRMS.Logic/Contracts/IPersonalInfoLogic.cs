using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IPersonalInfoLogic : ILogic<PersonalInfoDTO>
    {
        IEnumerable<PersonalInfoListDTO> GetAll();


        IEnumerable<PersonalInfoListDTO> GetAllBy(string criteria, bool isResidence);

        int GetAge(int personalInfoID);

        PersonalInfoBarangayClearanceDTO GetBarangayClearanceInfo(int personalInfoID);

        IEnumerable<PersonalInfoListDTO> GetAllBy(string criteria, bool isResidence, bool isWorker);

        IEnumerable<PersonalInfoComboListDTO> GetWorkers();
    }
}

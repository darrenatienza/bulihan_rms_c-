using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IBusinessClearanceLogic : ILogic<BusinessClearanceDTO>
    {
        IEnumerable<BusinessClearanceListDTO> GetAllBy(DateTime date, string criteria);



        BusinessClearanceDTOV2 GetV2(int id);
    }
}

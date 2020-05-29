using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IResidencyLogic : ILogic<ResidencyDTO>
    {
        IEnumerable<ResidencyListDTO> GetAllBy(DateTime date, string criteria);



        ResidencyDTOV2 GetV2(int id);
    }
}

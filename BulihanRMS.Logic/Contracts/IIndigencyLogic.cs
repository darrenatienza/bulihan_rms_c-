using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IIndigencyLogic : ILogic<IndigencyDTO>
    {
        IEnumerable<IndigencyListDTO> GetAllBy(DateTime date, string criteria);



        IndigencyDTOV2 GetV2(int id);
    }
}

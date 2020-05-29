using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IBlotterLogic : ILogic<BlotterDTO>
    {
        IEnumerable<BlotterListDTO> GetAllBy(DateTime date, string criteria);



        BlotterDTOV2 GetV2(int blotterID);
    }
}

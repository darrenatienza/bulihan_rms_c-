using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IOfficialLogic : ILogic<OfficialDTO>
    {
        IEnumerable<OfficialListDTO> GetAllBy(string criteria);


        string GetFullNameByOfficialPosition(string p);

        OfficialDetailDTO GetByOfficialPosition(string p);
    }
}

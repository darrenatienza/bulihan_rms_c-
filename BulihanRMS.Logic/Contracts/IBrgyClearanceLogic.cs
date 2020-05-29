using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IBrgyClearanceLogic : ILogic<BrgyClearanceDTO>
    {
        IEnumerable<BrgyClearanceListDTO> GetAllBy(DateTime date, string criteria);



        BarangayClearanceDTOV2 GetV2(int id);
    }
}

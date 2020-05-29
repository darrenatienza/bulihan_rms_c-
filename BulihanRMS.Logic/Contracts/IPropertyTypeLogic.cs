using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IPropertyTypeLogic : ILogic<PropertyTypeDTO>
    {


        IEnumerable<PropertyTypeListDTO> GetAllBy(string criteria);
    }
}

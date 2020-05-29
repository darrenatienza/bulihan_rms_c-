using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IUserLogic 
    {

        void Edit(int userID, UserDTO dto);

        void LoginUser(string p1, string p2);
    }
}

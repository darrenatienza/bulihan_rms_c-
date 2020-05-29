using BulihanRMS.Logic.Contracts;
using BulihanRMS.Logic.Models;
using BulihanRMS.Queries.Core.Domain;
using BulihanRMS.Queries.Persistence;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Implementors
{
    public class UserLogic : IUserLogic
    {

        public void Edit(int userID, UserDTO dto)
        {
            if (dto.Password != dto.RetypePassword)
            {
                throw new ApplicationException("Password does not match!");
            }
            var crypto = new SimpleCrypto.PBKDF2();
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var user = uow.Users.Get(userID);
                var encrypPass = crypto.Compute(dto.Password);
                
                user.Password = encrypPass;
                user.PasswordSalt = crypto.Salt;
                uow.Users.Edit(user);
                uow.Complete();
            }
        }
        public void LoginUser(string userName, string password)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            using (var uow = new UnitOfWork(new DataContext()))
            {
                User user = uow.Users.GetUser(userName);
                if (user != null)
                {
                    if (user.Password != crypto.Compute(password, user.PasswordSalt))
                    {
                        throw new ApplicationException("Invalid Password!");
                    }
                    else
                    {
                        CurrentUser.UserID = user.UserID;
                        CurrentUser.UserName = user.UserName;
                      
                    }
                }
                else
                {
                    throw new ApplicationException("Invalid User Name!");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class UserDTO
    {
        public UserDTO() { }
        public int ID { get; internal set; }
        public string UserName { get; internal set; }
        public string Password { get; set; }
        public string RetypePassword { get; set; }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class Indigency
    {
        public Indigency()
        {

        }
        public int IndigencyID { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public string Purpose { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set;}
        public int PersonalInfoID { get; set; }
    }
}

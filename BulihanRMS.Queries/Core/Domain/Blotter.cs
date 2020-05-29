using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class Blotter
    {
        public Blotter()
        {

        }
        public int BlotterID { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public string What { get; set; }
        public string Where { get; set; }
        public string When { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set;}
        public int PersonalInfoID { get; set; }
    }
}

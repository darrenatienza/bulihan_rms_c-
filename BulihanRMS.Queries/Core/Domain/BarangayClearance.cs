using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class BarangayClearance
    {
        public BarangayClearance()
        {

        }
        public int BarangayClearanceID { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public string Purok { get; set; }
        public string Sitio { get; set; }
        public string SedulaBlg { get; set; }
        public string KinuhaSa { get; set; }
        public string NoongIka { get; set; }
        public string ORNo { get; set; }
        public string ORDate { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set;}
        public int PersonalInfoID { get; set; }
    }
}

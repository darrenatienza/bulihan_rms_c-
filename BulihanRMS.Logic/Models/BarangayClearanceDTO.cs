using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class BrgyClearanceDTO
    {
        public BrgyClearanceDTO() { }
        public int ID { get; internal set; }
        public DateTime Date { get; set; }
        public string Purok { get; set; }
        public string Sitio { get; set; }
        public string SedulaBlg { get; set; }
        public string KinuhaSa { get; set; }
        public string NoongIka { get; set; }
        public string ORNo { get; set; }
        public string ORDate { get; set; }
        public int PersonalInfoID { get; set; }
    }
    public class BarangayClearanceDTOV2
    {
        public BarangayClearanceDTOV2() { }
        public int ID { get; internal set; }
        public DateTime Date { get; set; }
        public string Purok { get; set; }
        public string Sitio { get; set; }
        public string SedulaBlg { get; set; }
        public string KinuhaSa { get; set; }
        public string NoongIka { get; set; }
        public string ORNo { get; set; }
        public string ORDate { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }
    }
    public class BrgyClearanceListDTO
    {
        public BrgyClearanceListDTO() { }

        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public int ID { get; set; }
    }
}

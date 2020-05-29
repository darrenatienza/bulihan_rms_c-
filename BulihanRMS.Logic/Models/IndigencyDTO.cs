using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class IndigencyDTO
    {
        public IndigencyDTO() { }
        public int ID { get; internal set; }
        public DateTime Date { get; set; }
        public string Purpose { get; set; }
        public int PersonalInfoID { get; set; }
    }
    public class IndigencyDTOV2
    {
        public IndigencyDTOV2() { }
        public int ID { get; internal set; }
        public DateTime Date { get; set; }
        public string Purpose { get; set; }

        public string FullName { get; set; }
    }
    public class IndigencyListDTO
    {
        public IndigencyListDTO() { }

        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string Purpose { get; set; }
        public int ID { get; set; }
    }
}

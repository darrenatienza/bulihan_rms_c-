using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class ResidencyDTO
    {
        public ResidencyDTO() { }
        public int ID { get; internal set; }
        public DateTime Date { get; set; }
        public string LengthOfResidency { get; set; }
        public string RequestedBy { get; set; }
        public int PersonalInfoID { get; set; }
    }
    public class ResidencyDTOV2
    {
        public ResidencyDTOV2() { }
        public int ID { get; internal set; }
        public DateTime Date { get; set; }
        public string LengthOfResidency { get; set; }
        public string RequestedBy { get; set; }

        public string FullName { get; set; }
    }
    public class ResidencyListDTO
    {
        public ResidencyListDTO() { }

        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string RequestedBy { get; set; }
        public int ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class FamilyMedicalHistoryDTO
    {
        public FamilyMedicalHistoryDTO() { }
        public int ID { get; internal set; }
        public string Name { get; set; }
        public string Illness { get; set; }
        public int PersonalInfoID { internal get; set; }
    }
    public class FamilyMedicalHistoryListDTO
    {
        public FamilyMedicalHistoryListDTO() { }

        public int ID { get; internal set; }
        public string Name { get; set; }
        public string Illness { get; set; }

    }
}

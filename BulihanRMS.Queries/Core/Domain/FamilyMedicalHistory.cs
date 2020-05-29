using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class FamilyMedicalHistory
    {
        public FamilyMedicalHistory() { }
        public int FamilyMedicalHistoryID { get; set; }
        public string Name { get; set; }
        public string Illness { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public int PersonalInfoID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class PersonalInfo
    {
        public PersonalInfo()
        {

        }
        public int PersonalInfoID { get; set; }
        public DateTime? CreateTimeStamp { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string LengthOfResidency { get; set; }
        public string Citizenship { get; set; }
        public string CivilStatus { get; set; }
        public string Religion { get; set; }
        public string FathersName { get; set; }
        public string FatherOccupation { get; set; }
        public string MothersName { get; set; }
        public string MotherOccupation { get; set; }
        public int SisterCount { get; set; }
        public int BrotherCount { get; set; }
        public string SpouseName { get; set; }
        public string SpouseOccupation { get; set; }
        // Number of childres List
        public virtual ICollection<Children> Childrens { get; set; }
        public string PrimarySchoolName { get; set; }
        public string PrimaryInclusiveDate { get; set; }
        public string PrimaryCourse { get; set; }

        public string SecondarySchoolName { get; set; }
        public string SecondaryInclusiveDate { get; set; }
        public string SecondaryCourse { get; set; }
        public string TertiarySchoolName { get; set; }
        public string TertiaryInclusiveDate { get; set; }
        public string TertiaryCourse { get; set; }
        public string VocationalSchoolName { get; set; }
        public string VocationalInclusiveDate { get; set; }
        public string VocationalCourse { get; set; }

        //Family Medical History List
        public virtual ICollection<FamilyMedicalHistory> FamilyMedicalHistories { get; set; }
        public bool HasRelativesMedicalIllness { get; set; }
        public string PresentOccupation { get; set; }
        public string Position { get; set; }
        public string EstimatedSalary { get; set; }
        public string WorkingLength { get; set; }
        // Past Jobs List
        public virtual ICollection<PastJob> PastJobs { get; set; }
        public bool IsResidence { get; set; }
        public bool IsWorker { get; set; }

        public ICollection<BizRecord> BizRecords { get; set; }
    }
}

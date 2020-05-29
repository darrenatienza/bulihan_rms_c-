using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class PersonalInfoDTO
    {
        public PersonalInfoDTO() { }
        public int PersonalInfoID { get; internal set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; internal set; }
        public string Sex { get; set; }
        public string Address { get; set; }
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

        public bool HasRelativesMedicalIllness { get; set; }
        public string PresentOccupation { get; set; }
        public string Position { get; set; }
        public string EstimatedSalary { get; set; }
        public string WorkingLength { get; set; }


        public bool IsResidence { get; set; }

        public bool IsWorker { get; set; }

        public string ContactNumber { get; set; }
    }
    public class PersonalInfoListDTO
    {
        public PersonalInfoListDTO() { }


        public string Address { get; set; }

        public string Gender { get; set; }

        public string FullName { get; set; }

        public int ID { get; set; }

        public int Age { get; set; }
    }
    public class PersonalInfoComboListDTO
    {
        public PersonalInfoComboListDTO() { }

        public string FullName { get; set; }

        public int ID { get; set; }

       
    }
    public class PersonalInfoBarangayClearanceDTO
    {
        public PersonalInfoBarangayClearanceDTO() { }

        public string FullName { get; internal set; }

        public int Age { get; internal set; }
    }
}

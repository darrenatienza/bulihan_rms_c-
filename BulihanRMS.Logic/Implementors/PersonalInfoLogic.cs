using BulihanRMS.Logic.Contracts;
using BulihanRMS.Logic.Models;
using BulihanRMS.Queries.Core.Domain;
using BulihanRMS.Queries.Persistence;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Implementors
{
    public class PersonalInfoLogic : IPersonalInfoLogic
    {
        public PersonalInfoDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PersonalInfos.Get(id);
                var personalInfo = new PersonalInfoDTO();
                personalInfo.Age = Utils.CalculateAge(obj.Birthday);
                personalInfo.ContactNumber = obj.ContactNumber;
                personalInfo.Address = obj.Address;
                personalInfo.Birthday = obj.Birthday;
                personalInfo.BrotherCount = obj.BrotherCount;
                personalInfo.Citizenship = obj.Citizenship;
                personalInfo.CivilStatus = obj.CivilStatus;
                personalInfo.EstimatedSalary = obj.EstimatedSalary;
                personalInfo.FatherOccupation = obj.FatherOccupation;
                personalInfo.FathersName = obj.FathersName;
                personalInfo.HasRelativesMedicalIllness = obj.HasRelativesMedicalIllness;
                personalInfo.LengthOfResidency = obj.LengthOfResidency;
                personalInfo.MotherOccupation = obj.MotherOccupation;
                personalInfo.MothersName = obj.MothersName;
                personalInfo.Name = obj.Name;
                personalInfo.Position = obj.Position;
                personalInfo.PresentOccupation = obj.PresentOccupation;
                personalInfo.PrimaryCourse = obj.PrimaryCourse;
                personalInfo.PrimaryInclusiveDate = obj.PrimaryInclusiveDate;
                personalInfo.PrimarySchoolName = obj.PrimarySchoolName;
                personalInfo.Religion = obj.Religion;
                personalInfo.SecondaryCourse = obj.SecondaryCourse;
                personalInfo.SecondaryInclusiveDate = obj.SecondaryInclusiveDate;
                personalInfo.SecondarySchoolName = obj.SecondarySchoolName;
                personalInfo.Sex = obj.Sex;
                personalInfo.SisterCount = obj.SisterCount;
                personalInfo.SpouseName = obj.SpouseName;
                personalInfo.SpouseOccupation = obj.SpouseOccupation;
                personalInfo.TertiaryCourse = obj.TertiaryCourse;
                personalInfo.TertiaryInclusiveDate = obj.TertiaryInclusiveDate;
                personalInfo.TertiarySchoolName = obj.TertiarySchoolName;
                personalInfo.VocationalCourse = obj.VocationalCourse;
                personalInfo.VocationalInclusiveDate = obj.VocationalInclusiveDate;
                personalInfo.VocationalSchoolName = obj.VocationalSchoolName;
                personalInfo.WorkingLength = obj.WorkingLength;
                personalInfo.IsResidence = obj.IsResidence;
                personalInfo.IsWorker = obj.IsWorker;
                return personalInfo;
            }
        }
       
        public IEnumerable<PersonalInfoListDTO> GetAll()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.PersonalInfos.GetAll();
                var dtos = new List<PersonalInfoListDTO>();
                foreach (var item in objs)
                {
                    var dto = new PersonalInfoListDTO();
                    dto.ID = item.PersonalInfoID;
                    dto.FullName = item.Name;
                    dto.Gender = item.Sex;
                    dto.Age = Utils.CalculateAge(item.Birthday);
                    dto.Address = item.Address;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }
        
        public void Add(PersonalInfoDTO personalInfo)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new PersonalInfo();
                obj.CreateTimeStamp = DateTime.Now;
                obj.ContactNumber = personalInfo.ContactNumber;
                obj.Address = personalInfo.Address;
                obj.Birthday = personalInfo.Birthday;
                obj.BrotherCount = personalInfo.BrotherCount;
                obj.Citizenship = personalInfo.Citizenship;
                obj.CivilStatus = personalInfo.CivilStatus;
                obj.EstimatedSalary = personalInfo.EstimatedSalary;
                obj.FatherOccupation = personalInfo.FatherOccupation;
                obj.FathersName = personalInfo.FathersName;
                obj.HasRelativesMedicalIllness = personalInfo.HasRelativesMedicalIllness;
                obj.LengthOfResidency = personalInfo.LengthOfResidency;
                obj.MotherOccupation = personalInfo.MotherOccupation;
                obj.MothersName = personalInfo.MothersName;
                obj.Name = personalInfo.Name;
                obj.Position = personalInfo.Position;
                obj.PresentOccupation = personalInfo.PresentOccupation;
                obj.PrimaryCourse = personalInfo.PrimaryCourse;
                obj.PrimaryInclusiveDate = personalInfo.PrimaryInclusiveDate;
                obj.PrimarySchoolName = personalInfo.PrimarySchoolName;
                obj.Religion = personalInfo.Religion;
                obj.SecondaryCourse = personalInfo.SecondaryCourse;
                obj.SecondaryInclusiveDate = personalInfo.SecondaryInclusiveDate;
                obj.SecondarySchoolName = personalInfo.SecondarySchoolName;
                obj.Sex = personalInfo.Sex;
                obj.SisterCount = personalInfo.SisterCount;
                obj.SpouseName = personalInfo.SpouseName;
                obj.SpouseOccupation = personalInfo.SpouseOccupation;
                obj.TertiaryCourse = personalInfo.TertiaryCourse;
                obj.TertiaryInclusiveDate = personalInfo.TertiaryInclusiveDate;
                obj.TertiarySchoolName = personalInfo.TertiarySchoolName;
                obj.VocationalCourse = personalInfo.VocationalCourse;
                obj.VocationalInclusiveDate = personalInfo.VocationalInclusiveDate;
                obj.VocationalSchoolName = personalInfo.VocationalSchoolName;
                obj.WorkingLength = personalInfo.WorkingLength;
                obj.IsResidence = personalInfo.IsResidence;
                obj.IsWorker = personalInfo.IsWorker;
                uow.PersonalInfos.Add(obj);
                uow.Complete();
                personalInfo.PersonalInfoID = obj.PersonalInfoID;
            }
        }

        public void Edit(int id, PersonalInfoDTO personalInfo)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PersonalInfos.Get(id);
                obj.ContactNumber = personalInfo.ContactNumber;
                obj.Address = personalInfo.Address;
                obj.Birthday = personalInfo.Birthday;
                obj.BrotherCount = personalInfo.BrotherCount;
                obj.Citizenship = personalInfo.Citizenship;
                obj.CivilStatus = personalInfo.CivilStatus;
                obj.EstimatedSalary = personalInfo.EstimatedSalary;
                obj.FatherOccupation = personalInfo.FatherOccupation;
                obj.FathersName = personalInfo.FathersName;
                obj.HasRelativesMedicalIllness = personalInfo.HasRelativesMedicalIllness;
                obj.LengthOfResidency = personalInfo.LengthOfResidency;
                obj.MotherOccupation = personalInfo.MotherOccupation;
                obj.MothersName = personalInfo.MothersName;
                obj.Name = personalInfo.Name;
                obj.Position = personalInfo.Position;
                obj.PresentOccupation = personalInfo.PresentOccupation;
                obj.PrimaryCourse = personalInfo.PrimaryCourse;
                obj.PrimaryInclusiveDate = personalInfo.PrimaryInclusiveDate;
                obj.PrimarySchoolName = personalInfo.PrimarySchoolName;
                obj.Religion = personalInfo.Religion;
                obj.SecondaryCourse = personalInfo.SecondaryCourse;
                obj.SecondaryInclusiveDate = personalInfo.SecondaryInclusiveDate;
                obj.SecondarySchoolName = personalInfo.SecondarySchoolName;
                obj.Sex = personalInfo.Sex;
                obj.SisterCount = personalInfo.SisterCount;
                obj.SpouseName = personalInfo.SpouseName;
                obj.SpouseOccupation = personalInfo.SpouseOccupation;
                obj.TertiaryCourse = personalInfo.TertiaryCourse;
                obj.TertiaryInclusiveDate = personalInfo.TertiaryInclusiveDate;
                obj.TertiarySchoolName = personalInfo.TertiarySchoolName;
                obj.VocationalCourse = personalInfo.VocationalCourse;
                obj.VocationalInclusiveDate = personalInfo.VocationalInclusiveDate;
                obj.VocationalSchoolName = personalInfo.VocationalSchoolName;
                obj.WorkingLength = personalInfo.WorkingLength;
                obj.IsResidence = personalInfo.IsResidence;
                obj.IsWorker = personalInfo.IsWorker;
                uow.PersonalInfos.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PersonalInfos.Get(id);
                
                uow.PersonalInfos.Remove(obj);
                uow.Complete();
            }
        }


        public IEnumerable<PersonalInfoListDTO> GetAllBy(string criteria, bool isResidence)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.PersonalInfos.GetAll(criteria, isResidence);
                var dtos = new List<PersonalInfoListDTO>();
                foreach (var item in objs)
                {
                    var dto = new PersonalInfoListDTO();
                    dto.ID = item.PersonalInfoID;
                    dto.FullName = item.Name;
                    dto.Gender = item.Sex;
                    dto.Age = Utils.CalculateAge(item.Birthday);
                    dto.Address = item.Address;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }


        public int GetAge(int personalInfoID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                int age = 0;
                var bday = uow.PersonalInfos.GetBirthday(personalInfoID);
                age = Utils.CalculateAge(bday);
                return age;
            }
        }


        public PersonalInfoBarangayClearanceDTO GetBarangayClearanceInfo(int personalInfoID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
        
                var obj = uow.PersonalInfos.Get(personalInfoID);
                var dto = new PersonalInfoBarangayClearanceDTO();
                dto.Age = Utils.CalculateAge(obj.Birthday);
                dto.FullName = obj.Name;
                return dto;
            }
        }


        public IEnumerable<PersonalInfoListDTO> GetAllBy(string criteria, bool isResidence, bool isWorker)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.PersonalInfos.GetAll(criteria, isResidence, isWorker);
                var dtos = new List<PersonalInfoListDTO>();
                foreach (var item in objs)
                {
                    var dto = new PersonalInfoListDTO();
                    dto.ID = item.PersonalInfoID;
                    dto.FullName = item.Name;
                    dto.Gender = item.Sex;
                    dto.Age = Utils.CalculateAge(item.Birthday);
                    dto.Address = item.Address;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }


        public IEnumerable<PersonalInfoComboListDTO> GetWorkers()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.PersonalInfos.GetWorkers();
                var dtos = new List<PersonalInfoComboListDTO>();
                foreach (var item in objs)
                {
                    var dto = new PersonalInfoComboListDTO();
                    dto.ID = item.PersonalInfoID;
                    dto.FullName = item.Name;
                    
                    dtos.Add(dto);
                }
                return dtos;
            }
        }
    }
}

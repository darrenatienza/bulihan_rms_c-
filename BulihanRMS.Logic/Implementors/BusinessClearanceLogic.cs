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
    public class BusinessClearanceLogic : IBusinessClearanceLogic
    {
        public BusinessClearanceDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BusinessClearances.Get(id);
                var dto = new BusinessClearanceDTO();
                dto.PersonalInfoID = obj.PersonalInfoID;
                dto.Date = obj.CreateTimeStamp;
                dto.KinuhaSa = obj.KinuhaSa;
                dto.NoongIka = obj.NoongIka;
                dto.ORDate = obj.ORDate;
                dto.ORNo = obj.ORNo;
                dto.BusinessName = obj.BusinessName;
                dto.SedulaBlg = obj.SedulaBlg;
                
                return dto;
            }
        }

        public IEnumerable<BusinessClearanceListDTO> GetAllBy(DateTime date, string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.BusinessClearances.GetAllBy(date,criteria);
                var dtos = new List<BusinessClearanceListDTO>();
                foreach (var item in objs)
                {
                    var dto = new BusinessClearanceListDTO();
                    dto.ID = item.BusinessClearanceID;
                    dto.FullName = item.PersonalInfo.Name;
                    dto.Date = item.CreateTimeStamp;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(BusinessClearanceDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new BusinessClearance();
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.BusinessName = dto.BusinessName;
                obj.KinuhaSa = dto.KinuhaSa;
                obj.NoongIka = dto.NoongIka;
                obj.ORDate = dto.ORDate;
                obj.ORNo = dto.ORNo;
                obj.SedulaBlg = dto.SedulaBlg;
                uow.BusinessClearances.Add(obj);
                uow.Complete();
                dto.ID = obj.BusinessClearanceID;
            }
        }

        public void Edit(int id, BusinessClearanceDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BusinessClearances.Get(id);
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.BusinessName = dto.BusinessName;
                obj.KinuhaSa = dto.KinuhaSa;
                obj.NoongIka = dto.NoongIka;
                obj.ORDate = dto.ORDate;
                obj.ORNo = dto.ORNo;
                obj.SedulaBlg = dto.SedulaBlg;
                uow.BusinessClearances.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BusinessClearances.Get(id);
                uow.BusinessClearances.Remove(obj);
                uow.Complete();
            }
        }


        public BusinessClearanceDTOV2 GetV2(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BusinessClearances.GetV2(id);
                var dto = new BusinessClearanceDTOV2();
                dto.FullName = obj.PersonalInfo.Name;
                dto.Age = Utils.CalculateAge(obj.PersonalInfo.Birthday);
                dto.Date = obj.CreateTimeStamp;
                dto.KinuhaSa = obj.KinuhaSa;
                dto.NoongIka = obj.NoongIka;
                dto.ORDate = obj.ORDate;
                dto.ORNo = obj.ORNo;
                dto.SedulaBlg = obj.SedulaBlg;
                return dto;
            }
        }
    }
}

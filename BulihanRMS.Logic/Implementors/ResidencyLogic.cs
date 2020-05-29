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
    public class ResidencyLogic : IResidencyLogic
    {
        public ResidencyDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Residencies.Get(id);
                var dto = new ResidencyDTO();
                dto.PersonalInfoID = obj.PersonalInfoID;
                dto.Date = obj.CreateTimeStamp;
                dto.LengthOfResidency = obj.LengthOfResidency;
                dto.RequestedBy = obj.RequestedBy;
                return dto;
            }
        }
       
        public IEnumerable<ResidencyListDTO> GetAllBy(DateTime date, string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Residencies.GetAllBy(date,criteria);
                var dtos = new List<ResidencyListDTO>();
                foreach (var item in objs)
                {
                    var dto = new ResidencyListDTO();
                    dto.ID = item.ResidencyID;
                    dto.FullName = item.PersonalInfo.Name;
                    dto.Date = item.CreateTimeStamp;
                    dto.RequestedBy = item.RequestedBy;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(ResidencyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new Residency();
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.LengthOfResidency = dto.LengthOfResidency;
                obj.RequestedBy = dto.RequestedBy;
                uow.Residencies.Add(obj);
                uow.Complete();
                dto.ID = obj.ResidencyID;
            }
        }

        public void Edit(int id, ResidencyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Residencies.Get(id);
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.LengthOfResidency = dto.LengthOfResidency;
                obj.RequestedBy = dto.RequestedBy;
                uow.Residencies.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Residencies.Get(id);
                uow.Residencies.Remove(obj);
                uow.Complete();
            }
        }


        public ResidencyDTOV2 GetV2(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Residencies.GetV2(id);
                var dto = new ResidencyDTOV2();
                dto.FullName = obj.PersonalInfo.Name;
                dto.Date = obj.CreateTimeStamp;
                dto.RequestedBy = obj.RequestedBy;
                dto.LengthOfResidency = obj.LengthOfResidency;
                return dto;
            }
        }
    }
}

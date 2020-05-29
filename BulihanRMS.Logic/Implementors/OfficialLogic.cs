using BulihanRMS.Logic.Contracts;
using BulihanRMS.Logic.Exceptions;
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
    public class OfficialLogic : IOfficialLogic
    {
        public OfficialDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Officials.Get(id);
                var dto = new OfficialDTO();
                dto.OfficialGroupID = obj.OfficialGroupID;
                dto.OfficialPositionID = obj.OfficialPositionID;
                dto.PersonalInfoID = obj.PersonalInfoID;
                return dto;
            }
        }
       
        public IEnumerable<OfficialListDTO> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Officials.GetAllBy(criteria);
                var dtos = new List<OfficialListDTO>();
                foreach (var item in objs)
                {
                    var dto = new OfficialListDTO();
                    dto.ID = item.OfficialID;
                    dto.FullName = item.PersonalInfo.Name;
                    dto.OfficialGroupDescription = item.OfficialGroup.Description;
                    dto.OfficialPositionDescription = item.OfficialPosition.Description;
                    dto.ContactNumber = item.PersonalInfo.ContactNumber;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(OfficialDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new Official();

                obj.OfficialGroupID = dto.OfficialGroupID;
                obj.OfficialPositionID = dto.OfficialPositionID;
                obj.PersonalInfoID = dto.PersonalInfoID;
                uow.Officials.Add(obj);
                uow.Complete();
                dto.ID = obj.OfficialID;
            }
        }

        public void Edit(int id, OfficialDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Officials.Get(id);
                obj.OfficialGroupID = dto.OfficialGroupID;
                obj.OfficialPositionID = dto.OfficialPositionID;
                obj.PersonalInfoID = dto.PersonalInfoID;
                uow.Officials.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Officials.Get(id);
                uow.Officials.Remove(obj);
                uow.Complete();
            }
        }


        public string GetFullNameByOfficialPosition(string officialPosition)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Officials.GetByOfficialPosition(officialPosition);
                if (obj == null)
                {
                    return "";
                }
                else
                {
                    return obj.PersonalInfo.Name;
                }
                
            }
        }


        public OfficialDetailDTO GetByOfficialPosition(string officialPosition)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Officials.GetByOfficialPosition(officialPosition);
                var dto = new OfficialDetailDTO();
                if (obj != null)
                {
                    dto.ContactNumber = obj.PersonalInfo.ContactNumber;
                    dto.FullName = obj.PersonalInfo.Name;
                }
                else
                {
                    throw new RecordNotFoundException(officialPosition);
                }
                return dto;

            }
        }
    }
}

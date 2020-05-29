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
    public class IndigencyLogic : IIndigencyLogic
    {
        public IndigencyDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Indigencies.Get(id);
                var dto = new IndigencyDTO();
                dto.PersonalInfoID = obj.PersonalInfoID;
                dto.Date = obj.CreateTimeStamp;
                dto.Purpose = obj.Purpose;
                return dto;
            }
        }
       
        public IEnumerable<IndigencyListDTO> GetAllBy(DateTime date, string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Indigencies.GetAllBy(date,criteria);
                var dtos = new List<IndigencyListDTO>();
                foreach (var item in objs)
                {
                    var dto = new IndigencyListDTO();
                    dto.ID = item.IndigencyID;
                    dto.FullName = item.PersonalInfo.Name;
                    dto.Date = item.CreateTimeStamp;
                    dto.Purpose = item.Purpose;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(IndigencyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new Indigency();
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.Purpose = dto.Purpose;
                uow.Indigencies.Add(obj);
                uow.Complete();
                dto.ID = obj.IndigencyID;
            }
        }

        public void Edit(int id, IndigencyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new Indigency();
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.Purpose = dto.Purpose;
                uow.Indigencies.Add(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Indigencies.Get(id);
                uow.Indigencies.Remove(obj);
                uow.Complete();
            }
        }


        public IndigencyDTOV2 GetV2(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Indigencies.GetV2(id);
                var dto = new IndigencyDTOV2();
                dto.FullName = obj.PersonalInfo.Name;
                dto.Date = obj.CreateTimeStamp;
                dto.Purpose = obj.Purpose;
                return dto;
            }
        }
    }
}

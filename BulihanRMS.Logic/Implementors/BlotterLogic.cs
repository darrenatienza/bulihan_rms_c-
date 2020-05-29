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
    public class BlotterLogic : IBlotterLogic
    {
        public BlotterDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Blotters.Get(id);
                var dto = new BlotterDTO();
                dto.PersonalInfoID = obj.PersonalInfoID;
                dto.Date = obj.CreateTimeStamp;
                dto.What = obj.What;
                dto.When = obj.When;
                dto.Where = obj.Where;
                return dto;
            }
        }
       
        public IEnumerable<BlotterListDTO> GetAllBy(DateTime date, string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Blotters.GetAllBy(date,criteria);
                var dtos = new List<BlotterListDTO>();
                foreach (var item in objs)
                {
                    var dto = new BlotterListDTO();
                    dto.ID = item.BlotterID;
                    dto.FullName = item.PersonalInfo.Name;
                    dto.Date = item.CreateTimeStamp;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(BlotterDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new Blotter();
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.What = dto.What;
                obj.Where = dto.Where;
                obj.When = dto.When;
                uow.Blotters.Add(obj);
                uow.Complete();
                dto.ID = obj.BlotterID;
            }
        }

        public void Edit(int id, BlotterDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Blotters.Get(id);
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.What = dto.What;
                obj.Where = dto.Where;
                obj.When = dto.When;
                uow.Blotters.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Blotters.Get(id);
                
                uow.Blotters.Remove(obj);
                uow.Complete();
            }
        }


        public BlotterDTOV2 GetV2(int blotterID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Blotters.GetV2(blotterID);
                var dto = new BlotterDTOV2();
                dto.FullName = obj.PersonalInfo.Name;
                dto.Date = obj.CreateTimeStamp;
                dto.What = obj.What;
                dto.When = obj.When;
                dto.Where = obj.Where;
                return dto;
            }
        }
    }
}

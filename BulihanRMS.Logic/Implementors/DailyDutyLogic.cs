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
    public class DailyDutyLogic : IDailyDutyLogic
    {
        public DailyDutyDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.DailyDuties.Get(id);
                var dto = new DailyDutyDTO();
                dto.Date = obj.Date;
                dto.PersonalInfoID = obj.PersonalInfoID;
                dto.In = obj.In;
                dto.Out = obj.Out;
                return dto;
            }
        }
       
        public IEnumerable<DailyDutyListDTO> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.DailyDuties.GetAllBy(criteria);
                var dtos = new List<DailyDutyListDTO>();
                foreach (var item in objs)
                {
                    var dto = new DailyDutyListDTO();
                    dto.ID = item.DailyDutyID;
                    dto.Date = item.Date;
                    dto.In = item.In;
                    dto.Out = item.Out;
                    dto.FullName = item.PersonalInfo.Name;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }
        public IEnumerable<DailyDutyListDTO> GetAllBy(DateTime date, string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.DailyDuties.GetAllBy(date, criteria);
                var dtos = new List<DailyDutyListDTO>();
                foreach (var item in objs)
                {
                    var dto = new DailyDutyListDTO();
                    dto.ID = item.DailyDutyID;
                    dto.Date = item.Date;
                    dto.In = item.In;
                    dto.Out = item.Out;
                    dto.FullName = item.PersonalInfo.Name;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(DailyDutyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new DailyDuty();
                obj.Date = dto.Date;
                obj.In = dto.In;
                obj.Out = dto.Out;
                obj.PersonalInfoID = dto.PersonalInfoID;
                uow.DailyDuties.Add(obj);
                uow.Complete();
                dto.ID = obj.DailyDutyID;
            }
        }

        public void Edit(int id, DailyDutyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.DailyDuties.Get(id);
                obj.In = dto.In;
                obj.Out = dto.Out;
                uow.DailyDuties.Edit(obj);
                uow.Complete();
             
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.DailyDuties.Get(id);

                uow.DailyDuties.Remove(obj);
                uow.Complete();
            }
        }
    }
}

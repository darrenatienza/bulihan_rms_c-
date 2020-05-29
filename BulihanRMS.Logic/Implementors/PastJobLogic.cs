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
    public class PastJobLogic : IPastJobLogic
    {
        public PastJobDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PastJobs.Get(id);
                var dto = new PastJobDTO();
                dto.Description = obj.Description;
                dto.InclusiveDate = obj.InclusiveDate;
                dto.Salary = obj.Salary;
                dto.ReasonOfLeaving = obj.ReasonOfLeaving;
                return dto;
            }
        }
       
        public IEnumerable<PastJobListDTO> GetAllBy(int personalInfoID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.PastJobs.GetAllBy(personalInfoID);
                var dtos = new List<PastJobListDTO>();
                foreach (var item in objs)
                {
                    var dto = new PastJobListDTO();
                    dto.ID = item.PastJobID;
                    dto.Description = item.Description;
                    dto.InclusiveDate = item.InclusiveDate;
                    dto.ReasonOfLeaving = item.ReasonOfLeaving;
                    dto.Salary = item.Salary;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(PastJobDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new PastJob();
                obj.Description = dto.Description;
                obj.InclusiveDate = dto.InclusiveDate;
                obj.ReasonOfLeaving = dto.ReasonOfLeaving;
                obj.Salary = dto.Salary;
                obj.PersonalInfoID = dto.PersonalInfoID;
                uow.PastJobs.Add(obj);
                uow.Complete();
                dto.ID = obj.PastJobID;
            }
        }

        public void Edit(int id, PastJobDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PastJobs.Get(id);
                obj.Description = dto.Description;
                obj.InclusiveDate = dto.InclusiveDate;
                obj.ReasonOfLeaving = dto.ReasonOfLeaving;
                obj.Salary = dto.Salary;
                uow.PastJobs.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PastJobs.Get(id);              
                uow.PastJobs.Remove(obj);
                uow.Complete();
            }
        }
    }
}

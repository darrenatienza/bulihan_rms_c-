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
    public class FamilyMedicalHistoryLogic : IFamilyMedicalHistoryLogic
    {
        public FamilyMedicalHistoryDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.FamilyMedicalHistories.Get(id);
                var dto = new FamilyMedicalHistoryDTO();
                dto.Illness = obj.Illness;
                dto.Name = obj.Name;
                return dto;
            }
        }
       
        public IEnumerable<FamilyMedicalHistoryListDTO> GetAllBy(int personalInfoID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.FamilyMedicalHistories.GetAllBy(personalInfoID);
                var dtos = new List<FamilyMedicalHistoryListDTO>();
                foreach (var item in objs)
                {
                    var dto = new FamilyMedicalHistoryListDTO();
                    dto.ID = item.FamilyMedicalHistoryID;
                    dto.Name = item.Name;
                    dto.Illness = item.Illness;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(FamilyMedicalHistoryDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {   
                var obj = new FamilyMedicalHistory();
                obj.Name = dto.Name;
                obj.Illness = dto.Illness;
                obj.PersonalInfoID = dto.PersonalInfoID;
                uow.FamilyMedicalHistories.Add(obj);
                uow.Complete();
                dto.ID = obj.FamilyMedicalHistoryID;
            }
        }

        public void Edit(int id, FamilyMedicalHistoryDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.FamilyMedicalHistories.Get(id);
                obj.Name = dto.Name;
                obj.Illness = dto.Illness;
                uow.FamilyMedicalHistories.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.FamilyMedicalHistories.Get(id);
                
                uow.FamilyMedicalHistories.Remove(obj);
                uow.Complete();
            }
        }
    }
}

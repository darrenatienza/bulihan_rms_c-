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
    public class BizRecordLogic : IBizRecordLogic
    {

        public BizRecordDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BizRecords.GetBy(id);
                var dto = new BizRecordDTO();
                dto.BizAddress = obj.Address;
                dto.BizName = obj.BusinessName;
                dto.BizContactNumber = obj.ContactNumber;
                dto.ID = obj.BizRecordID;
                dto.ImageName = obj.ImageName;
                dto.OwnerID = obj.PersonalInfoID;
                dto.OwnerName = obj.PersonalInfo.Name;
                foreach (var item in obj.BizWorker)
                {
                    
                    dto.BizWorkers.Add(new BizWorkerDTO
                    {
                        Address = dto.BizAddress,
                        ContactNumber = item.PersonalInfo.ContactNumber,
                        FullName = item.PersonalInfo.Name,
                        ID = item.BizWorkerID,
                        PermanentAddress = item.PersonalInfo.Address
                    });
                }
                
               
                return dto;
            }
        }

        public void Add(BizRecordDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new BizRecord();
                obj.Address = dto.BizAddress;
                obj.BusinessName = dto.BizName;
                obj.ContactNumber = dto.BizContactNumber;
                obj.ImageName = dto.ImageName;
                obj.PersonalInfoID = dto.OwnerID;
                
                uow.BizRecords.Add(obj);
                uow.Complete();
                dto.ID = obj.BizRecordID;
            }
        }

        public void Edit(int id, BizRecordDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BizRecords.Get(id);
                obj.Address = dto.BizAddress;
                obj.BusinessName = dto.BizName;
                obj.ContactNumber = dto.BizContactNumber;
                obj.ImageName = dto.ImageName;
                obj.PersonalInfoID = dto.OwnerID;
                
                uow.BizRecords.Edit(obj);
                uow.Complete();

            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BizRecords.Get(id);
               
                uow.BizRecords.Remove(obj);
                uow.Complete();

            }
        }

        public List<BizRecordDTO> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.BizRecords.GetAllBy(criteria);
                var dtos = new List<BizRecordDTO>();
                foreach (var item in objs)
                {
                    var dto = new BizRecordDTO();
                    dto.ID = item.BizRecordID;
                    dto.OwnerName = item.PersonalInfo.Name;
                    dto.BizContactNumber = item.ContactNumber;
                    dto.BizAddress = item.Address;
                    dto.BizName = item.BusinessName;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }




        public void AddWorker(int bizRecordID, int workerID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
            
                var obj = new BizWorker();
                obj.BizRecordID =bizRecordID;
                obj.PersonalInfoID = workerID;
               
                uow.BizWorkers.Add(obj);
                uow.Complete();
                
            
            }
        }


        public void RemoveBizWorker(int bizWorkerID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {

                var obj = uow.BizWorkers.Get(bizWorkerID);
                uow.BizWorkers.Remove(obj);
                uow.Complete();


            }
        }
    }
}

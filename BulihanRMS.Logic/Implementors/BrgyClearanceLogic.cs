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
    public class BrgyClearanceLogic : IBrgyClearanceLogic
    {
        public BrgyClearanceDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BarangayClearances.Get(id);
                var dto = new BrgyClearanceDTO();
                dto.PersonalInfoID = obj.PersonalInfoID;
                dto.Date = obj.CreateTimeStamp;
                dto.KinuhaSa = obj.KinuhaSa;
                dto.NoongIka = obj.NoongIka;
                dto.ORDate = obj.ORDate;
                dto.ORNo = obj.ORNo;
                dto.Purok = obj.Purok;
                dto.SedulaBlg = obj.SedulaBlg;
                dto.Sitio = obj.Sitio;
                
                return dto;
            }
        }

        public IEnumerable<BrgyClearanceListDTO> GetAllBy(DateTime date, string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.BarangayClearances.GetAllBy(date,criteria);
                var dtos = new List<BrgyClearanceListDTO>();
                foreach (var item in objs)
                {
                    var dto = new BrgyClearanceListDTO();
                    dto.ID = item.BarangayClearanceID;
                    dto.FullName = item.PersonalInfo.Name;
                    dto.Date = item.CreateTimeStamp;
                    dto.Age = Utils.CalculateAge(item.PersonalInfo.Birthday).ToString();
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(BrgyClearanceDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new BarangayClearance();
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.CreateTimeStamp = DateTime.Now;
                obj.KinuhaSa = dto.KinuhaSa;
                obj.NoongIka = dto.NoongIka;
                obj.ORDate = dto.ORDate;
                obj.ORNo = dto.ORNo;
                obj.SedulaBlg = dto.SedulaBlg;
                obj.Sitio = dto.Sitio;
                obj.Purok = dto.Purok;
                uow.BarangayClearances.Add(obj);
                uow.Complete();
                dto.ID = obj.BarangayClearanceID;
            }
        }

        public void Edit(int id, BrgyClearanceDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BarangayClearances.Get(id);
                obj.PersonalInfoID = dto.PersonalInfoID;
                obj.KinuhaSa = dto.KinuhaSa;
                obj.NoongIka = dto.NoongIka;
                obj.ORDate = dto.ORDate;
                obj.ORNo = dto.ORNo;
                obj.SedulaBlg = dto.SedulaBlg;
                obj.Sitio = dto.Sitio;
                obj.Purok = dto.Purok;
                uow.BarangayClearances.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BarangayClearances.Get(id);
                uow.BarangayClearances.Remove(obj);
                uow.Complete();
            }
        }

        /// <summary>
        /// Get Barangay Clearance with full personal information.
        /// </summary>
        /// <param name="id">Id of Barangay Clearance</param>
        /// <returns></returns>
        public BarangayClearanceDTOV2 GetV2(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.BarangayClearances.GetV2(id);
                var dto = new BarangayClearanceDTOV2();
                dto.FullName = obj.PersonalInfo.Name;
                dto.Age = Utils.CalculateAge(obj.PersonalInfo.Birthday);
                dto.Date = obj.CreateTimeStamp;
                dto.KinuhaSa = obj.KinuhaSa;
                dto.NoongIka = obj.NoongIka;
                dto.ORDate = obj.ORDate;
                dto.ORNo = obj.ORNo;
                dto.Purok = obj.Purok;
                dto.SedulaBlg = obj.SedulaBlg;
                dto.Sitio = obj.Sitio;
                return dto;
            }
        }
    }
}

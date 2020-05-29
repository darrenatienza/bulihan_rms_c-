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
    public class PropertyLogic : IPropertyLogic
    {
        public PropertyDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Properties.Get(id);
                var dto = new PropertyDTO();
                dto.Description = obj.Description;
                dto.PropertyTypeID = obj.PropertyTypeID;
                dto.Quantiy = obj.Quantiy;
                dto.Remarks = obj.Remarks;
                return dto;
            }
        }
       
        public IEnumerable<PropertyListDTO> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Properties.GetAllBy(criteria);
                var dtos = new List<PropertyListDTO>();
                foreach (var item in objs)
                {
                    var dto = new PropertyListDTO();
                    dto.ID = item.PropertyID;
                    dto.Description = item.Description;
                    dto.PropertyTypeDescription = item.PropertyType.Description;
                    dto.Quantity = item.Quantiy;
                    dto.Remarks = item.Remarks;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }


        public void Add(PropertyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new Property();
                obj.Description = dto.Description;
                obj.PropertyTypeID = dto.PropertyTypeID;
                obj.Quantiy = dto.Quantiy;
                obj.Remarks = dto.Remarks;
                uow.Properties.Add(obj);
                uow.Complete();
                dto.ID = obj.PropertyID;
            }
        }

        public void Edit(int id, PropertyDTO dto)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Properties.Get(id);
                obj.Description = dto.Description;
                obj.PropertyTypeID = dto.PropertyTypeID;
                obj.Quantiy = dto.Quantiy;
                obj.Remarks = dto.Remarks;
                uow.Properties.Edit(obj);
                uow.Complete();

             
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Properties.Get(id);

                uow.Properties.Remove(obj);
                uow.Complete();
            }
        }
    }
}

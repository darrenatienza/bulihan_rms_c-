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
    public class PropertyTypeLogic : IPropertyTypeLogic
    {
        public PropertyTypeDTO Get(int id)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = uow.Properties.Get(id);
            //    var dto = new PropertyDTO();
            //    dto.Description = obj.Description;
            //    dto.PropertyTypeID = obj.PropertyTypeID;
            //    dto.Quantiy = obj.Quantiy;
            //    dto.Remarks = obj.Remarks;
            //    return dto;
            //}
            throw new NotImplementedException();
        }

        public IEnumerable<PropertyTypeListDTO> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.PropertyTypes.GetAll();
                var dtos = new List<PropertyTypeListDTO>();
                foreach (var item in objs)
                {
                    var dto = new PropertyTypeListDTO();
                    dto.ID = item.PropertyTypeID;
                    dto.Description = item.Description;

                    dtos.Add(dto);
                }
                return dtos;
            }
            
        }


        public void Add(PropertyTypeDTO dto)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = new Property();
            //    obj.Description = dto.Description;
            //    obj.PropertyTypeID = dto.PropertyTypeID;
            //    obj.Quantiy = dto.Quantiy;
            //    obj.Remarks = dto.Remarks;
            //    uow.Properties.Add(obj);
            //    uow.Complete();
            //    dto.ID = obj.PropertyID;
            //}
            throw new NotImplementedException();
        }

        public void Edit(int id, PropertyTypeDTO dto)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = uow.Properties.Get(id);
            //    obj.Description = dto.Description;
            //    obj.PropertyTypeID = dto.PropertyTypeID;
            //    obj.Quantiy = dto.Quantiy;
            //    obj.Remarks = dto.Remarks;
            //    uow.Properties.Edit(obj);
            //    uow.Complete();

             
            //}
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = uow.Properties.Get(id);

            //    uow.Properties.Remove(obj);
            //    uow.Complete();
            //}
            throw new NotImplementedException();
        }
    }
}

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
    public class OfficialGroupLogic : IOfficialGroupLogic
    {
        public OfficialGroupDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.OfficialGroups.Get(id);
                var dto = new OfficialGroupDTO();
                dto.Description = obj.Description;
                return dto;
            }
        }
       
        public IEnumerable<OfficialGroupListDTO> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.OfficialGroups.GetAllBy(criteria);
                var dtos = new List<OfficialGroupListDTO>();
                foreach (var item in objs)
                {
                    var dto = new OfficialGroupListDTO();
                    dto.ID = item.OfficialGroupID;
                    dto.Description = item.Description;
                   
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(OfficialGroupDTO children)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = new Children();
            //    obj.Name = children.FullName;
            //    obj.Age = children.Age;
            //    obj.Occupation = children.Occupation;
            //    obj.PersonalInfoID = children.PersonalInfoID;
            //    uow.Childrens.Add(obj);
            //    uow.Complete();
            //    children.ID = obj.ChildrenID;
            //}
            throw new NotImplementedException();
        }

        public void Edit(int id, OfficialGroupDTO children)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = uow.Childrens.Get(id);
            //    obj.Name = children.FullName;
            //    obj.Age = children.Age;
            //    obj.Occupation = children.Occupation;
            //    uow.Childrens.Edit(obj);
            //    uow.Complete();
            //}
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = uow.Childrens.Get(id);
                
            //    uow.Childrens.Remove(obj);
            //    uow.Complete();
            //}
            throw new NotImplementedException();
        }
    }
}

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
    public class OfficialPositionLogic : IOfficialPositionLogic
    {
        public OfficialPositionDTO Get(int id)
        {
            //using (var uow = new UnitOfWork(new DataContext()))
            //{
            //    var obj = uow.Childrens.Get(id);
            //    var children = new ChildrenDTO();
            //    children.Age = obj.Age;
            //    children.FullName = obj.Name;
            //    children.Occupation = obj.Occupation;
            //    return children;
            //}
            throw new NotImplementedException();
        }
       
        public IEnumerable<OfficialPositionListDTO> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.OfficialPositions.GetAllBy(criteria);
                var dtos = new List<OfficialPositionListDTO>();
                foreach (var item in objs)
                {
                    var dto = new OfficialPositionListDTO();
                    dto.ID = item.OfficialPositionID;
                    dto.Description = item.Description;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(OfficialPositionDTO children)
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

        public void Edit(int id, OfficialPositionDTO children)
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

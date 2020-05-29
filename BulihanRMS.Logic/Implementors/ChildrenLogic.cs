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
    public class ChildrenLogic : IChildrenLogic
    {
        public ChildrenDTO Get(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Childrens.Get(id);
                var children = new ChildrenDTO();
                children.Age = obj.Age;
                children.FullName = obj.Name;
                children.Occupation = obj.Occupation;
                return children;
            }
        }
       
        public IEnumerable<ChildrenListDTO> GetAllBy(int personalInfoID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Childrens.GetAllBy(personalInfoID);
                var dtos = new List<ChildrenListDTO>();
                foreach (var item in objs)
                {
                    var dto = new ChildrenListDTO();
                    dto.ID = item.ChildrenID;
                    dto.FullName = item.Name;
                    dto.Age = item.Age;
                    dto.Occupation = item.Occupation;
                    dtos.Add(dto);
                }
                return dtos;
            }
        }

        public void Add(ChildrenDTO children)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = new Children();
                obj.Name = children.FullName;
                obj.Age = children.Age;
                obj.Occupation = children.Occupation;
                obj.PersonalInfoID = children.PersonalInfoID;
                uow.Childrens.Add(obj);
                uow.Complete();
                children.ID = obj.ChildrenID;
            }
        }

        public void Edit(int id, ChildrenDTO children)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Childrens.Get(id);
                obj.Name = children.FullName;
                obj.Age = children.Age;
                obj.Occupation = children.Occupation;
                uow.Childrens.Edit(obj);
                uow.Complete();
            }
        }

        public void Remove(int id)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Childrens.Get(id);
                
                uow.Childrens.Remove(obj);
                uow.Complete();
            }
        }
    }
}

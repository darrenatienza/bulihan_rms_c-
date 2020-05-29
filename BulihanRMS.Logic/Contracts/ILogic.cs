using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface ILogic <TEntity> where TEntity : class
    {
        TEntity Get(int id);
        void Add(TEntity entity);
        void Edit(int id, TEntity entity);
        void Remove(int id);
    }
}

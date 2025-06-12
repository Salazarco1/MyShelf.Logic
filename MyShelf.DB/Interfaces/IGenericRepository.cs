using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.DB.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class 
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepositoryDal<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        List<T> GetById(int id);
    }
}

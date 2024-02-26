using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category category);
        List<Category> GetAll();
        List<Category> GetById(int categoryId);
    }
}

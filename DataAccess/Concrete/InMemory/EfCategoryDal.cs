using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class EfCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public EfCategoryDal()
        {
            _categories = new List<Category>() {
             new Category { CategoryId = 1, CategoryName = "Programlama"},
             new Category { CategoryId = 2, CategoryName = "SQL"},
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            Category categoryDelete = _categories.SingleOrDefault(cat => cat.CategoryId == id);
            _categories.Remove(categoryDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public List<Category> GetById(int id)
        {
            return _categories.Where(cat => cat.CategoryId == id).ToList();
        }

        public void Update(Category category)
        {
            Category categoryUpdate = _categories.SingleOrDefault(cat => cat.CategoryId == category.CategoryId);
            categoryUpdate.CategoryName = category.CategoryName;
        }
    }
}

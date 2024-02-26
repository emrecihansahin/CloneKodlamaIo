using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categories;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categories = categoryDal;
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int categoryId)
        {
            _categories.Delete(categoryId);
        }

        public List<Category> GetAll()
        {
            return _categories.GetAll();
        }

        public List<Category> GetById(int categoryId)
        {
            return _categories.GetById(categoryId);
        }

        public void Update(Category category)
        {
            _categories.Update(category);
        }
    }
}

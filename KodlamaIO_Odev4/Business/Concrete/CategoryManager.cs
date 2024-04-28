using KodlamaIO_Odev4.Business.Abstracts;
using KodlamaIO_Odev4.DataAccess.Abstracts;
using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Remove(Category category)
        {
            _categoryDal.Remove(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

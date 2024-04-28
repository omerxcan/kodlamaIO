using KodlamaIO_Odev4.DataAccess.Abstracts;
using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories = new List<Category>();
        public CategoryDal()
        {
            _categories.Add(new Category() {CategoryId=1,CategoryName="Programlama" });
        }
        public List<Category> GetAll() 
        {
            return _categories;
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }
        public void Remove(Category category)
        {
            _categories.Remove(category);
        }
        public void Update(Category category)
        {
            var existingCourse = _categories.FirstOrDefault(c=>c.CategoryId == category.CategoryId);
            if (existingCourse != null)
            {
                existingCourse.CategoryId = category.CategoryId;
                existingCourse.CategoryName = category.CategoryName;
            }
            else
            {
                throw new Exception("Güncellenecek kurs bulunamadı");
            }
        }
    }
}

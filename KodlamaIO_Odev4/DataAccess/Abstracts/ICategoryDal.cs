using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);

    }
}

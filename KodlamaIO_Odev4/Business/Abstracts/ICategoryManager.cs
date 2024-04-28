using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.Business.Abstracts
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Remove(Category category);
        List<Category> GetAll();
        void Update(Category category);
    }
}

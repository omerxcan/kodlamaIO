using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
        void Remove(Course course);
        void Update(Course course);
    }
}

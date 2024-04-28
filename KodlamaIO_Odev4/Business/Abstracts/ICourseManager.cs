using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.Business.Abstracts
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Remove(Course course);
        List<Course> GetAll();
        void Update(Course course);
    }
}

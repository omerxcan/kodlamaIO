using KodlamaIO_Odev4.Business.Abstracts;
using KodlamaIO_Odev4.DataAccess.Abstracts;
using KodlamaIO_Odev4.DataAccess.Concretes;
using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.Business.Concrete
{
    public class CourseManager : ICourseManager
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Remove(Course course)
        {
            _courseDal.Remove(course);
        }
        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
    }
}

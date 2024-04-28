using KodlamaIO_Odev4.DataAccess.Abstracts;
using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı(C#)";
            course1.Price = "Ücretsiz";
            course1.CategoryId = 1;
            course1.InstructorId = 1;

            Course  course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course2.Price = "Ücretsiz";
            course2.CategoryId = 1;
            course2.InstructorId = 1;

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
            course3.Price = "Ücretsiz";
            course3.CategoryId = 1;
            course3.InstructorId = 1;

            Course course4 = new Course();
            course4.CourseId = 4;
            course4.CourseName = "Yazılım Geliştirici Yetiştirme Kampı(JavaScript)";
            course4.Price = "Ücretsiz";
            course4.CategoryId = 1;
            course4.InstructorId = 1;

            Course course5 = new Course();
            course5.CourseId = 5;
            course5.CourseName = "Senior Yazılım Geliştirici Yetişrime Kampı (.NET)";
            course5.Price = "Ücretsiz";
            course5.CategoryId = 1;
            course5.InstructorId = 1;

            Course course6 = new Course();
            course6.CourseId = 6;
            course6.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course6.Price = "Ücretsiz";
            course6.CategoryId = 1;
            course6.InstructorId = 1;

            Course course7 = new Course();
            course7.CourseId = 7;
            course7.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course7.Price = "Ücretsiz";
            course7.CategoryId = 2;
            course7.InstructorId = 1;

            Course course8 = new Course();
            course8.CourseId = 8;
            course8.CourseName = "Programlamaya Giriş İçin Temel Kurs";
            course8.Price = "Ücretsiz";
            course8.CategoryId = 1;
            course8.InstructorId = 1;

            _courses = new List<Course>() {course1,course2,course3,course4,course5,course6,course7,course8};
        }
        public List<Course> GetAll()
        {
            return _courses;
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }
        public void Remove(Course course)
        {
            _courses.Remove(course);
        }
        public void Update(Course course)
        {
            var existingCourse = _courses.FirstOrDefault(c => c.CourseId == course.CourseId);
            if (existingCourse != null)
            {
                existingCourse.CourseName = course.CourseName;
                existingCourse.CourseId = course.CourseId;
                existingCourse.CategoryId = course.CategoryId;
                existingCourse.InstructorId = course.InstructorId;
            }
            else
            {
                throw new InvalidOperationException("Güncellenecek kurs bulunamadı");
            }
        }
    }
}

using KodlamaIO_Odev4.DataAccess.Abstracts;
using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor()
            {
                InstructorId = 1,
                InstructorName = "Engin",
                InstructorSurname = " Demirog"

            };
            Instructor instructor2 = new Instructor()
            {
                InstructorId = 2,
                InstructorName = "Halit Enes",
                InstructorSurname = "Kalaycı"
            };
            _instructors = new List<Instructor>() { instructor1, instructor2 };

        }
        public List<Instructor> GetAll()
        {
            return _instructors;
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Remove(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public void Update(Instructor instructor)
        {
            var existingCourse = _instructors.FirstOrDefault(i => i.InstructorId == instructor.InstructorId);
            if (existingCourse != null)
            {
                existingCourse.InstructorId = instructor.InstructorId;
                existingCourse.InstructorName = instructor.InstructorName;
                existingCourse.InstructorSurname = instructor.InstructorSurname;
            }
            else
            {
                throw new InvalidOperationException("Güncellenecek kurs bulunamadı.");
            }
        }
    }
}

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
    public class InstructorManager : IInstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Remove(Instructor instructor)
        {
            _instructorDal.Remove(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}


using KodlamaIO_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_Odev4.Business.Abstracts
{
    public interface IInstructorManager
    {
        void Add(Instructor instructor);
        void Remove(Instructor instructor);
        List<Instructor> GetAll();
        void Update(Instructor instructor);
    }
}

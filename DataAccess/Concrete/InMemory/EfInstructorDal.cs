using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class EfInstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public EfInstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{InstructorId = 1, InstructorName = "Engin Demiroğ"},
            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int id)
        {
            Instructor instructorDelete = _instructors.SingleOrDefault(ins => ins.InstructorId == id);
            _instructors.Remove(instructorDelete);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public List<Instructor> GetById(int id)
        {
            return _instructors.Where(ins => ins.InstructorId == id).ToList();
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorUpdate = _instructors.SingleOrDefault(ins => ins.InstructorId == instructor.InstructorId);
            instructorUpdate.InstructorId = instructor.InstructorId;
            instructorUpdate.InstructorName = instructor.InstructorName;    
        }
    }
}

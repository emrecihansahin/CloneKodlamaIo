using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructors;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructors = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            _instructors.Delete(instructorId);
        }

        public List<Instructor> GetAll()
        {
            return _instructors.GetAll();
        }

        public List<Instructor> GetById(int instructorId)
        {
            return _instructors.GetById(instructorId);
        }

        public void Update(Instructor instructor)
        {
            _instructors.Update(instructor);
        }
    }
}

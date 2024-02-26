using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courses;

        public CourseManager(ICourseDal courseDal)
        {
            _courses = courseDal;
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int courseId)
        {
            _courses.Delete(courseId);
        }

        public List<Course> GetAll()
        {
            return _courses.GetAll();
        }

        public List<Course> GetById(int courseId)
        {
            return _courses.GetById(courseId);
        }

        public void Update(Course course)
        {
            _courses.Update(course);
        }
    }
}

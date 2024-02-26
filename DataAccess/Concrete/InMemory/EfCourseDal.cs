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
    public class EfCourseDal : ICourseDal
    {
        List<Course> _courses;
        public EfCourseDal()
        {
            _courses = new List<Course>()
            {
                new Course {CategoryId = 1, CourseId = 1, CourseName = ".Net Programming", CourseDescription = "It is a .Net programming course with c#", InstructorId = 1},
                new Course {CategoryId = 1, CourseId = 2, CourseName = "Java Programming", CourseDescription = "Java Programming with Intellij IDE", InstructorId = 1},
                new Course { CategoryId = 2, CourseId = 3, CourseName = "Postgre SQL Course", CourseDescription = "SQL basics and methods.", InstructorId= 1},
            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int id)
        {
            Course courseDelete = _courses.SingleOrDefault(cou => cou.CourseId == id);
            _courses.Remove(courseDelete);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<Course> GetById(int id)
        {
            return _courses.Where(cou => cou.CourseId == id).ToList();
        }

        public void Update(Course course)
        {
            Course courseUpdate = _courses.SingleOrDefault(cou => cou.CourseId == course.CourseId);
            courseUpdate.CourseId = course.CourseId;
            courseUpdate.CourseName = course.CourseName;
            courseUpdate.CourseDescription = course.CourseDescription;
            courseUpdate.CategoryId = course.CategoryId;
            courseUpdate.InstructorId = course.InstructorId;
        }
    }
}

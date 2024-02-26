using Business.Concrete;
using DataAccess.Concrete.InMemory;

CourseManager courseManager = new CourseManager(new EfCourseDal());

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.CourseName + " ---- " + course.CourseDescription);
}
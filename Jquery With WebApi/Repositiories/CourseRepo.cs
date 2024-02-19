using Jquery_With_WebApi.Models;

namespace Jquery_With_WebApi.Repositiories
{
    public class CourseRepo : ICourse

    {
        CompanyContext cc;
        public CourseRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Course rec)
        {
           this.cc.Courses.Add(rec);
            this.cc.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return this.cc.Courses.ToList();
        }
    }
}

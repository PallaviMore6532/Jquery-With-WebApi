using Microsoft.EntityFrameworkCore;

namespace Jquery_With_WebApi.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Course>().HasData(
                new Course() { CourseID=1, CourseName="C Programming", SubjectName="Programming", CourseFees=5000, DiscountAmount=1000, FinalAmount=4000 },
                 new Course() { CourseID=2, CourseName="Sql/Pl Programming", SubjectName="Database", CourseFees=12000, DiscountAmount=2000, FinalAmount=10000 }


                );
        }
        public DbSet<Course> Courses { get; set; }
    }
}

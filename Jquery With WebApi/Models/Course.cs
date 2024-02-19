namespace Jquery_With_WebApi.Models
{
    public class Course
    {
        public Int64 CourseID { get; set; }
        public string CourseName { get; set; }

        public string SubjectName { get; set; }
        public Int64 CourseFees { get; set; }
        public Int64 DiscountAmount { get; set; }
        public Int64 FinalAmount { get; set; }
    }
}

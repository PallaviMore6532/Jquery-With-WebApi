using Jquery_With_WebApi.Models;

namespace Jquery_With_WebApi.Repositiories
{
    public interface ICourse
    {
        List<Course> GetAll();

        void Add(Course rec);
    }
}

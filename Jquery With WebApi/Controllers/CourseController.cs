using Jquery_With_WebApi.Models;
using Jquery_With_WebApi.Repositiories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jquery_With_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourse cc;
        public CourseController(ICourse cc)
        {
            this.cc=cc;
        }
        public IActionResult GetCourse()
        {
            var v = this.cc.GetAll();
            if (v==null)
                return NotFound();

            return Ok(v);

        }

        [HttpPost]
        public IActionResult CreateCourse(Course rec)
        {
            if (rec==null)
                return BadRequest();

            this.cc.Add(rec);
            return Ok("Course Saved!!!!!!!!!!");

        }
    }
}

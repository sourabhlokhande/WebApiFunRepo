using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFun.Models;
using WebApiFun.Services;

namespace WebApiFun.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class studentController : ControllerBase
    {
        private readonly IStudentService _student;

        public static List<Student> studentList = new List<Student>();

        public studentController(IStudentService student)
        {
            _student = student;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            
            return studentList;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody]Student student)
        {
            string result = _student.AddStudent(studentList, student);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult<string> Modify([FromBody] Student student)
        {
            string result = _student.Modify(studentList,student);
            return Ok(result);
        }

        [HttpDelete]
        public ActionResult<string> Delete([FromBody] Student student)
        {
            string result = _student.Delete(studentList, student);
            return Ok(result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebAPI.Controllers   
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string GetStudent()
        {
            return "Hello Student API";
        }
    }
}

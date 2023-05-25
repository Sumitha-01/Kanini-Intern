using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public string sayHello()
        {
            return "Hello Sumi";
        }
        //if want another get method we have to add action in the route
        //[HttpGet]
        //public string sayHi()
        //{
        //    return "Hi Sumi";
        //}
        [HttpPost]
        public string PostMethod()
        {
            return "From post Method";
        }
    }
}

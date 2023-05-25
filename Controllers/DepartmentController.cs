using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        static List<string> departmentNames = new List<string>() { "Ops", "Admin", "HR" };
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        //produce response type will provide both success and failure

        [HttpGet]
        public ActionResult<List<string>> ShowData()
        {
            if (departmentNames.Count == 0)
                return BadRequest("No department found");
            return Ok(departmentNames);
        }
        [HttpGet("ActionMethod")]
        public ActionResult<string> ShowData(int index)
        {
            if(index<0 || index>departmentNames.Count)
            {
                return NotFound();
            }
            else
            {
               return Ok(departmentNames[index]);
            }
           
        }
        [HttpPost]
        public ActionResult<string> AddString(string addName)
        {
            if(departmentNames.Contains(addName))
            {
                return NotFound("Could not enter duplicate value");
            }
            //BAdrequest giv 400 error Not Fount give 400 error
            else
            {
                departmentNames.Add(addName);
                return Ok(addName);
            }
        }
        [HttpDelete]
        public string Deleting(string name)
        {
            departmentNames.Remove(name);
            return name;
        }
       

    }
}

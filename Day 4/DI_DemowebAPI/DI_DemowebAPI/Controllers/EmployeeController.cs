using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DI_DemowebAPI.Models;
namespace DI_DemowebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //this is now a crime
        //  Employee empObj = new Employee(); 

        Employee _empObj;

        public EmployeeController(Employee empObjREF)
        {
            _empObj = empObjREF;
        }
        [HttpGet]
        [Route("elist")]
        public IActionResult GetAllEmployee()
        {
            return Ok(_empObj.GetAllEmployees());
        }
    }
}

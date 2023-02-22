using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using employeeManagementAPI.Models;
namespace employeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        Employee empObj = new Employee();

        [HttpGet]
        [Route("elist")]
        public IActionResult GetAllEmployees()
        {
            return Ok(empObj.GetAllEmployees());
        }


        [HttpGet]
        [Route("elist/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                return Ok(empObj.GetEmpById(id));
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
                 
            }
        }


        [HttpPost]
        [Route("elist/add")]
        public IActionResult AddNewEployee(Employee newEmp)
        {
           var addResult =  empObj.AddNewEmployee(newEmp);
            return Created("", addResult);
        }

        [HttpDelete]
        [Route("elist/delete")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var deleteResult = empObj.DeleteEmployee(id);
                return Accepted(deleteResult);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }
        [HttpPut]
        [Route("elist/edit")]
        public IActionResult EditeEmployee(Employee changes)
        {
            try
            {
                var editResult = empObj.EditEmployee(changes);
                return Accepted(editResult);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);  
            }
        }

    }
}













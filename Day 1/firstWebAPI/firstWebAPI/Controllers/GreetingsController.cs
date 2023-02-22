using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        [Route("greetings")]
        public IActionResult GreetUser()
        {
            //we always return a HTTPStatus code method
            return Ok("Hello and Welcome to WebAPI Development");
        }


        [HttpGet]
        [Route("greetings/{guestName}")]
        public IActionResult GreetUser(string guestName)
        {            
            return Ok("Good Morning " + guestName);
        }


        static List<string> friends = new List<string>()
        {
            "Aman","Sumit","Mohan","Rohan","Amin", "Supriya","Ankita","Roshni","Anjali"
        };

        [HttpGet]
        [Route("friends")]
        public IActionResult Friendslist()
        {
            return Ok(friends);
        }

        [HttpGet]
        [Route("friends/{index}")]
        public IActionResult Friend(int index)
        {
            return Ok(friends[index]);
        }


    }
}









using Microsoft.AspNetCore.Mvc;
using webapiCall_HttpClient.Models;
namespace webapiCall_HttpClient.Controllers
{
    public class ExternalCallsController : Controller
    {

        PostData pObj = new PostData();

        public IActionResult PostData()
        {


            ViewBag.data = pObj.GetPostData();
            return View();
        }
    }
}

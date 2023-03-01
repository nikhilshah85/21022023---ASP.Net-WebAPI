using Microsoft.AspNetCore.Mvc;

namespace shoppingAPP_MVC.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }


        public IActionResult Addproduct()
        {
            return View();
        }

      


    }
}

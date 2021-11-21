using Microsoft.AspNetCore.Mvc;

namespace ConnectWeb.Controllers
{
    public class loginController : Controller
    {

        public IActionResult Index()
        {
            return View();  
        }
    }
}

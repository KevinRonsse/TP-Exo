using Microsoft.AspNetCore.Mvc;

namespace Petiteannonce.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

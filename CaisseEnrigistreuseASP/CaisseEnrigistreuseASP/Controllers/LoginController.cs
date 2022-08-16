using Microsoft.AspNetCore.Mvc;

namespace CaisseEnrigistreuseASP.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

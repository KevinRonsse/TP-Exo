using Microsoft.AspNetCore.Mvc;

namespace exoASPmvn.Controllers
{
    public class Accueil : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }


        public IActionResult Form()
        {
            return View();
        }

        public IActionResult DetailContact()
        {
            return View();
        }
    }
}

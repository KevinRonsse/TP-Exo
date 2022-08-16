using exoASPmvn.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace exoASPmvn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Contact c = new Contact()
            {
                Nom = "nom",
                Prenom = "prenom",
                Telephone = "telephone"


            };
            return View();
            ViewBag.contacts = new List<Contact>() { c, new Contact() { Nom = "nom" , Prenom = "prenom"} };
            return View(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
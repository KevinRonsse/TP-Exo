using Microsoft.AspNetCore.Mvc;

namespace exoASPmvn.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            DataContext_data = new DataContext();
            return View(_data.Contacts.ToList());
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
}

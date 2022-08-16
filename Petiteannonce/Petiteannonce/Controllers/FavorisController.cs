using Microsoft.AspNetCore.Mvc;

namespace Petiteannonce.Controllers
{
    public class FavorisController
    {
        private FavorisService _favorisService;

        public FavorisController(FavorisService favorisService)
        {
            _favorisService = favorisService;
        }

        public IActionResult Index()
        {
            return View("~/Views/Annonce/Index.cshtml", _favorisService.GetFavoris());
        }

        public IActionResult ToggleFavoris(int id, bool add)
        {
            if (add)
            {
                _favorisService.AddToFavoris(id);
            }
            else
            {
                _favorisService.RemoveFromFavoris(id);
            }
            return RedirectToAction("Detail", "Annonce", new { id = id });
        }
    }
}
    }
}

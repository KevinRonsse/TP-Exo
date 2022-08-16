using Microsoft.AspNetCore.Mvc;
using Petiteannonce.Models;
using Petiteannonce.Repositories;

namespace Petiteannonce.Controllers
{

    public class CategorieController : Controller
    {
        private BaseRepository<Categorie> _categorieRepository;

        public CategorieController(BaseRepository<Categorie> categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

        public IActionResult Index()
        {
            return View(_categorieRepository.FindAll(c => true));
        }

        public IActionResult SubmitCategorie(Categorie categorie)
        {
            _categorieRepository.Add(categorie);
            return RedirectToAction("Index");
        }
    }
}


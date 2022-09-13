using dotnetPetShopProj.Repositories;
using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class AdminController : Controller
    {

        IAnimalRepository _animalRepo;
        ICategoryRepository _categoryRepo;
        public AdminController(IAnimalRepository animalRepo, ICategoryRepository categoryRepo)
        {
            _animalRepo = animalRepo;
            _categoryRepo = categoryRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View(_animalRepo.GetFullList());
        }

        public IActionResult Catalogue()
        {
            ViewBag.AllAnimals = _animalRepo.GetFullList();
            ViewBag.AllCategories = _categoryRepo.GetFullList();
            return View(_animalRepo.GetFullList());
        }
    }
}

using dotnetPetShopProj.Repositories;
using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class CatalogueController : Controller
    {
        IAnimalRepository _animalRepo;
        ICategoryRepository _categoryRepo;

        public CatalogueController(IAnimalRepository animalRepo, ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
            _animalRepo = animalRepo;
        }

        public IActionResult Index()
        {
            ViewBag.AllAnimals = _animalRepo.GetFullList();
            ViewBag.AllCategories = _categoryRepo.GetFullList();
            return View(_animalRepo.GetFullList());
        }


        public IActionResult AnimalDetails(int selAnimalId)
        {
            var selAnimal = _animalRepo.GetFullList().First(c=> c.CategoryId == selAnimalId);
            return View(selAnimal);
        }
    }
}

using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class AdminController : Controller
    {
        IPetShopService _petShopService;
        public AdminController(IPetShopService petShopService)
        {
            _petShopService = petShopService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View(_petShopService.GetAllAnimals());
        }

        public IActionResult Catalogue()
        {
            ViewBag.AllAnimals = _petShopService.GetAllAnimals();
            ViewBag.AllCategories = _petShopService.GetCategories();
            return View(_petShopService.GetAllAnimals());
        }
    }
}

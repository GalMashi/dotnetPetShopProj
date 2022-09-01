using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class AdminController : Controller
    {
        IPetShopService _shopService;
        public AdminController(IPetShopService shopService)
        {
            _shopService = shopService;
        }
        public IActionResult Index()
        {   
          return View();
        }
        
        public IActionResult Home()
        {
                    return View(_shopService.GetTopTwoAnimals());
        }
        
        public IActionResult Catalogue()
        {
            ViewBag.AllAnimals = _shopService.GetCollectionData().AnimalsModel;
            ViewBag.AllCategories = _shopService.GetCollectionData().CategoriesModel;
            return View();
        }
    }
}

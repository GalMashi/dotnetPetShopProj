using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class HomeController : Controller
    {
        IPetShopService _shopService;
        public HomeController(IPetShopService shopService)
        {
            _shopService = shopService;
        }
        public IActionResult Index()
        {
            
            return View(_shopService.GetTopTwoAnimals());
        }
    }
}

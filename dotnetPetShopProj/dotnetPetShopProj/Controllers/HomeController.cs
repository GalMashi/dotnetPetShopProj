using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class HomeController : Controller
    {
        IPetShopService _petShopService;
        public HomeController(IPetShopService petShopService)
        {
            _petShopService = petShopService;
        }
        public IActionResult Index()
        {
            return View(_petShopService.GetTopTwoAnimals());
        }
    }
}

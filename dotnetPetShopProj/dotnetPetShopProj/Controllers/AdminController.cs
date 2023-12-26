using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class AdminController : Controller
    {

        //adding http post and log in and LogOn method - open redirection attack

        IPetShopService _petShopService;
        public AdminController(IPetShopService petShopService) => _petShopService = petShopService;

        public IActionResult Index() => View();

        public IActionResult Home() => View(_petShopService.GetAllAnimals());

        public IActionResult Catalogue()
        {
            ViewBag.AllCategories = _petShopService.GetCategories();
            return View(_petShopService.GetAllAnimals());
        }

        [Route("AdminAnimalDetails/{selAnimalDetails:int}")]
        public IActionResult AdminAnimalDetails(int selAnimalDetails) => View(_petShopService.GetAnimalById(selAnimalDetails));

        public IActionResult About() => View();
    }
}

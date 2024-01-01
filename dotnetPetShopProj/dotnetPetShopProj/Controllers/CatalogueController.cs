using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class CatalogueController : Controller
    {
        IPetShopService _petShopService;

        public CatalogueController(IPetShopService petShopService) => _petShopService = petShopService;

        public IActionResult Index()
        {
            ViewBag.AllCategories = _petShopService.GetCategories();
            return View(_petShopService.GetAllAnimals());
        }


        [Route("AnimalDetails/{selAnimalDetails:int}")]
        public IActionResult AnimalDetails(int selAnimalDetails)
        {
            
            ViewBag.AnimalComments = _petShopService.GetCommentsByAnimal(selAnimalDetails);
            return View(_petShopService.GetAnimalById(selAnimalDetails));
        }
    }
}

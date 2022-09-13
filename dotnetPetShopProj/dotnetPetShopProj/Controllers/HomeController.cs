using dotnetPetShopProj.Repositories;
using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class HomeController : Controller
    {
        //IPetShopService _shopService;
        IAnimalRepository _animalRepo;
        public HomeController(IAnimalRepository animalRepo)
        {
            _animalRepo = animalRepo;
        }
        public IActionResult Index()
        {
            return View(_animalRepo.GetFullList()
                .OrderByDescending(a => a.CommentAmount)
                            .Take(2)
                            .ToList());
        }
    }
}

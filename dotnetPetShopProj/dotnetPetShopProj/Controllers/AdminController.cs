using dotnetPetShopProj.Models;
using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        //adding http post and log in and LogOn method - open redirection attack

        IPetShopService _petShopService;
        IUserService _userService;
        public AdminController(IPetShopService petShopService, IUserService userService)
        {
            _petShopService = petShopService;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateModel model)
        {
            var user = await _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

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

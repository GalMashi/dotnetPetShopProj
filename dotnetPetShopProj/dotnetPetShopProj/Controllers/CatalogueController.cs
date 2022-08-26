﻿using dotnetPetShopProj.Models;
using dotnetPetShopProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetPetShopProj.Controllers
{
    public class CatalogueController : Controller
    {
        IPetShopService _shopService;

        public CatalogueController(IPetShopService shopService)
        {
            _shopService = shopService;
        }

        public IActionResult Index()
        {
            ViewBag.AllAnimals = _shopService.GetCollectionData().AnimalsModel;
            ViewBag.AllCategories = _shopService.GetCollectionData().CategoriesModel;
            return View();
        }

        
    }
}

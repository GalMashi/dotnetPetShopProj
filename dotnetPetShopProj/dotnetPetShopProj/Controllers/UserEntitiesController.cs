using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;
using dotnetPetShopProj.Services;

namespace dotnetPetShopProj.Controllers
{
    //public class UserEntitiesController : Controller
    //{
    //    private readonly IPetShopService _petShopService;

    //    public UserEntitiesController(IPetShopService petShopService)
    //    {
    //        _petShopService = petShopService;
    //    }

    //    // GET: UserEntities
    //    public async Task<IActionResult> Index()
    //    {
    //        return View(await _petShopService.Users.ToListAsync());
    //    }

    //    // GET: UserEntities/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var userEntity = await _petShopService.Users
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (userEntity == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(userEntity);
    //    }

    //    // GET: UserEntities/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: UserEntities/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Mobile,Email,Source")] UserEntity userEntity)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _petShopService.Add(userEntity);
    //            await _petShopService.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(userEntity);
    //    }

    //    // GET: UserEntities/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var userEntity = await _petShopService.Users.FindAsync(id);
    //        if (userEntity == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(userEntity);
    //    }

    //    // POST: UserEntities/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Mobile,Email,Source")] UserEntity userEntity)
    //    {
    //        if (id != userEntity.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _petShopService.Update(userEntity);
    //                await _petShopService.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!UserEntityExists(userEntity.Id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(userEntity);
    //    }

    //    // GET: UserEntities/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var userEntity = await _petShopService.Users
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (userEntity == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(userEntity);
    //    }

    //    // POST: UserEntities/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var userEntity = await _petShopService.Users.FindAsync(id);
    //        if (userEntity != null)
    //        {
    //            _petShopService.Users.Remove(userEntity);
    //        }

    //        await _petShopService.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool UserEntityExists(int id)
    //    {
    //        return _petShopService.Users.Any(e => e.Id == id);
    //    }
    //}
}

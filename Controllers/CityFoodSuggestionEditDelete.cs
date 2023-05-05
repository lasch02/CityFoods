using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CityFoods.Data;
using CityFoods.Models;
using Microsoft.AspNetCore.Authorization;

namespace CityFoods.Controllers
{
    public class CityFoodSuggestionEditDelete : Controller
    {
        private readonly ApplicationDbContext _context;

        public CityFoodSuggestionEditDelete(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CityFoodSuggestionEditDelete
        public async Task<IActionResult> Index()
        {
            return View(await _context.CityFoodSuggestions.ToListAsync());
        }

        // GET: CityFoodSuggestionEditDelete/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityFoodSuggestion = await _context.CityFoodSuggestions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cityFoodSuggestion == null)
            {
                return NotFound();
            }

            return View(cityFoodSuggestion);
        }

        // GET: CityFoodSuggestionEditDelete/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CityFoodSuggestionEditDelete/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("City,State,NameOfUniqueFood,RestaurantName,ImgUrl,Id")] CityFoodSuggestion cityFoodSuggestion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cityFoodSuggestion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cityFoodSuggestion);
        }

        // GET: CityFoodSuggestionEditDelete/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityFoodSuggestion = await _context.CityFoodSuggestions.FindAsync(id);
            if (cityFoodSuggestion == null)
            {
                return NotFound();
            }
            return View(cityFoodSuggestion);
        }

        // POST: CityFoodSuggestionEditDelete/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("City,State,NameOfUniqueFood,RestaurantName,ImgUrl,Id")] CityFoodSuggestion cityFoodSuggestion)
        {
            if (id != cityFoodSuggestion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cityFoodSuggestion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityFoodSuggestionExists(cityFoodSuggestion.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cityFoodSuggestion);
        }

        // GET: CityFoodSuggestionEditDelete/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityFoodSuggestion = await _context.CityFoodSuggestions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cityFoodSuggestion == null)
            {
                return NotFound();
            }

            return View(cityFoodSuggestion);
        }

        // POST: CityFoodSuggestionEditDelete/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cityFoodSuggestion = await _context.CityFoodSuggestions.FindAsync(id);
            _context.CityFoodSuggestions.Remove(cityFoodSuggestion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool CityFoodSuggestionExists(int id)
        {
            return _context.CityFoodSuggestions.Any(e => e.Id == id);
        }
    }
}

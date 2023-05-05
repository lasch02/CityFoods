using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityFoods.Data;
using CityFoods.Models;
using CityFoods.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityFoods.Controllers
{
    public class FoodSuggestionController : Controller
    {
        private ApplicationDbContext context;

        public FoodSuggestionController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index(string searchString)
        {
            
            //List<CityFoodSuggestion> cityFoodSuggestions = context.CityFoodSuggestions.ToList();
            //return View(cityFoodSuggestions);
            //var stlOnly = context.CityFoodSuggestions.Where(s => s.City.Equals("stl"));
            //return View(stlOnly.ToList());
            ViewBag.CurrentFilter = searchString;
            var city = from c in context.CityFoodSuggestions
                       select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                city = city.Where(c => c.City.Contains(searchString));
            }
            return View(city.ToList());
        }

        [HttpGet]
        [Route("FoodSuggestion/AddFoodSuggestion")]
        public IActionResult AddFoodSuggestion()
        {
            AddCityFoodSuggestionViewModel addCityFoodSuggestionViewModel = new AddCityFoodSuggestionViewModel();
            return View(addCityFoodSuggestionViewModel);
        }

        [HttpPost]
        [Route("FoodSuggestion/AddFoodSuggestion")]
        public IActionResult AddFoodSuggestion(AddCityFoodSuggestionViewModel addCityFoodSuggestionViewModel)
        {
            if (ModelState.IsValid)
            {
                CityFoodSuggestion newcityFoodSuggestion = new CityFoodSuggestion
                {
                    City = addCityFoodSuggestionViewModel.City,
                    State = addCityFoodSuggestionViewModel.State,
                    NameOfUniqueFood = addCityFoodSuggestionViewModel.NameOfUniqueFood,
                    RestaurantName = addCityFoodSuggestionViewModel.RestaurantName,
                    ImgUrl = addCityFoodSuggestionViewModel.ImgUrl,
                };
                context.CityFoodSuggestions.Add(newcityFoodSuggestion);
                context.SaveChanges();

                return Redirect("/FoodSuggestion");
            }
                return View(addCityFoodSuggestionViewModel);
        }

        public IActionResult About(int id)
        {
            CityFoodSuggestion cityFoodSuggestion = context.CityFoodSuggestions.Find(id);

            return View(cityFoodSuggestion);
        }

        //public IActionResult Search()
        //{
        //    var stlOnly = context.CityFoodSuggestions.Where(s => s.City.Equals("stl"));
        //    return View(stlOnly.ToList());
        //}

    }
}
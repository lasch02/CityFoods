using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityFoods.Controllers
{
    public class FoodSuggestionController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFoodSuggestion()
        {
            return View();
        }

        [HttpPost("FoodSuggestion/Index")]
        public IActionResult AddFoodSuggestionResult()
        {
            return View();
        }
    }
}


using System;
using System.ComponentModel.DataAnnotations;
using CityFoods.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CityFoods.ViewModels
{
	public class AddCityFoodSuggestionViewModel
	{
        //[Required]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Must be between 1 and 50 characters in length.")]
        public string? City { get; set; }

        public State State { get; set; }
        public List<SelectListItem> States { get; set; } = new List<SelectListItem>
        {
            new SelectListItem (State.Alabama.ToString(),((int)State.Alabama).ToString()),
            new SelectListItem (State.Alaska.ToString(),((int)State.Alaska).ToString()),
            new SelectListItem (State.Arizona.ToString(),((int)State.Arizona).ToString()),
            new SelectListItem (State.Arkansas.ToString(),((int)State.Arkansas).ToString()),
            new SelectListItem (State.California.ToString(),((int)State.California).ToString()),
            new SelectListItem (State.Colorado.ToString(),((int)State.Colorado).ToString()),
            new SelectListItem (State.Connecticut.ToString(),((int)State.Connecticut).ToString()),
            new SelectListItem (State.Delaware.ToString(),((int)State.Delaware).ToString()),
            new SelectListItem (State.Florida.ToString(),((int)State.Florida).ToString()),
            new SelectListItem (State.Georgia.ToString(),((int)State.Georgia).ToString()),

            new SelectListItem (State.Hawaii.ToString(),((int)State.Hawaii).ToString()),
            new SelectListItem (State.Idaho.ToString(),((int)State.Idaho).ToString()),
            new SelectListItem (State.Illinois.ToString(),((int)State.Illinois).ToString()),
            new SelectListItem (State.Indiana.ToString(),((int)State.Indiana).ToString()),
            new SelectListItem (State.Iowa.ToString(),((int)State.Iowa).ToString()),
            new SelectListItem (State.Kansas.ToString(),((int)State.Kansas).ToString()),
            new SelectListItem (State.Kentucky.ToString(),((int)State.Kentucky).ToString()),
            new SelectListItem (State.Louisiana.ToString(),((int)State.Louisiana).ToString()),
            new SelectListItem (State.Maine.ToString(),((int)State.Maine).ToString()),
            new SelectListItem (State.Maryland.ToString(),((int)State.Maryland).ToString()),

            new SelectListItem (State.Massachusetts.ToString(),((int)State.Massachusetts).ToString()),
            new SelectListItem (State.Michigan.ToString(),((int)State.Michigan).ToString()),
            new SelectListItem (State.Minnesota.ToString(),((int)State.Minnesota).ToString()),
            new SelectListItem (State.Mississippi.ToString(),((int)State.Mississippi).ToString()),
            new SelectListItem (State.Missouri.ToString(),((int)State.Missouri).ToString()),
            new SelectListItem (State.Montana.ToString(),((int)State.Montana).ToString()),
            new SelectListItem (State.Nebraska.ToString(),((int)State.Nebraska).ToString()),
            new SelectListItem (State.Nevada.ToString(),((int)State.Nevada).ToString()),
            new SelectListItem (State.New_Hampshire.ToString(),((int)State.New_Hampshire).ToString()),
            new SelectListItem (State.New_Jersey.ToString(),((int)State.New_Jersey).ToString()),

            new SelectListItem (State.New_Mexico.ToString(),((int)State.New_Mexico).ToString()),
            new SelectListItem (State.New_York.ToString(),((int)State.New_York).ToString()),
            new SelectListItem (State.North_Carolina.ToString(),((int)State.North_Carolina).ToString()),
            new SelectListItem (State.North_Dakota.ToString(),((int)State.North_Dakota).ToString()),
            new SelectListItem (State.Ohio.ToString(),((int)State.Ohio).ToString()),
            new SelectListItem (State.Oklahoma.ToString(),((int)State.Oklahoma).ToString()),
            new SelectListItem (State.Oregon.ToString(),((int)State.Oregon).ToString()),
            new SelectListItem (State.Pennsylvania.ToString(),((int)State.Pennsylvania).ToString()),
            new SelectListItem (State.Rhode_Island.ToString(),((int)State.Rhode_Island).ToString()),

            new SelectListItem (State.South_Carolina.ToString(),((int)State.South_Carolina).ToString()),
            new SelectListItem (State.South_Dakota.ToString(),((int)State.South_Dakota).ToString()),
            new SelectListItem (State.Tennessee.ToString(),((int)State.Tennessee).ToString()),
            new SelectListItem (State.Texas.ToString(),((int)State.Texas).ToString()),
            new SelectListItem (State.Utah.ToString(),((int)State.Utah).ToString()),
            new SelectListItem (State.Vermont.ToString(),((int)State.Vermont).ToString()),
            new SelectListItem (State.Virginia.ToString(),((int)State.Virginia).ToString()),
            new SelectListItem (State.Washington.ToString(),((int)State.Washington).ToString()),
            new SelectListItem (State.West_Virginia.ToString(),((int)State.West_Virginia).ToString()),
            new SelectListItem (State.Wisconsin.ToString(),((int)State.Wisconsin).ToString()),
            new SelectListItem (State.Wyoming.ToString(),((int)State.Wyoming).ToString()),
        };

        public string? NameOfUniqueFood { get; set; }

		public string? RestaurantName { get; set; }

		[Url]
		public string? ImgUrl { get; set; }

		public AddCityFoodSuggestionViewModel()
		{
		}
	}
}


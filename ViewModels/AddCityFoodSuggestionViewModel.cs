using System;
using System.ComponentModel.DataAnnotations;

namespace CityFoods.ViewModels
{
	public class AddCityFoodSuggestionViewModel
	{
        [Required(ErrorMessage = "Hey buddy I need a name, thanks. 🙂")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Not so fast. Names must be between 3 and 50 characters in length.")]
        public string? City { get; set; }

		public string? NameOfUniqueFood { get; set; }

		public string? RestaurantName { get; set; }

		[Url]
		public string? ImgUrl { get; set; }

		public AddCityFoodSuggestionViewModel()
		{
		}
	}
}


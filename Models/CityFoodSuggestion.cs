using System;
using System.ComponentModel.DataAnnotations;
using CityFoods.Areas.Identity;

namespace CityFoods.Models
{
	public class CityFoodSuggestion 
	{
		public string? City { get; set; }
        public State State { get; set; }
        public string? NameOfUniqueFood { get; set; }
		public string? RestaurantName { get; set; }
		public string? ImgUrl { get; set; }

        [Key]
		public int Id { get; set; }


		public CityFoodSuggestion(string city, State state, string nameOfUniqueFood, string restaurantName, string imgUrl)
		{
			City = city;
            State = state;
            NameOfUniqueFood = nameOfUniqueFood;
			RestaurantName = restaurantName;
			ImgUrl = imgUrl;
		}

		public CityFoodSuggestion() { }

        public override bool Equals(object? obj)
        {
            return obj is CityFoodSuggestion suggestion &&
                   Id == suggestion.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
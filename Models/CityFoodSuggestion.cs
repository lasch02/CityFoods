using System;
namespace CityFoods.Models
{
	public class CityFoodSuggestion
	{
		public string? City { get; set; }
		public string? NameOfUniqueFood { get; set; }
		public string? RestaurantName { get; set; }
		public string? ImgUrl { get; set; }

		public int Id { get; set; }


		public CityFoodSuggestion(string city, string nameOfUniqueFood, string restaurantName, string imgUrl)
		{
			City = city;
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
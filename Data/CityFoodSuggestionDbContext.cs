using System;
using CityFoods.Models;
using Microsoft.EntityFrameworkCore;

namespace CityFoods.Data
{
	public class CityFoodSuggestionDbContext : DbContext
	{
        public DbSet<CityFoodSuggestion> CityFoodSuggestions { get; set; }

        public CityFoodSuggestionDbContext(DbContextOptions<CityFoodSuggestionDbContext> options)
            : base(options)
		{
		}
	}
}


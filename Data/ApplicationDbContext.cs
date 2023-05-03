using CityFoods.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CityFoods.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<CityFoodSuggestion> CityFoodSuggestions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
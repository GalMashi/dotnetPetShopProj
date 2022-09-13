using dotnetPetShopProj.Models;
using dotnetPetShopProj.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotnetPetShopProj.Data
{
    public class CategoryContext : DbContext
    {
        
        public DbSet<Category>? Categories { get; set; }

        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category() { CategoryId = 1, Name = "Bird" },
            new Category() { CategoryId = 2, Name = "Mammal" },
            new Category() { CategoryId = 3, Name = "Reptile" },
            new Category() { CategoryId = 4, Name = "Insect" }

        );
        }
    }
}

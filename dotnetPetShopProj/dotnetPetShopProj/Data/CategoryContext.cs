using dotnetPetShopProj.Models;
using dotnetPetShopProj.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotnetPetShopProj.Data
{
    public class CategoryContext : DbContext
    {
        ICategoryRepository _categoryRepo;
        public DbSet<Category>? Categories { get; set; }

        public CategoryContext(DbContextOptions<CategoryContext> options, ICategoryRepository categoryRepo) : base(options)
        {
            _categoryRepo = categoryRepo;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(_categoryRepo.GetFullList());
        }
    }
}

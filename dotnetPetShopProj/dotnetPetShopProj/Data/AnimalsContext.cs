using dotnetPetShopProj.Models;
using dotnetPetShopProj.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotnetPetShopProj.Data
{
    public class AnimalsContext : DbContext
    {
        IAnimalRepository _animalRepo;
        public DbSet<Animal>? Animals { get; set; }

        public AnimalsContext(DbContextOptions<AnimalsContext> options, IAnimalRepository animalRepo) : base(options)
        {
            _animalRepo = animalRepo;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(_animalRepo.GetFullList());
        }
    }
}

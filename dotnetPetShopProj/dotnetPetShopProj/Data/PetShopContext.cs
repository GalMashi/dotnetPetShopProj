using dotnetPetShopProj.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetPetShopProj.Data
{
    public class PetShopContext : DbContext
    {
        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<UserEntity>? Users { get; set; }

        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category() { CategoryId = 1, Name = "Bird" },
            new Category() { CategoryId = 2, Name = "Mammal" },
            new Category() { CategoryId = 3, Name = "Reptile" },
            new Category() { CategoryId = 4, Name = "Insect" }
        );

            modelBuilder.Entity<Animal>().HasData(
            new Animal() { AnimalId = 1, Age = "1", AnimalName = "Parrot", CategoryId = 1 },
            new Animal() { AnimalId = 2, Age = "3", AnimalName = "House Cat", CategoryId = 2 },
            new Animal() { AnimalId = 3, Age = "6", AnimalName = "Dog", CategoryId = 2 },
            new Animal() { AnimalId = 4, Age = "6", AnimalName = "House Cat", CategoryId = 2 },
            new Animal() { AnimalId = 5, Age = "2", AnimalName = "Common House Lizard", CategoryId = 3 },
            new Animal() { AnimalId = 6, Age = "8 days", AnimalName = "Hornet", CategoryId = 4 }
        );

            modelBuilder.Entity<Comment>().HasData(
              new Comment() { CommAnimalId = 1, CommentId = 1, CommentContent = "test" },
              new Comment() { CommAnimalId = 5, CommentId = 2, CommentContent = "test 2" }
              );



        }
    }
}

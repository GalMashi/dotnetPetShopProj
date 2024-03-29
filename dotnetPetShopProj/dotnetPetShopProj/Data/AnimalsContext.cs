﻿using dotnetPetShopProj.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetPetShopProj.Data
{
    public class AnimalsContext : DbContext
    {
        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Category>? Categories { get; set; }

        public AnimalsContext(DbContextOptions<AnimalsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
            new Animal() { AnimalId = 1, Age = "1", AnimalName = "Parrot", CategoryId = 1, CommentAmount = 0 },
            new Animal() { AnimalId = 2, Age = "3", AnimalName = "House Cat", CategoryId = 2, CommentAmount = 7 },
            new Animal() { AnimalId = 3, Age = "6", AnimalName = "Dog",  CategoryId = 2, CommentAmount = 5 },
            new Animal() { AnimalId = 4, Age = "6", AnimalName = "House Cat", CategoryId = 2, CommentAmount = 1 },
            new Animal() { AnimalId = 5, Age = "2", AnimalName = "Common House Lizard", CategoryId = 3, CommentAmount = 0 },
            new Animal() { AnimalId = 6, Age = "8 days", AnimalName = "Hornet", CategoryId = 4, CommentAmount = 3 }
);
        }
    }
}

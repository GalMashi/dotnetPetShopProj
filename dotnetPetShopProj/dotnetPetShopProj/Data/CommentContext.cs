using dotnetPetShopProj.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetPetShopProj.Data
{
    public class CommentContext : DbContext
    {
        public DbSet<Comment>? Comments { get; set; }

        public CommentContext(DbContextOptions<CommentContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
              new Comment() { CommAnimalId = 1, CommentId = 1, CommentContent = "test" },
              new Comment() { CommAnimalId = 5, CommentId = 2, CommentContent = "test 2" }
              );
        }
    }
}

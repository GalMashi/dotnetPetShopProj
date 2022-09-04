using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public class CategoryRepository<T> : IRepository<T>
    {
        public List<T> GetFullList()
        {
            List<Category> Categories = new List<Category>()
        {
            new Category() { CategoryId = 1, Name = "Bird"},
            new Category() { CategoryId = 2, Name = "Mammal"},
            new Category() { CategoryId = 3, Name = "Reptile"},
            new Category() { CategoryId = 4, Name = "Insect"}
        };

            return Categories as List<T>;
        }
    }
}


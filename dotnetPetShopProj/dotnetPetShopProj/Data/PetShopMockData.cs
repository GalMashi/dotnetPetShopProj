using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Data
{
    public class PetShopMockData
    {
        public List<Category>? Categories { get; set; }
        public List<Category> CreateCategoryData()
        {
            Categories = new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Bird"},
                new Category() { CategoryId = 2, Name = "Mammal"},
                new Category() { CategoryId = 3, Name = "Reptile"},
                new Category() { CategoryId = 4, Name = "Insect"}
            };

            return Categories;
        }
        public List<Animal> CreateAnimalData()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal() { AnimalId = 1, Age = "1", AnimalName = "Parrot", Category = (Category)Categories.Where(c => c.CategoryId == 1), CommentAmount = 0},
                new Animal() { AnimalId = 2, Age = "3", AnimalName = "House Cat", Category = (Category)Categories.Where(c => c.CategoryId == 2), CommentAmount = 7},
                new Animal() { AnimalId = 3, Age = "6", AnimalName = "Dog", Category = (Category)Categories.Where(c => c.CategoryId == 2), CommentAmount = 5},
                new Animal() { AnimalId = 4, Age = "6", AnimalName = "House Cat", Category = (Category)Categories.Where(c => c.CategoryId == 2), CommentAmount = 1},
                new Animal() { AnimalId = 5, Age = "2", AnimalName = "Common House Lizard", Category = (Category)Categories.Where(c => c.CategoryId == 3), CommentAmount = 0},
                new Animal() { AnimalId = 6, Age = "8 days", AnimalName = "Hornet", Category = (Category)Categories.Where(c => c.CategoryId == 4), CommentAmount = 3},
            };

            return animals;
        }

       
    }
}

using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Data
{
    public class PetShopMockData
    {
        
        
        public List<Animal> CreateAnimalData()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal() { AnimalId = 1, Age = 1, AnimalName = "Parrot", CategoryId = 1, CommentAmount = 0},
                new Animal() { AnimalId = 2, Age = 3, AnimalName = "House Cat", CategoryId = 2, CommentAmount = 7},
                new Animal() { AnimalId = 3, Age = 6, AnimalName = "Dog", CategoryId = 2, CommentAmount = 5},
                new Animal() { AnimalId = 4, Age = 6, AnimalName = "House Cat", CategoryId = 2, CommentAmount = 1},
                new Animal() { AnimalId = 5, Age = 2, AnimalName = "Common House Lizard", CategoryId = 3, CommentAmount = 0},
                new Animal() { AnimalId = 6, Age = 8, AnimalName = "Hornet", CategoryId = 4, CommentAmount = 3},
            };

            return animals;
        }

        public List<Category> CreateCategoryData()
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Bird"},
                new Category() { CategoryId = 2, Name = "Mammal"},
                new Category() { CategoryId = 3, Name = "Reptile"},
                new Category() { CategoryId = 4, Name = "Insect"}
            };

            return categories;
        }
    }
}

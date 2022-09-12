using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {

        public List<Animal> GetFullList()
        {

            var Cts = new CategoryRepository().GetFullList();
            List<Animal> animals = new List<Animal>()
        {
            new Animal() { AnimalId = 1, Age = "1", AnimalName = "Parrot", Category = Cts.First(c => c.CategoryId == 1), CommentAmount = 0},
            new Animal() { AnimalId = 2, Age = "3", AnimalName = "House Cat", Category = Cts.First(c => c.CategoryId == 2), CommentAmount = 7},
            new Animal() { AnimalId = 3, Age = "6", AnimalName = "Dog", Category = Cts.First(c => c.CategoryId == 2), CommentAmount = 5},
            new Animal() { AnimalId = 4, Age = "6", AnimalName = "House Cat", Category = Cts.First(c => c.CategoryId == 2), CommentAmount = 1},
            new Animal() { AnimalId = 5, Age = "2", AnimalName = "Common House Lizard", Category = Cts.First(c => c.CategoryId == 3), CommentAmount = 0},
            new Animal() { AnimalId = 6, Age = "8 days", AnimalName = "Hornet", Category = Cts.First(c => c.CategoryId == 4), CommentAmount = 3}
        };
            return animals;
        }
    }
}

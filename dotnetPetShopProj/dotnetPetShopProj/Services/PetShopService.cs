using dotnetPetShopProj.Models;
using dotnetPetShopProj.Repositories;

namespace dotnetPetShopProj.Services
{
    public class PetShopService : IPetShopService
    {

        ICategoryRepository _categoryRepo;
        IAnimalRepository _animalRepo;
        public PetShopService(IAnimalRepository animalRepo, ICategoryRepository categoryRepo)
        {
            _animalRepo = animalRepo;
            _categoryRepo = categoryRepo;
        }
        public List<Category> GetCategories() => _categoryRepo.GetFullList();

        public List<Animal> GetAllAnimals() => _animalRepo.GetFullList();


        public List<Animal> GetTopTwoAnimals()
        {
            List<Animal> TopTwoAnimals = GetAllAnimals()
                            .OrderByDescending(a => a.CommentAmount)
                            .Take(2)
                            .ToList();
            return TopTwoAnimals;
        }

        public Animal GetAnimalById(int id) => GetAllAnimals().FirstOrDefault(c => c.AnimalId == id);

    }
}

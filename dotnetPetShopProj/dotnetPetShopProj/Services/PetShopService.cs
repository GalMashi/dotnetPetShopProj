using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Services
{
    public class PetShopService : IPetShopService
    {
        //PetShopMockData _petShopMockData;

        //public PetShopService(PetShopMockData petShopMockData)
        //{
        //    _petShopMockData = petShopMockData;
        //}
        
        public List<Animal>? animals;
        //no need for this list if using repo

        IRepository<Animal> _animalRepo;
        IRepository<Category> _categoryRepo;
        //inject repo
        
        public PetShopService(IRepository<Animal> animalRepo, IRepository<Category> categoryRepo)
        {
            _animalRepo = animalRepo;
            _categoryRepo = categoryRepo;
        }
        
        public List<Animal> GetAllAnimals()
        {
        
        //return _animalRepo.GetFullList();
            animals = new List<Animal>()
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

        public List<Category> GetCategories()
        {
        //return _categoryRepo.GetFullList();
            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Bird"},
                new Category() { CategoryId = 2, Name = "Mammal"},
                new Category() { CategoryId = 3, Name = "Reptile"},
                new Category() { CategoryId = 4, Name = "Insect"}
            };

            return categories;
        }

        public CollectionDataModel GetCollectionData()
        {
            CollectionDataModel collectionData = new CollectionDataModel()
            {
                AnimalsModel = GetAllAnimals(),
                CategoriesModel = GetCategories()
            };

            return collectionData;
        }

        public List<Animal> GetTopTwoAnimals()
        {
            List<Animal> TopTwoAnimals = GetAllAnimals()
                            .OrderByDescending(a => a.CommentAmount)
                            .Take(2)
                            .ToList();
            return TopTwoAnimals;
        }
    }
}

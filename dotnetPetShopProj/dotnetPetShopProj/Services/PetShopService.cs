using dotnetPetShopProj.Models;
using dotnetPetShopProj.Repositories;

namespace dotnetPetShopProj.Services
{
    public class PetShopService : IPetShopService
    {
        public List<Animal>? animals;

        public List<Category>? Categories;

        ICategoryRepository _categoryRepo;
        IAnimalRepository _animalRepo;
        public PetShopService(IAnimalRepository animalRepo, ICategoryRepository categoryRepo)
        {
            _animalRepo = animalRepo;
            _categoryRepo = categoryRepo;
        }
    public List<Category> GetCategories()
    {
            return _categoryRepo.GetFullList();
        //return _petShopMockData.CreateCategoryData();
        Categories = new List<Category>()
        {
            new Category() { CategoryId = 1, Name = "Bird"},
            new Category() { CategoryId = 2, Name = "Mammal"},
            new Category() { CategoryId = 3, Name = "Reptile"},
            new Category() { CategoryId = 4, Name = "Insect"}
        };

        return Categories;
    }

        public List<Animal> GetAllAnimals()
        {
            var Cts = GetCategories();

            List<Animal> animals = new List<Animal>()
            {
                new Animal() { AnimalId = 1, Age = "1", AnimalName = "Parrot", Category = Cts.First(c => c.CategoryId == 1), CommentAmount = 0, PicturePath="~/images/ParrotPicture.jpg"},
                new Animal() { AnimalId = 2, Age = "3", AnimalName = "House Cat", Category = Cts.First(c => c.CategoryId == 2), CommentAmount = 0},
                new Animal() { AnimalId = 3, Age = "6", AnimalName = "Dog", Category = Cts.First(c => c.CategoryId == 2), CommentAmount = 0},
                new Animal() { AnimalId = 4, Age = "6", AnimalName = "House Cat", Category = Cts.First(c => c.CategoryId == 2), CommentAmount = 0},
                new Animal() { AnimalId = 5, Age = "6", AnimalName = "Common House Lizard", Category = Cts.First(c => c.CategoryId == 3), CommentAmount = 0},
                new Animal() { AnimalId = 6, Age = "8 days", AnimalName = "Hornet", Category = Cts.First(c => c.CategoryId == 4), CommentAmount = 0}
            };

            return animals;
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

        public Animal GetAnimalById(int id)
        {
            return GetAllAnimals().First(c => c.CategoryId == id);
        }

    }
}

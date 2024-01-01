using dotnetPetShopProj.Models;
using dotnetPetShopProj.Repositories;

namespace dotnetPetShopProj.Services
{
    public class PetShopService : IPetShopService
    {

        ICategoryRepository _categoryRepo;
        IAnimalRepository _animalRepo;
        ICommentRepository _commentRepo;
        public PetShopService(IAnimalRepository animalRepo, ICategoryRepository categoryRepo, ICommentRepository commentRepo)
        {
            _animalRepo = animalRepo;
            _categoryRepo = categoryRepo;
            _commentRepo = commentRepo;
            //connect();
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

        public Animal GetAnimalById(int id) => GetAllAnimals().Find(a => a.AnimalId.Equals(id));

        //public void connect()
        //{
        //    foreach (var animal in GetAllAnimals()) 
        //    {
        //        animal.CommentAmount = _commentRepo.GetComments().Where(a => a.CommAnimalId == animal.AnimalId).Count();
        //    }
        //}

        public List<Comment> GetCommentsByAnimal(int animalId)
        {
            return _commentRepo.GetCommentsByAnimal(animalId);
        }
    }
}

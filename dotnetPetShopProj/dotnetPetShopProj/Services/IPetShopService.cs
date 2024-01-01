using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Services
{
    public interface IPetShopService
    {
        List<Animal> GetAllAnimals();
        List<Animal> GetTopTwoAnimals();
        List<Category> GetCategories();
        Animal GetAnimalById(int id);
        List<Comment> GetCommentsByAnimal(int selAnimalId);
    }
}

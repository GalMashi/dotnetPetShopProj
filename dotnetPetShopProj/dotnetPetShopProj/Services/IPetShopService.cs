using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Services
{
    public interface IPetShopService
    {
        List<Animal> GetAllAnimals();
        List<Animal> GetTopTwoAnimals();
        List<Category> GetCategories();
        CollectionDataModel GetCollectionData();
    }
}

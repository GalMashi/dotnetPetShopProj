using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public interface IAnimalRepository
    {
        List<Animal> GetFullList();
    }
}

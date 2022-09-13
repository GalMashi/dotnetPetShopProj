using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        PetShopContext _petShopContext;
        public AnimalRepository(PetShopContext petShopContext)
        {
            _petShopContext = petShopContext;
        }
    
        public List<Animal> GetFullList() => _petShopContext.Animals.ToList();

    }
}

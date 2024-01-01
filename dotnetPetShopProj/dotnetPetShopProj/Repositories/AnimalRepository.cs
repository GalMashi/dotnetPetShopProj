using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        PetShopContext _petShopContext;
        //CommentContext _commentContext;
        public AnimalRepository(PetShopContext petShopContext/*, CommentContext commentContext*/)
        {
            _petShopContext = petShopContext;
            //_commentContext = commentContext;
        }
    
        public List<Animal> GetFullList() => _petShopContext.Animals.ToList();

    }
}

using dotnetPetShopProj.Data;
using dotnetPetShopProj.Entities;

namespace dotnetPetShopProj.Repositories
{
    public class UserRepository : IUserRepository
    {
        PetShopContext _petShopContext;

        public UserRepository(PetShopContext petShopContext) => _petShopContext = petShopContext;
        public List<User> GetAll() => _petShopContext.Users.ToList();
    }
}

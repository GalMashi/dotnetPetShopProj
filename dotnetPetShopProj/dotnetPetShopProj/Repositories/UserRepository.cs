using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public class UserRepository : IUserRepository
    {
        PetShopContext _petShopContext;

        public UserRepository(PetShopContext petShopContext) => _petShopContext = petShopContext;
        public List<UserEntity> GetAll() => _petShopContext.Users.ToList();
    }
}

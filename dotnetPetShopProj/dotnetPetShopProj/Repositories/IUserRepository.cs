using dotnetPetShopProj.Entities;

namespace dotnetPetShopProj.Repositories
{
    public interface IUserRepository
    {
        public List<User> GetAll();

    }
}

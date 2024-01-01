using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public interface IUserRepository
    {
        public List<UserEntity> GetAll();

    }
}

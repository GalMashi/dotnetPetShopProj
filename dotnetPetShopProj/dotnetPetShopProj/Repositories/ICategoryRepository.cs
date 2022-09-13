using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetFullList();
    }
}

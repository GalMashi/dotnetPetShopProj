using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        PetShopContext _petShopContext;
        public CategoryRepository(PetShopContext petShopContext)
        {
            _petShopContext = petShopContext;
        }

        public List<Category> GetFullList() => _petShopContext.Categories!.ToList();


    }
}


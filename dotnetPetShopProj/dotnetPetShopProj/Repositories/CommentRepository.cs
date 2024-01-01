using dotnetPetShopProj.Data;
using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        PetShopContext _petShopContext;
        public CommentRepository(PetShopContext petShopContext)
        {
              _petShopContext = petShopContext;
        }
        public List<Comment> GetComments()
        {
            return _petShopContext.Comments!.ToList();
        }

        public List<Comment> GetCommentsByAnimal(int id)
        {
            return GetComments().FindAll(a => a.CommAnimalId == id);
        }
    }
}

using dotnetPetShopProj.Models;

namespace dotnetPetShopProj.Repositories
{
    public interface ICommentRepository
    {
        public List<Comment> GetComments();
        public List<Comment> GetCommentsByAnimal(int id);
    }
}

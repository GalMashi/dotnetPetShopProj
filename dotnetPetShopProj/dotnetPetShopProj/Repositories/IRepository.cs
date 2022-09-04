namespace dotnetPetShopProj.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetFullList();
    }
}

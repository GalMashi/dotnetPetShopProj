using dotnetPetShopProj.Entities;

namespace dotnetPetShopProj.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
        };
        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => x.Username == username && x.Password == password));

            return user;
        }

        public async Task<IEnumerable<User>> GetAll() => await Task.Run(() => _users);
    }
}

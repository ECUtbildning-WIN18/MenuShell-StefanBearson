using MenuShell_StefanBearson.Domain;
using System.Linq;

namespace MenuShell_StefanBearson.Services
{
    class AuthenticationService
    {
        private readonly IUserLoader _userLoader;

        public AuthenticationService()
        {
            _userLoader = new UserLoader();
        }

        public User Authenticate(string username, string password)
        {
            var users = _userLoader.LoadUsers();

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}

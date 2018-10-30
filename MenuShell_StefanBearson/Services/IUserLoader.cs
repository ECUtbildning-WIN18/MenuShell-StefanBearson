using MenuShell_StefanBearson.Domain;
using System.Collections.Generic;

namespace MenuShell_StefanBearson.Services
{
    interface IUserLoader
    {
        List<User> LoadUsers();
    }
}

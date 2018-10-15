using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class Login
    {
        public static void LoginView()
        {
            Console.Clear();

            Write.WriteAt(Config.fromBorder, 4, "Please Log in", true);
            Write.WriteAt(Config.fromBorder, 6, "Username: ", false);
            Write.WriteAt(Config.fromBorder, 7, "Password:  ", false);

            Console.SetCursorPosition(Config.fromBorder + 10, 6);
            Console.ForegroundColor = ConsoleColor.Blue;
            string username = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.SetCursorPosition(Config.fromBorder + 10, 7);
            Console.ForegroundColor = ConsoleColor.Blue;
            string password = SecretPassword.EnterPassword();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            var authenticationService = new AuthenticationService();
            var user = authenticationService.Authenticate(username, password);

            CheckIfNotNull(user);
            Console.ReadKey();
        }

        public static void CheckIfNotNull(User user)
        {
            if (user != null)
            {
                Program.userLogdIn = user;
                Check.RoleAndSend(user);
            }
            else
            {
                WrongLoginDetails.View();
            }
        }
    }
}

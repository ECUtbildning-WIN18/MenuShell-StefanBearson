using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class ListUsersView
    {
        public static void View()
        {
            Console.Clear();

            Console.CursorVisible = false;

            Header.HeaderView();

            var userLoader = new UserLoader();
            var users = userLoader.LoadUsers();

            Write.WriteAt(Config.fromBorder, 2, $"Userlist", ConsoleColor.DarkGray, true);

            int row = 4;

            foreach (var user in users)
            {
                Write.WriteAt(Config.fromBorder, row, $"{user.Username}, {user.Role}", ConsoleColor.DarkGray, false);
                row++;
            }

            Console.ReadKey();

            SystemAdmin.MenuView();
        }
    }
}

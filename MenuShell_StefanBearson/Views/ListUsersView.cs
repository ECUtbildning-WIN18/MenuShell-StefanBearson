using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;
using System.Linq;

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

            Write.WriteAt(Config.fromBorder, 5, $"Userlist", ConsoleColor.DarkGray, true);

            int row = 7;

            foreach (var user in users.OrderBy(user => user.Username).ToList())
            {
                Write.WriteAt(Config.fromBorder, row, $"{user.Username}, {user.Role}", ConsoleColor.DarkGray, false);
                row++;
            }

            MenuView(row);

            MenuChoice();

            SystemAdmin.MenuView();
        }

        public static void MenuView(int row)
        {
            Write.WriteAt(Config.fromBorder, row + 2, $"(D) Delete (B) Back", ConsoleColor.DarkGray, false);
        }

        public static void MenuChoice()
        {
            ConsoleKey thePick = Console.ReadKey().Key;

            Console.CursorVisible = true;

            switch (thePick)
            {
                case ConsoleKey.D:
                    RemoveUserMenu.RemoveUserMenuView();
                    break;
                case ConsoleKey.B:
                    SystemAdmin.MenuView();
                    break;
                default:
                    break;
            }
        }
    }
}

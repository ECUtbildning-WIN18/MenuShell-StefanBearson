using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using MenuShell_StefanBearson.Domain;

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

            MenuChoice(users);

            SystemAdmin.MenuView();
        }

        public static void MenuView(int row)
        {
            Write.WriteAt(Config.fromBorder, row + 2, $"(D)elete (V)iew User Info (B)ack", ConsoleColor.DarkGray, false);
        }

        public static void MenuChoice(List<User> users)
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
                case ConsoleKey.V:
                    UserInfoView.View(users);
                    break;
                default:
                    break;
            }
        }
    }
}

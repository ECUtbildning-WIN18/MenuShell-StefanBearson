using MenuShell_StefanBearson.Tools;
using System;
using MenuShell_StefanBearson.Services;

namespace MenuShell_StefanBearson.Views
{
    class SystemAdmin
    {
        public static void MenuView()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Header.HeaderView();

            Write.WriteAt(Config.fromBorder, 5, "Manage user menu", true);
            Write.WriteAt(Config.fromBorder, 7, "(1) Add user", false);
            Write.WriteAt(Config.fromBorder, 8, "(2) Remove user", false);
            Write.WriteAt(Config.fromBorder, 9, "(3) List users", false);
            Write.WriteAt(Config.fromBorder, 10, "(4) Search users", false);
            Write.WriteAt(Config.fromBorder, 12, "(Q) Quit", false);

            ChoseOnMenuView();
        }

        public static void ChoseOnMenuView()
        {
            ConsoleKey thePick = Console.ReadKey().Key;

            Console.CursorVisible = true;

            switch (thePick)
            {
                case ConsoleKey.D1:
                    AddUserMenu.AddUser();
                    break;
                case ConsoleKey.D2:
                    RemoveUserMenu.RemoveUserMenuView();
                    break;
                case ConsoleKey.D3:
                    UserLoader.LoadSQLTolist();
                    //ListUsersView.View();
                    break;
                case ConsoleKey.D4:
                    SearchUser.SearchView();
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}

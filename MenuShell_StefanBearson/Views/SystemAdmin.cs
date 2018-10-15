using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class SystemAdmin
    {
        public static void MenuView()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Header.HeaderView();
            Write.WriteAt(Config.fromBorder, 5, "System Admin Menu", true);
            Write.WriteAt(Config.fromBorder, 7, "(1) Add user", false);
            Write.WriteAt(Config.fromBorder, 8, "(2) Remove user", false);

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
                default:
                    break;
            }
        }
    }
}

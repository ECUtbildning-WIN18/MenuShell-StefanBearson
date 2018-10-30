using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class AdminStartMenu
    {
        public static void MenuView()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Header.HeaderView();

            Write.WriteAt(Config.fromBorder, 5, "System Admin Menu", true);
            Write.WriteAt(Config.fromBorder, 7, "(1) Manage users", false);
            Write.WriteAt(Config.fromBorder, 8, "(Q) Quit", false);

            ChoseOnMenuView();
        }

        public static void ChoseOnMenuView()
        {
            ConsoleKey thePick = Console.ReadKey().Key;

            Console.CursorVisible = true;

            switch (thePick)
            {
                case ConsoleKey.D1:
                    SystemAdmin.MenuView();
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

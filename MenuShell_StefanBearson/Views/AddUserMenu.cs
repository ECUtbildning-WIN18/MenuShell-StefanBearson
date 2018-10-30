using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class AddUserMenu
    {
        public static void AddUser()
        {
            Header.HeaderView();

            Write.WriteAt(Config.fromBorder, 5, "Add a user!", true);
            Write.WriteAt(Config.fromBorder, 6, "Username:", false);
            Write.WriteAt(Config.fromBorder, 7, "Password:", false);
            Write.WriteAt(Config.fromBorder, 8, "Social Security Number:", false);
            Write.WriteAt(Config.fromBorder, 9, "Role:", false);

            InputData();

            SystemAdmin.MenuView();
        }

        public static void InputData()
        {
            Console.SetCursorPosition(Config.fromBorder + 10, 6);
            Console.ForegroundColor = ConsoleColor.Blue;
            string username = Console.ReadLine();

            Console.SetCursorPosition(Config.fromBorder + 10, 7);
            string password = Console.ReadLine();

            Console.SetCursorPosition(Config.fromBorder + 24, 8);
            string socialSecurityNumber = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            RoleInternalMenu();

            Console.SetCursorPosition(Config.fromBorder + 24, 9);
            Console.ForegroundColor = ConsoleColor.Blue;
            ConsoleKey rolechose = Console.ReadKey().Key;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            string role = "";
            if (rolechose == ConsoleKey.D1)
            {
                role = "SystemAdmin";
            }
            else if (rolechose == ConsoleKey.D2)
            {
                role = "Reciption";
            }

            User user = new User(username, socialSecurityNumber, password, role);

            UserSaver.SaveUser(user);
            UserSaver.SaveToSQL(user);
        }

        public static void RoleInternalMenu()
        {
            Write.WriteAt(Config.fromBorder, 9, "Role, (pick a number): ( )", false);
            Write.WriteAt(Config.fromBorder, 11, "Roles = (1) System Admin", false);
            Write.WriteAt(Config.fromBorder, 12, "        (2) Reciption", false);
        }
    }
}

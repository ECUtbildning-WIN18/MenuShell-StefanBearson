using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class WrongLoginDetails
    {
        public static void View()
        {
            Console.Clear();

            Write.WriteAt(Config.fromBorder, 5, "Wong login details", ConsoleColor.Red, true);
            Write.WriteAt(Config.fromBorder, 6, "Please try again or contact Admin", ConsoleColor.Red, true);
            Write.WriteAt(Config.fromBorder, 7, "Press any key to continue...", ConsoleColor.Red, true);

            Console.ReadKey();
            Login.LoginView();
        }
    }
}

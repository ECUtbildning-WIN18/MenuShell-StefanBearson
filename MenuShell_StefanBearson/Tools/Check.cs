using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Views;
using System;

namespace MenuShell_StefanBearson.Tools
{
    class Check
    {
        public static void RoleAndSend(User user)
        {
            if (user.Role == "Reciption")
            {
                Reception.ReceptionMenu();
            }
            else if (user.Role == "SystemAdmin")
            {
                SystemAdmin.MenuView();
            }
            else
            {
                Write.WriteAt(Config.fromBorder, 4, $"Wrong User role", ConsoleColor.Red, true);
                Console.ReadKey();
            }
        }
    }
}

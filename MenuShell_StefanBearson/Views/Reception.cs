using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class Reception
    {
        public static void ReceptionMenu()
        {
            Console.Clear();
            Header.HeaderView();
            Write.WriteAt(Config.fromBorder, 5, "ReceptionsMenu", true);
            Write.WriteAt(Config.fromBorder, 7, "Press any key to continue...", false);
            Login.LoginView();
        }
    }
}

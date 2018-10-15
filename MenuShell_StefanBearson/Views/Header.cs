using MenuShell_StefanBearson.Tools;
using System;

namespace MenuShell_StefanBearson.Views
{
    class Header
    {
        public static void HeaderView()
        {
            Console.Clear();
            Write.WriteAt(0, 0, "################################", ConsoleColor.DarkGray,false);
            if (ChangeColorTheme.theme == "light")
            {
                Write.WriteAt(3, 0, $"# {Program.userLogdIn.Username} #", ConsoleColor.Black, false);
            }
            else
            {
                Write.WriteAt(3, 0, $"# {Program.userLogdIn.Username} #", ConsoleColor.White, false);
            }

            Write.WriteAt(25, 0, "#", ConsoleColor.Red, false);
            Write.WriteAt(26, 0, "#", ConsoleColor.Green, false);
            Write.WriteAt(27, 0, "#", ConsoleColor.Blue, false);
        }
    }
}

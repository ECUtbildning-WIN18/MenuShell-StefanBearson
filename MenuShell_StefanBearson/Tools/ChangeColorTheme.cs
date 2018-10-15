using System;

namespace MenuShell_StefanBearson.Tools
{
    class ChangeColorTheme
    {
        public static string theme = "";

        public static void ChangeColorThemeView()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Write.WriteAt(Config.fromBorder, 5, "(1) for light theme", true);
            Write.WriteAt(Config.fromBorder, 6, "(2) for dark theme", true);
            ChangeColorThemeSelector();
        }

        public static void ChangeColorThemeSelector()
        {
            var selected = Console.ReadKey().Key;

            switch (selected)
            {
                case ConsoleKey.D1:
                    LightTheme();
                    theme = "light";
                    break;
                case ConsoleKey.D2:
                    DarkTheme();
                    theme = "dark";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public static void LightTheme()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
        }

        public static void DarkTheme()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
        }
    }
}

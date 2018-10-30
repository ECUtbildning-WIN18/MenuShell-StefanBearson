using System;

namespace MenuShell_StefanBearson.Tools
{
    class AccessibilitySpeak
    {
        public static bool wantSpeak;

        public static void ChangeColorThemeView()
        {
            Console.Clear();
            Console.CursorVisible = false;

            Write.WriteAt(Config.fromBorder, 5, "(1) for Accessibilty Speak mode", false);
            Write.WriteAt(Config.fromBorder, 6, "(2) for quiet mode", false);

            ChangeColorThemeSelector();
        }

        public static void ChangeColorThemeSelector()
        {
            var selected = Console.ReadKey().Key;

            switch (selected)
            {
                case ConsoleKey.D1:
                    wantSpeak = true;
                    break;
                case ConsoleKey.D2:
                    wantSpeak = false;
                    break;
                default:
                    ChangeColorThemeView();
                    break;
            }
        }
    }
}

using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Tools;
using MenuShell_StefanBearson.Views;
using System.Speech.Synthesis;

namespace MenuShell_StefanBearson
{
    class Program
    {
        public static User userLogdIn;

        static void Main(string[] args)
        {
            AccessibilitySpeak.ChangeColorThemeView();
            ChangeColorTheme.ChangeColorThemeView();

            Login.LoginView();
        }


    }
}

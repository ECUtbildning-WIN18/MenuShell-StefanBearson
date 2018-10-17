using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using MenuShell_StefanBearson.Views;

namespace MenuShell_StefanBearson
{
    class Program
    {
        public static User userLogdIn;

        static void Main(string[] args)
        {
            CreateUsersXMLifNotExists.CreateXML();

            AccessibilitySpeak.ChangeColorThemeView();

            ChangeColorTheme.ChangeColorThemeView();

            Login.LoginView();
        }
    }
}

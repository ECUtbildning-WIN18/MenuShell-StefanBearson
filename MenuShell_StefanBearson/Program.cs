using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Views;
using System.Collections.Generic;
using MenuShell_StefanBearson.Tools;

namespace MenuShell_StefanBearson
{
    class Program
    {
        public static User userLogdIn;

        //public static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            CreateUsersXMLifNotExists.CreateXML();

            //AccessibilitySpeak.ChangeColorThemeView();

            ChangeColorTheme.ChangeColorThemeView();

            Login.LoginView();
        }
    }
}

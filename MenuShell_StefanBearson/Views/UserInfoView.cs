using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuShell_StefanBearson.Views
{
    class UserInfoView
    {
        public static void View(List<User> users)
        {
            Console.Clear();
            Header.HeaderView();

            Write.WriteAt(Config.fromBorder, 5, $"User Info View", ConsoleColor.DarkGray, true);

            int row = 7;
            int number = 1;

            foreach (var user in users.OrderBy(user => user.Username).ToList())
            {
                Write.WriteAt(Config.fromBorder, row, $"{number} : {user.Username}", ConsoleColor.DarkGray, false);
                row++;
                number++;
            }

            Console.CursorVisible = false;
            try
            {
                Console.SetCursorPosition(Config.fromBorder, row);

                int pickUser = Convert.ToInt32(Console.ReadLine());

                List<User> sortedlist = users.OrderBy(user => user.Username).ToList();

                UserInfo(sortedlist[pickUser - 1]);
            }
            catch (Exception e)
            {
                Write.WriteAt(Config.fromBorder, row + 1, $"User do not exist, try again!", ConsoleColor.DarkRed, false);
                Console.ReadKey();
                UserInfoView.View(users);
            }
        }

        public static void UserInfo(User user)
        {
            Console.Clear();
            Header.HeaderView();

            Write.WriteAt(Config.fromBorder, 5, $"Name:\t\t\t {user.Username}", ConsoleColor.DarkGray, false);
            Write.WriteAt(Config.fromBorder, 6, $"Password:\t\t\t {user.Password}", ConsoleColor.DarkGray, false);
            Write.WriteAt(Config.fromBorder, 7, $"Social Securit number:\t {user.SocialSecurityNumber}", ConsoleColor.DarkGray, false);
            Write.WriteAt(Config.fromBorder, 8, $"Role:\t\t\t {user.Role}", ConsoleColor.DarkGray, false);
            Write.WriteAt(Config.fromBorder, 9, $"Press any key to continue...", ConsoleColor.DarkRed, false);

            Console.ReadKey();

            Console.CursorVisible = true;

            ListUsersView.View();
        }
    }
}

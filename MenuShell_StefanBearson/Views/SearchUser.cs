using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;
using System.Collections.Generic;

namespace MenuShell_StefanBearson.Views
{
    class SearchUser
    {
        public static void SearchView()
        {
            Console.Clear();
            Header.HeaderView();

            Write.WriteAt(Config.fromBorder, 5, "Search View", true);
            Write.WriteAt(Config.fromBorder, 6, "Search username: ", false);

            string searchUserName = Console.ReadLine();

            Searchfunction(searchUserName);
        }

        public static void Searchfunction(string SearchUserName)
        {
            var userLoader = new UserLoader();

            var users = userLoader.LoadUsers();

            List<User> searchList = users.FindAll(x => x.Username.ToLower().Contains(SearchUserName.ToLower()));

            PrintList(searchList);

            Console.ReadKey();

            Console.CursorVisible = false;

            SystemAdmin.MenuView();
        }

        public static void PrintList(List<User> searchList)
        {
            Console.CursorVisible = true;

            Write.WriteAt(5, 8, $"Username", ConsoleColor.Blue, false);
            Write.WriteAt(20, 8, $"Password", ConsoleColor.Blue, false);
            Write.WriteAt(30, 8, $"Role", ConsoleColor.Blue, false);

            int row = 9;

            foreach (var user in searchList)
            {
                Write.WriteAt(5, row, $"{user.Username}", false);
                Write.WriteAt(20, row, $"{user.Password}", false);
                Write.WriteAt(30, row, $"{user.Role}", false);

                row++;
            }
        }
    }
}

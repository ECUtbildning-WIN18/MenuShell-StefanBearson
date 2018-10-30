using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

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

            //Searchfunction(searchUserName);
            UserSearch.Search(searchUserName);
            SystemAdmin.MenuView();
        }

        public static void Searchfunction(string SearchUserName)
        {
            var userLoader = new UserLoader();

            var users = userLoader.LoadUsers();

            List<User> searchList = users.FindAll(x => x.Username.ToLower().Contains(SearchUserName.ToLower()));

            PrintList(searchList, users);

            Console.ReadKey();

            Console.CursorVisible = true;
        }

        public static void PrintList(List<User> searchList, List<User> users)
        {
            Console.CursorVisible = false;

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
            Write.WriteAt(5, row, $"(D) Delete user/Users?", ConsoleColor.Red, false);
            row++;

            ChoseOnPrintList(users, searchList);
        }

        public static void ChoseOnPrintList(List<User> userList, List<User> usersHowwillbeDeleted)
        {
            ConsoleKey thePick = Console.ReadKey().Key;

            Console.CursorVisible = true;

            switch (thePick)
            {
                case ConsoleKey.D:
                    DeleteUsers(userList, usersHowwillbeDeleted);
                    break;
                default:
                    break;
            }
        }

        public static void DeleteUsers(List<User> userList, List<User> usersHowwillbeDeleted)
        {
            List<User> newList = userList.Except(usersHowwillbeDeleted).ToList();

            SaveNewUserList.Save(newList);
        }
    }
}

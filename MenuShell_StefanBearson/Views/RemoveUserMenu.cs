﻿using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;
using System.Linq;
using System.Threading;

namespace MenuShell_StefanBearson.Views
{
    class RemoveUserMenu
    {
        public static void RemoveUserMenuView()
        {
            Header.HeaderView();

            var userLoader = new UserLoader();

            var users = userLoader.LoadUsers();

            int row = 6;

            foreach (var user in users.OrderBy(user => user.Username).ToList())
            {
                Write.WriteAt(Config.fromBorder, row, $"{user.Username}", ConsoleColor.DarkRed, false);
                row++;
            }

            Write.WriteAt(Config.fromBorder, row + 2, $"Type the name of the user you want to remove:", true);

            Console.SetCursorPosition(Config.fromBorder, row + 3);

            string removeName = Console.ReadLine();

            if (users.All(user => user.Username != removeName))
            {
                Console.Clear();

                Write.WriteAt(Config.fromBorder, 5, $"No users found matching the search term {removeName}", ConsoleColor.Red, true);

                Thread.Sleep(2000);

                SystemAdmin.MenuView();
            }
                Console.WriteLine();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == removeName)
                    users.Remove(users[i]);
            }



            SaveNewUserList.Save(users);

            SystemAdmin.MenuView();
        }
    }
}

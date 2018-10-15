using MenuShell_StefanBearson.Services;
using MenuShell_StefanBearson.Tools;
using System;

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

            foreach (var user in users)
            {
                Write.WriteAt(Config.fromBorder, row, $"{user.Username}", ConsoleColor.DarkRed, false);
                row++;
            }

            Write.WriteAt(Config.fromBorder, row + 2, $"Type the name of the user you want to remove:", true);
            Console.SetCursorPosition(Config.fromBorder, row + 3);

            string removeName = Console.ReadLine();

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

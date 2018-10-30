using System.IO;

namespace MenuShell_StefanBearson.Services
{
    class CreateUsersXMLifNotExists
    {
        public static void CreateXML()
        {
            if (File.Exists("Users.xml"))
            {

            }
            else
            {
                System.IO.File.WriteAllText(@"Users.xml", @"<?xml version=""1.0"" encoding=""utf-8""?>
<Users>
<User role = ""SystemAdmin"" socialSecurityNumber = ""654321"" password = ""1234"" username = ""Admin"" />
<User role = ""Reciption"" socialSecurityNumber = ""1234"" password = ""1234"" username = ""Pelle"" />
<User role = ""SystemAdmin"" socialSecurityNumber = ""1234"" password = ""1234"" username = ""sture"" />
</Users>");
            }
        }
    }
}

using DVLD_BusinessLayer;
using System;
using System.IO;

namespace DVLD_PresentationLayer
{
    //class Glolbal

    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        private static string folderPath = @"C:\data";
        private static string LoginRegistersFile = Path.Combine(folderPath, "LoginRegister.txt");
        private static string RememberMeFile = Path.Combine(folderPath, "RememberMeFile.txt");

        public static bool IsLoad()
        {

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (StreamReader reDatabase = new StreamReader(RememberMeFile))
            {

                string record = reDatabase.ReadLine();
                if (record == null)
                    return false;

                string[] data = record.Split(new string[] { "#//#" }, StringSplitOptions.None);
                CurrentUser = clsUser.FindByUsernameAndPassword(data[0], data[1]);
            }

            return CurrentUser != null;
        }

        public static void RememberMe(string UserName, string Password)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (StreamWriter reDatabase = new StreamWriter(RememberMeFile))
            {
                reDatabase.WriteLine(UserName + "#//#" + Password);
            }
            RegisterLogIn();
        }

        private static void RegisterLogIn()
        {
            using (StreamWriter reDatabase = new StreamWriter(LoginRegistersFile, true))
            {
                reDatabase.WriteLine(CurrentUser.UserName + "  -  " + DateTime.Now.ToString());
            }

        }

    }


}
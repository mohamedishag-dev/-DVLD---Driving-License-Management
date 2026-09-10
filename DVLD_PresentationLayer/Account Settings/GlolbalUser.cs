using DVLD_BusinessLayer;
using System;
using System.IO;

namespace DVLD_PresentationLayer
{
    //class Glolbal

    public static class GlolbalUser
    {
        public static clsUser CurrentUser = clsUser.Find("", "");

        public static bool Login()
        {
            using (StreamReader reDatabase = new StreamReader(Constants.RememberMeFile))
            {

                string record = reDatabase.ReadLine();
                if (record == null)
                    return false;

                string[] data = record.Split(new string[] { Constants.Separator }, StringSplitOptions.None);

                if (data.Length == 2)
                {
                    CurrentUser = clsUser.Find(data[0], data[1]);
                }

            }

            return CurrentUser != null;
        }

        public static void RememberMe()
        {
            using (StreamWriter reDatabase = new StreamWriter(Constants.RememberMeFile))
            {
                reDatabase.WriteLine(CurrentUser.UserName + Constants.Separator + CurrentUser.Password);
            }

        }

        public static void Remove()
        {
            File.WriteAllText(Constants.RememberMeFile, "");

        }

        public static void RegisterLogIn()
        {
            using (StreamWriter reDatabase = new StreamWriter(Constants.LoginRegistersFile, true))
            {
                reDatabase.WriteLine(CurrentUser.UserName + "  -  " + DateTime.Now.ToString());
            }

        }

    }


}
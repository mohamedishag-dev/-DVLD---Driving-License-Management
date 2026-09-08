using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{

    public class clsUser
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        clsPerson PersonInfo => clsPerson.Find(PersonID);

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }


        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            IsActive = false;
            this.Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string userName, string password, bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
            this.Mode = enMode.Update;
        }

        public static DataTable GetAllUsers()
        {

            return clsUserData.GetAllUsers();

        }

        public static clsUser Find(int userID)
        {
            int personID = -1;
            bool isActive = false;
            string userName = "", password = "";

            if (clsUserData.GetUserInfoByUserID(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            else
                return null;
        }

        public static clsUser Find(int userID, string password)
        {
            int personID = -1;
            bool isActive = false;
            string userName = "";

            if (clsUserData.GetUserInfoByUserID(userID, ref personID, ref userName, ref password, ref isActive))
                return new clsUser(userID, personID, userName, password, isActive);
            else
                return null;
        }

        private bool _AddNewUser()
        {
            if (this.UserName == "")
                return false;
            if (this.Password == "")
                return false;


            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);

            return (this.UserID != -1);

        }

        private bool _UpdateUser()
        {

            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);

        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExistByID(UserID);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUserByID(UserID);
        }

    }

}


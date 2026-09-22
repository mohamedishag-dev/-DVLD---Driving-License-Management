using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsTestType
    {
        public int TestTypeID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        public clsTestType()
        {
            this.TestTypeID = -1;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = 0;
        }

        clsTestType(int TestTypeID, string ApplicationTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = ApplicationTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }

        public static clsTestType Find(int TestTypeID)
        {
            string ApplicationTypeTitle = "", TestTypeDescription = "";
            decimal ApplicationFees = 0;

            if (clsTestTypeData.GetTestTypeInfoByID(TestTypeID, ref ApplicationTypeTitle, ref TestTypeDescription, ref ApplicationFees))
                return new clsTestType(TestTypeID, ApplicationTypeTitle, TestTypeDescription, ApplicationFees);
            else
                return null;
        }

        public bool Save()
        {

            if (clsTestTypeData.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees))
                return true;
            else
                return false;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

    }

}

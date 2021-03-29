using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList {
            get
            {
                return mCustomerList;
            }

            set
            {
                mCustomerList = value;
            }
        }
        public int Count {
            get
            {
                return mCustomerList.Count;
            }
                
            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@IsMember", mThisCustomer.IsMember);
            DB.AddParameter("@UserPassword", "password");

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@IsMember", mThisCustomer.IsMember);
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblCustomer_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();

                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.IsMember = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsMember"]);

                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
    }
}
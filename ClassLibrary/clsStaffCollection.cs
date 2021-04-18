using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {

            }

        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }


        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {
                clsStaff StaffMember = new clsStaff();

                StaffMember.StaffNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNumber"]);
                StaffMember.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                StaffMember.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                StaffMember.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                StaffMember.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                StaffMember.IsManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsManager"]);
                StaffMember.HourlyRate = Convert.ToDecimal(DB.DataTable.Rows[Index]["HourlyRate"]);

                mStaffList.Add(StaffMember);

                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);
            DB.AddParameter("@HourlyRate", mThisStaff.HourlyRate);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);
            DB.AddParameter("@HourlyRate", mThisStaff.HourlyRate);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", FirstName);
            DB.Execute("sproc_tblStaff_FilterByFirstName");
            PopulateArray(DB);
        }
    }
}
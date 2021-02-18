using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffNumber;
        public int StaffNumber
        {
            get
            {
                return mStaffNumber;
            }

            set
            {
                mStaffNumber = value;
            }
        }

        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }

            set
            {
                mFirstName = value;
            }
        }

        private string mLastName;
        public string LastName {
            get
            {
                return mLastName;
            }

            set
            {
                mLastName = value;
            }
        }

        private bool mIsManager;
        public bool IsManager
        {
            get
            {
                return mIsManager;
            }
            set
            {
                mIsManager = value;
            }
        }

        private decimal mHourlyRate;
        public decimal HourlyRate
        {
            get
            {
                return mHourlyRate;
            }
            set
            {
                mHourlyRate = value;
            }
        }

        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        private DateTime mStartDate;

        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }



        public bool Find(int StaffNumber)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the stored procedure
            DB.AddParameter("@StaffNumber", StaffNumber);
            //Run the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNumber");
            if (DB.Count == 1)
            {
                mFirstName   = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName    = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mStartDate   = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mIsManager   = Convert.ToBoolean(DB.DataTable.Rows[0]["IsManager"]);
                mHourlyRate  = Convert.ToDecimal(DB.DataTable.Rows[0]["HourlyRate"]);

                return true;
            }

            else return false;
            
        }
    }
}
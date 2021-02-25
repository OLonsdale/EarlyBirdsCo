using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffNumber;
        public int StaffNumber
        {
            get { return mStaffNumber; }
            set { mStaffNumber = value;}
        }

        private string mFirstName;
        public string FirstName
        {
            get{ return mFirstName; }
            set{ mFirstName = value;}
        }

        private string mLastName;
        public string LastName
        {
            get{ return mLastName; }
            set{ mLastName = value;}
        }

        private bool mIsManager;
        public bool IsManager
        {
            get{ return mIsManager; }
            set{ mIsManager = value;}
        }

        private decimal mHourlyRate;
        public decimal HourlyRate
        {
            get{ return mHourlyRate; }
            set{ mHourlyRate = value;}
        }

        private string mPhoneNumber;
        public string PhoneNumber
        {
            get{ return mPhoneNumber; }
            set{ mPhoneNumber = value;}
        }

        private DateTime mStartDate;
        public DateTime StartDate
        {
            get{ return mStartDate; }
            set{ mStartDate = value;}
        }


        //find method. Takes a staff number, and pulls data from database table that matches the staff number.
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
                mStaffNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNumber"]);
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

        //Takes the fields that needs validating, returns an error message or an empty string.
        public string Valid(string FirstName, string LastName, string StartDate, string PhoneNumber, string HourlyRate)
        {
            string Error = "";

            ////First Name////

            //First Name too short
            if (FirstName.Length < 1)
            {
                Error = Error + "First name too short, ";
            }

            //First name too long
            if(FirstName.Length > 50)
            {
                Error = Error + "First name too long, ";
            }

            char[] name = FirstName.ToCharArray();

            for (int i = 0; i != name.Length ; i++){
                if(name[i] == '0' || 
                   name[i] == '1' || 
                   name[i] == '2' || 
                   name[i] == '3' || 
                   name[i] == '4' || 
                   name[i] == '5' || 
                   name[i] == '6' || 
                   name[i] == '7' || 
                   name[i] == '8' || 
                   name[i] == '9'){
                    Error = Error + "First name contains number, "; break; }
            }

            ////Last Name////

            if (LastName.Length < 1)
            {
                Error = Error + "Last name too short, ";
            }

            //Last name too long
            if (LastName.Length > 50)
            {
                Error = Error + "Last name too long, ";
            }

            name = LastName.ToCharArray();

            for (int i = 0; i != name.Length; i++)
            {
                if(name[i] == '0' ||
                   name[i] == '1' ||
                   name[i] == '2' ||
                   name[i] == '3' ||
                   name[i] == '4' ||
                   name[i] == '5' ||
                   name[i] == '6' ||
                   name[i] == '7' ||
                   name[i] == '8' ||
                   name[i] == '9') {
                    Error = Error + "Last name contains number, "; break;
                }
            }

            
            ////Start Date////
            





            //Phone Number



            //Hourly Rate





            return Error;
        }
    }
}
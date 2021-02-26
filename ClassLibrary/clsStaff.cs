using System;
using System.Linq;

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

        //Testing validitiy of inputs

        public string ValidName(string name)
        {
            string errorMessage = "";
            if (name.Length < 1)          errorMessage += "Name too short\n";
            if (name.Length > 50)    errorMessage += "Name too long\n";
            if (name.Any(char.IsDigit))   errorMessage += "Name contains a number\n";
            return errorMessage;
        }

        public string ValidStartDate(string date)
        {
            string errorMessage = "";

            string tmp = "1900-01-01";
            DateTime inputDate = DateTime.Parse(tmp);
            tmp = "2015-01-01";
            DateTime minDate = DateTime.Parse(tmp);
            DateTime maxDate = DateTime.Today.AddYears(1);

            try { inputDate = DateTime.Parse(date); }
            catch { errorMessage += "Start date invalid\n"; return errorMessage; }

            if (inputDate.CompareTo(minDate) < 0) errorMessage +=      "Start date too early (must be after 2015-01-01)\n";
            else if (inputDate.CompareTo(maxDate) > 0) errorMessage += "Start date too late (must be no more than one year from today)\n";
            return errorMessage;
        }

        public string ValidPhoneNumber(string phoneNum)
        {
            string errorMessage = "";

            if (phoneNum.Length == 0) { errorMessage += "Phone number missing\n"; return errorMessage; }
            if (phoneNum.Length < 6) errorMessage += "Phone number too short\n";
            else if (phoneNum.Length > 20) errorMessage += "Phone number too long\n";

            if (phoneNum[0] == '+')
            {
                string substring = phoneNum.Substring(1);
                if (substring.All(char.IsDigit) == false) errorMessage += "Phone number contains a symbol other than a leading +\n";
            }
            else
            {
                if (phoneNum.All(char.IsDigit) == false) errorMessage += "Phone number contains a symbol other than a leading +\n";
            }

            return errorMessage;

        }
        public string ValidHourlyRate(string rate)
        {
            string errorMessage = "";

            Decimal hourlyRate = -1;

            try { hourlyRate = Decimal.Parse(rate); }
            catch { errorMessage += "Hourly rate wrong format or too large\n"; return errorMessage; }

            if (hourlyRate < 0) errorMessage += "Hourly rate cannot be negative\n";

            return errorMessage;
        }
       
    }
}
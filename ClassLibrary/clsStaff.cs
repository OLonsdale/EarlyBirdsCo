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
            mStaffNumber = 112233;
            mFirstName = "Barney";
            mLastName = "Calhoun";
            mStartDate = new DateTime(2008,10,10);
            mPhoneNumber = "01724280808";
            mIsManager = true;
            mHourlyRate = 19.02m;
            
            return true;
        }
    }
}
using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mCustomerId;
        private string mName;
        private DateTime mDateOfBirth;
        private string mAddress;
        private string mEmail;
        private bool mIsMember;
        //private string mUserPassword;
        //commented this out for the unused warning. -oliver


        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
             set
            {
                mEmail = value;
            }
        }
        public bool IsMember
        {
            get
            {
                return mIsMember;
            }
            set
            {
                mIsMember = value;
            }
        }
        public string UserPassword { get; set; }

        public bool Find(int CustomerId)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("CustomerId", CustomerId);
            db.Execute("sproc_tblCustomer_FilterByCustomerId");

            if (db.Count == 1)
            {
                mCustomerId = Convert.ToInt32(db.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(db.DataTable.Rows[0]["Name"]);
                mDateOfBirth = Convert.ToDateTime(db.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(db.DataTable.Rows[0]["Address"]);
                mEmail = Convert.ToString(db.DataTable.Rows[0]["Email"]);
                mIsMember = Convert.ToBoolean(db.DataTable.Rows[0]["IsMember"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string Name, string DateOfBirth, string Address, string Email)
        {
            String Error = "";
            DateTime DateTemp;
            DateTime MinDate = new DateTime(1900, 1, 1);
            DateTime MaxDate;
            MaxDate = DateTime.Now.Date;
            MaxDate = MaxDate.AddYears(-13);

            if (Name.Length == 0)
            {
                Error = Error + "Name may not be blank. ";
            }
            if (Name.Length > 50)
            {
                Error = Error + "Name may not be longer than 50 characters. ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DateOfBirth);
                if (DateTemp < MinDate)
                {
                    Error = Error + "The date cannot be earlier than 1/01/1900. ";
                }
                if (DateTemp > MaxDate)
                {
                    Error = Error + "The date cannot be later than today's date minus 13 years. ";
                }
            } catch
            {
                Error = Error + "Invalid date. ";
            }

            if (Address.Length == 0)
            {
                Error = Error + "Address may not be blank. ";
            }
            if (Address.Length > 50)
            {
                Error = Error + "Address may not be longer than 50 characters. ";
            }

            if (Email.Length == 0)
            {
                Error = Error + "Email may not be blank. ";
            }
            if (Email.Length > 50)
            {
                Error = Error + "Email may not be longer than 50 characters. ";
            }

            return Error;
        }
    }
}
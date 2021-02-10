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
        private string mUserPassword;

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

        public bool Find(int customerNo)
        {
            mCustomerId = 21;
            mName = "Gordon Freeman";
            mDateOfBirth = Convert.ToDateTime("21/10/1970");
            mAddress = "109 Black Mesa Street";
            mEmail = "g.freeman@blackmesa.com";
            mIsMember = true;

            return true;
        }
    }
}
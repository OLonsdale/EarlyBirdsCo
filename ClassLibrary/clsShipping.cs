using System;

namespace ClassLibrary
{
    public class clsShipping
    {
        private Int32 mShippingId;
        private String mShippingType;
        private Decimal mPrice;
        private DateTime mDateOfDispatch;
        public Boolean mDispatched;

        public Int32 ShippingId
        {
            get
            {
                return mShippingId;
            }
            set
            {
                mShippingId = value;
            }
        }
        public String ShippingType
        {
            get
            {
                return mShippingType;
            }
            set
            {
                mShippingType = value;
            }
        }
        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public DateTime DateOfDispatch
        {
            get
            {
                return mDateOfDispatch;
            }
            set
            {
                mDateOfDispatch = value;
            }
        }

        public Boolean Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }
        public bool Find(int ShippingId)
        {
            mShippingId = 2;
            mDateOfDispatch = Convert.ToDateTime("20/01/2020");
            mShippingType = "Standard";
            mPrice = 4.99m;
            mDispatched = true;
            return true;
        }

        public string Valid(string dateOfDispatch)
        {
            String Error = "";
            if (dateOfDispatch.Length == 0)
            {
                Error = Error + "The date of dispatch may not be blank";
            }

            return Error;
        }
    }
}
using System;
using System.Linq;

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

            //temporary variable to hold date data
            Nullable<DateTime> DateTemp;
            //store minimum date
            Nullable<DateTime> MinimumDate = Convert.ToDateTime("2015-01-01");

            if (dateOfDispatch.Length == 0)
            {
                //do nothing since NULL values are allowed
                mDispatched = false;
            }
            else
            {
                if (dateOfDispatch.Any(char.IsLetter) == true)
                {
                    Error += "The date is not in a valid format (Day-Month-Year) : ";
                }
                else
                {
                    DateTemp = Convert.ToDateTime(dateOfDispatch);
                    //if date input is in the future
                    if (DateTemp > DateTime.Now.Date)
                    {
                        //record the error
                        Error += "The date cannot be in the future : ";
                    }
                    //if date input is earlier than the minimum date
                    if (DateTemp < MinimumDate)
                    {
                        //record the error
                        Error += "The date must not be earlier than 01-01-2015 : ";
                    }
                }
            }
            return Error; 
        }
    }
}
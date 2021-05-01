using System;
using System.Linq;

namespace ClassLibrary
{
    public class clsShipping
    {
        private Int32 mShippingId;
        private Int32 mTrackingNum;
        private String mShippingType;
        private Decimal mPrice;
        private Nullable<DateTime> mDateOfDispatch;
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

        public Int32 TrackingNum
        {
            get
            {
                return mTrackingNum;
            }
            set
            {
                mTrackingNum = value;
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
        public Nullable<DateTime> DateOfDispatch
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
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the item to search for
            DB.AddParameter("@ShippingId", ShippingId);
            DB.Execute("sproc_tblShipping_FilterByShippingId");
            if (DB.Count == 1)
            {
                mShippingId = Convert.ToInt32(DB.DataTable.Rows[0]["ShippingId"]);
                mShippingType = Convert.ToString(DB.DataTable.Rows[0]["ShippingType"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                if (DB.DataTable.Rows[0]["DateOfDispatch"] == DBNull.Value)
                {
                    //do nothing since NULL values are allowed
                }
                else
                {
                    mDateOfDispatch = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfDispatch"]);
                }
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                return true;
            }
            else
            {
                return false;
            }
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
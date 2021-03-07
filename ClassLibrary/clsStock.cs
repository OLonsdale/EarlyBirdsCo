using System;
using System.Linq;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data members for the properties
        private Int32 mItemId;
        private string mItemName;
        private Decimal mPrice;
        private string mMaterial;
        private Boolean mInStock;
        private DateTime mLastPurchased;
        private Int32 mQuantity;

        //public property for ItemId
        public Int32 ItemId
        {
            get
            {
                //return the private data
                return mItemId;
            }
            set
            {
                //set the private data
                mItemId = value;
            }
        }

        //public property for ItemName
        public string ItemName
        {
            get
            {
                //return the private data
                return mItemName;
            }
            set
            {
                //set the private data
                mItemName = value;
            }
        }

        //public property for Price
        public decimal Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        //public property for Material
        public string Material
        {
            get
            {
                //return the private data
                return mMaterial;
            }
            set
            {
                //set the private data
                mMaterial = value;
            }
        }

        //public property for InStock
        public bool InStock
        {
            get
            {
                //return the private data
                return mInStock;
            }
            set
            {
                //set the private data
                mInStock = value;
            }
        }

        //public property for LastPurchased
        public DateTime LastPurchased
        {
            get
            {
                //return the private data
                return mLastPurchased;
            }
            set
            {
                //set the private data
                mLastPurchased = value;
            }
        }

        //public property for Quantity
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the private data
                mQuantity = value;
            }
        }

        public bool Find(int ItemId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the item to search for
            DB.AddParameter("@ItemId", ItemId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByItemId");
            //if one record is found (should be either one or zero
            if (DB.Count == 1)
            {
                mItemId = Convert.ToInt32(DB.DataTable.Rows[0]["ItemId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mMaterial = Convert.ToString(DB.DataTable.Rows[0]["Material"]);
                mLastPurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["LastPurchased"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                //return that everything worked ok
                return true;
            } else
            {
                return false;
            }
        }

        //Validation

        public string ValidItemName(string itemName)
        {
            //store error message
            String Error = "";

            //if no item name is input
            if (itemName.Length == 0)
            {
                Error += "The item name must not be blank : ";
            }
            //if item name input exceeds 80 characters
            if (itemName.Length > 80)
            {
                Error += "The item name must be less than 80 characters : ";
            }
            return Error;
        }

        public string ValidPrice(string price)
        {
            //store error message
            String Error = "";
            //temporary variable to hold price data
            Decimal PriceTemp = 0;


            //if no price is input
            if (price.Length == 0)
            {
                Error += "The price cannot be blank : ";
            }
            try
            {
                PriceTemp = Decimal.Parse(price);
            }
            catch
            {
                Error += "The price is in invalid format or too large : ";
            }
            //if price input is negative
            if (PriceTemp < 0)
            {
                //record the error
                Error += "The price cannot be negative : ";
            }
            return Error;
        }

        public string ValidMaterial(string material)
        {
            //store error message
            String Error = "";

            //if no material is input
            if (material.Length == 0)
            {
                //record the error
                Error += "The material cannot be blank : ";
            }
            //if material input exceeds 20 characters
            if (material.Length > 20)
            {
                //record the error
                Error += "The material must be less than 20 characters : ";
            }
            //if material input contains any non-alphabetical characters
            if (material.All(char.IsLetter) == false)
            {
                //record the error
                Error += "The material must contain only alphabetical letters : ";
            }
            return Error;
        }


        public string ValidLastPurchased(string lastPurchased)
        {
            //store error message
            String Error = "";
            //temporary variable to hold date data
            DateTime DateTemp;
            //store minimum date
            DateTime MinimumDate = Convert.ToDateTime("2015-01-01");

            if (lastPurchased.Length == 0)
            {
                //do nothing since NULL values are allowed
            }
            try
            {
                DateTemp = Convert.ToDateTime(lastPurchased);
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
            catch
            {
                //record the error
                Error += "The date is not a valid date : ";
            }
            return Error;
        }

           /* 
            try
            {
                DateTemp = Convert.ToDateTime(lastPurchased);
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
            catch
            {
                //record the error
                Error += "The date is not a valid date : ";
            }
            try
            {
                DateTime DateInput = Convert.ToDateTime(lastPurchased);
            }
            catch
            {
                //record the error
                Error += "The date is not in a valid format (Day-Month-Year) : ";
            }    
            return Error;
        } */


        public string ValidQuantity(string quantity)
        {
            //store error message
            String Error = "";
            //temporary variable to store quantity data
            Int32 QuantityTemp;

            //if no quantity is input
            if (quantity.Length == 0)
            {
                //record the error
                Error += "The quantity cannot be left blank : ";
            }
            //if any non-integer value(s) are input
            if (quantity.All(char.IsDigit) == false)
            {
                //record the error
                Error += "The quantity must be an integer : ";
            }
            try
            {
                QuantityTemp = Int32.Parse(quantity);
            }
            catch
            {
                //record the error
                Error += "The quantity is in invalid format or too large : ";
            }
            return Error;
        }


        public bool Valid(string itemName, string price, string material, string lastPurchased, string quantity)
        {
            //string variable to store the error
            String Error = "";

            //concatenate any appropariate errors to the Error message
            Error += ValidItemName(itemName);
            Error += ValidPrice(price);
            Error += ValidMaterial(material);
            Error += ValidLastPurchased(lastPurchased);
            Error += ValidQuantity(quantity);

            if (Error == "")
            {
                return true;
            }
            return false;
        } 
    }
}
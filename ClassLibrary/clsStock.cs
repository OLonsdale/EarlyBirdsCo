using System;
using System.Linq;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data members for the properties
        private Int32 mItemId;
        private string mItemName;
        private Double mPrice;
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
        public double Price
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
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
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

        public string Valid(string itemName, string price, string material, string lastPurchased, string quantity)
        {
            //create a string variable to store the error
            String Error = "";
            //create temporary variable to store date values
            DateTime DateTemp;
            //create temporary variable to store price values
            Decimal PriceTemp = -1;
            //create temporary variable to store quantity values
            Int32 QuantityTemp;

            //if the ItemName is blank
            if (itemName.Length == 0)
            {
                //record the error
                Error += "The item name may not be blank : ";
            }
            if (itemName.Length > 80)
            {
                //record the error
                Error += "The item name must be less than 80 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(lastPurchased);
                //if the DateTemp is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error += "The date cannot be in the future : ";
                }
                //ADD MORE CONDITIONS FOR LASTPURCHASED TESTS
            }
            catch
            {
                //record the error
                Error += "The date was not a valid date : ";
            }
            if (price.Length == 0)
            {
                //record the error
                Error += "The price cannot be blank : ";
            }
            try
            {
                PriceTemp = Decimal.Parse(price);
            }
            catch
            {
                Error += "The price is invalid or too large : ";
            }

            if (PriceTemp < 0)
            {
                //record the error
                Error += "The price cannot be negative : ";
            }
            if (material.Length == 0)
            {
                //record the error
                Error += "The material cannot be blank : ";
            }
            if (material.Length > 20)
            {
                //record the error
                Error += "The material must be less than 20 characters : ";
            }
            if (material.Any(char.IsDigit)) 
            {
                //record the error
                Error += "The material cannot contain any numbers : ";

            }     
            if (quantity.Length == 0)
            {
                //record the error
                Error += "The quantity cannot be left blank : ";
            }
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
                Error += "The quantity is too high (cannot exceed the Max Value of an Integer) : ";
            }
            //return any appropraite error messages
            return Error;
        }
    }
}
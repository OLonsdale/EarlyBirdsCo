using System;

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

        public string Valid(string ItemName,
                            string Price,
                            string Material,
                            string LastPurchased,
                            string Quantity)
        {
            return "";
        }
    }
}
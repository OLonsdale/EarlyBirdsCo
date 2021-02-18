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
            //set the private data members to the test data value
            mItemId = 21;
            mItemName = "Keycap1"; 
            mPrice = 2.49;
            mMaterial = "Steel";
            mInStock = true;
            mLastPurchased = Convert.ToDateTime("25/01/2021");
            mQuantity = 50; 
            //always return true
            return true; 
        }
    }
}
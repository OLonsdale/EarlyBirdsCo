using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private string mOrderId;
        public string OrderId {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }

        private DateTime mDateFinalised;
        public DateTime DateFinalised {
            get
            {
                return mDateFinalised;
            }
            set
            {
                mDateFinalised = value;
            }
        }

        private string mItemId;
        public string ItemId {
            get
            {
                return mItemId;
            }
            set
            {
                mItemId = value;
            }
        }

        private int mQuantity;
        public int Quantity {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        private double mTotalPrice;
        public double TotalPrice {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }

        private bool mIsEmpty;
        public bool IsEmpty {
            get
            {
                return mIsEmpty;
            }
            set
            {
                mIsEmpty = value;
            }
        }

        public bool Find(String OrderId)
        {
            mOrderId = "Find123";
            mDateFinalised = Convert.ToDateTime("11/02/2021");
            mItemId = "Item1234";
            mQuantity = 3;
            mTotalPrice = 6.97;
            mIsEmpty = false;
            return true;
        }
    }
}
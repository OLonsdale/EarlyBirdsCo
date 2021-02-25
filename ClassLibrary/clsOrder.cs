using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderId;
        public int OrderId {
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

        private String mItemId;
        public String ItemId {
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

        public bool Find(int OrderNum)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNum", OrderNum);
            DB.Execute("sproc_tblOrder_FilterByOrderId");

            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNum"]);
                mDateFinalised = Convert.ToDateTime(DB.DataTable.Rows[0]["DateFinalised"]);
                mItemId = Convert.ToString(DB.DataTable.Rows[0]["ItemId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
                mIsEmpty = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEmpty"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
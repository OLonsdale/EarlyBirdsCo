using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderNum;
        public int OrderNum {
            get
            {
                return mOrderNum;
            }
            set
            {
                mOrderNum = value;
            }
        }

        private int mCustomerNum;
        public int CustomerNum
        {
            get
            {
                return mCustomerNum;
            }
            set
            {
                mCustomerNum = value;
            }
        }

        private int mItemNum;
        public int ItemNum
        {
            get
            {
                return mItemNum;
            }
            set
            {
                mItemNum = value;
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

        private String mStandaloneOrSet;
        public String StandaloneOrSet
        {
            get
            {
                return mStandaloneOrSet;
            }
            set
            {
                mStandaloneOrSet = value;
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

        private bool mReadyForShipping;
        public bool ReadyForShipping {
            get
            {
                return mReadyForShipping;
            }
            set
            {
                mReadyForShipping = value;
            }
        }

        public bool Find(int OrderNum)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNum", OrderNum);
            DB.Execute("sproc_tblOrder_FilterByOrderNum");

            if (DB.Count == 1)
            {
                mOrderNum = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNum"]);
                mCustomerNum = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNum"]);
                mItemNum = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNum"]);
                mDateFinalised = Convert.ToDateTime(DB.DataTable.Rows[0]["DateFinalised"]);
                mStandaloneOrSet = Convert.ToString(DB.DataTable.Rows[0]["StandaloneOrSet"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
                mReadyForShipping = Convert.ToBoolean(DB.DataTable.Rows[0]["ReadyForShipping"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string customerNum, string itemNum, string dateFinalised, string standaloneOrSet, string quantity, string totalPrice)
        {
            String Error = "";
            try
            {
                int TempCustomerNum = Int32.Parse(customerNum);
                if (TempCustomerNum < 1)
                {
                    Error += "The Customer Number cannot be less than 1 : ";
                }
                // clsCustomer AnCustomer = new clsCustomer();
                //if (!AnCustomer.Find(TempCustomerNum))
                if (TempCustomerNum > 10)
                {
                    Error += "The Customer Number must be in the database : ";
                }
            } 
            catch
            {
                Error += "The Customer Number was not a valid int : ";
            }

            try
            {
                int TempItemNum = Int32.Parse(itemNum);
                if (TempItemNum < 1)
                {
                    Error += "The Item Number cannot be less than 1 : ";
                }
                // clsStock AnItem = new clsStock();
                // if (!AnItem.Find(TempItemNum))
                if (TempItemNum > 10)
                {
                    Error += "The Item Number must be in the database : ";
                }
            }
            catch
            {
                Error += "The Item Number was not a valid int : ";
            }

            try
            {
                DateTime TempDateFinalised = Convert.ToDateTime(dateFinalised);
                if (TempDateFinalised < DateTime.Now.Date)
                {
                    Error += "The Date cannot be in the past : ";
                }
                if (TempDateFinalised > DateTime.Now.Date)
                {
                    Error += "The Date cannot be in the future : ";
                }
            }
            catch
            {
                Error += "The Date was not a valid Date : ";
            }

            if (standaloneOrSet == null)
            {
                Error += "The Standalone or Set cannot be empty";
            }
            if (standaloneOrSet != "Standalone" && standaloneOrSet != "Set")
            {
                Error += "Standalone or Set must be set to either \"Standalone\" or \"Set\"";
            }

            try
            {
                int TempQuantity = Int32.Parse(quantity);
                if (TempQuantity < 1)
                {
                    Error += "The Quantity cannot be less than 1 : ";
                }
                // clsStock AnItem = new clsStock();
                // int TempItemNum = Int32.Parse(itemNum);
                // AnItem.Find(TempItemNum);
                // Int32 StockQuantity = AnItem.Quantity;
                if (TempQuantity > 10)
                {
                    Error += "The Quantity must not exceed the stocks quantity : ";
                }
            }
            catch
            {
                Error += "The Quantity was not a valid Int : ";
            }

            try
            {
                double TempTotalPrice = Double.Parse(totalPrice);
                if (TempTotalPrice <= 0)
                {
                    Error += "The Total Price must be a positive Double : ";
                }
                if (TempTotalPrice > 1000)
                {
                    Error += "The Total Price must not exceed £1000 : ";
                }
            }
            catch
            {
                Error += "The Total Price was not a valid Double : ";
            }

            return Error;
        }
    }
}
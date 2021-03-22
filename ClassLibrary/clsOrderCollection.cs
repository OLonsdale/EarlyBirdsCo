using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNum", mThisOrder.CustomerNum);
            DB.AddParameter("@ItemNum", mThisOrder.ItemNum);
            DB.AddParameter("@DateFinalised", mThisOrder.DateFinalised);
            DB.AddParameter("@StandaloneOrSet", mThisOrder.StandaloneOrSet);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@ReadyForShipping", mThisOrder.ReadyForShipping);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNum", mThisOrder.OrderNum);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNum", mThisOrder.OrderNum);
            DB.AddParameter("@CustomerNum", mThisOrder.CustomerNum);
            DB.AddParameter("@ItemNum", mThisOrder.ItemNum);
            DB.AddParameter("@DateFinalised", mThisOrder.DateFinalised);
            DB.AddParameter("@StandaloneOrSet", mThisOrder.StandaloneOrSet);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@ReadyForShipping", mThisOrder.ReadyForShipping);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByKeyType(string KeyType)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@KeyType", KeyType);
            DB.Execute("sproc_tblOrder_FilterByKeyType");
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNum = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNum"]);
                AnOrder.CustomerNum = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNum"]);
                AnOrder.ItemNum = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemNum"]);
                AnOrder.DateFinalised = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateFinalised"]);
                AnOrder.StandaloneOrSet = Convert.ToString(DB.DataTable.Rows[Index]["StandaloneOrSet"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.ReadyForShipping = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReadyForShipping"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}
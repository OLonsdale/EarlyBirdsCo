using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        {
            int Index = 0;
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
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

        List<clsOrder> mOrderList = new List<clsOrder>();

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

        public clsOrder ThisOrder { get; set; }
        
    }
}
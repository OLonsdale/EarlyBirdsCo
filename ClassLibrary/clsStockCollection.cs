using System;
using System.Collections.Generic;
using ClassLibrary;

namespace Testing5
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //executed stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank item
                clsStock AnItem = new clsStock();
                //read in the fields from current record
                AnItem.ItemId = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemId"]);
                AnItem.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AnItem.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnItem.Material = Convert.ToString(DB.DataTable.Rows[Index]["Material"]);
                AnItem.LastPurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastPurchased"]);
                AnItem.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnItem.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add record to private data member
                mStockList.Add(AnItem);
                //point at next record
                Index++;
            }
        }

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisItem = new clsStock();

        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return private data
                return mStockList;
            }
            set
            {
                //set private data
                mStockList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //do later
            }
        }
        
        //public property for an item
        public clsStock ThisItem
        {
            get
            {
                return mThisItem;
            }
            set
            {
                mThisItem = value;
            }
        } 
    }
}
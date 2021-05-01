using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisItem = new clsStock();

        //constructor
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //executed stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the database      
            PopulateArray(DB);          
        }

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
                
            }
        }

        //public property for an item
        public clsStock ThisItem
        {
            get
            {
                //return private data
                return mThisItem;
            }
            set
            {
                //set private data
                mThisItem = value;
            }
        }


        public int Add()
        {
            //add new record basedon values of mThisItem
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@ItemName", mThisItem.ItemName);
            DB.AddParameter("@Price", mThisItem.Price);
            DB.AddParameter("@Material", mThisItem.Material);
            if (mThisItem.LastPurchased == null)
            {
                DB.AddParameter("@LastPurchased", DBNull.Value);
            }
            else
            {
                DB.AddParameter("@LastPurchased", mThisItem.LastPurchased);
            }
            DB.AddParameter("@Quantity", mThisItem.Quantity);
            DB.AddParameter("@InStock", mThisItem.InStock);
            //execute query returning primary key
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update existing record based on values of ThisItem
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@ItemId", mThisItem.ItemId);
            DB.AddParameter("@ItemName", mThisItem.ItemName);
            DB.AddParameter("@Price", mThisItem.Price);
            DB.AddParameter("@Material", mThisItem.Material);
            if (mThisItem.LastPurchased == null)
            {
                DB.AddParameter("@LastPurchased", DBNull.Value);
            }
            else
            {
                DB.AddParameter("@LastPurchased", mThisItem.LastPurchased);
            }
            DB.AddParameter("@Quantity", mThisItem.Quantity);
            DB.AddParameter("@InStock", mThisItem.InStock);
            //execute stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@ItemId", mThisItem.ItemId);
            //execute stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ClearFilter()
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate array with data table
            PopulateArray(DB);
        }

        public void ReportByAvailability(bool InStock)
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the InStocketer to the database
            DB.AddParameter("@InStock", InStock);
            //execute stored procedure
            DB.Execute("sproc_tblStock_FilterByAvailability");
            //populate array with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //ppopulates array based on the data table in parameter DB
            //index
            Int32 Index = 0;
            //store record count
            Int32 RecordCount;
            //get count of records
            RecordCount = DB.Count;
            //clear private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank item
                clsStock AnItem = new clsStock();
                //read in fields from current record
                AnItem.ItemId = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemId"]);
                AnItem.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AnItem.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnItem.Material = Convert.ToString(DB.DataTable.Rows[Index]["Material"]);
                if (AnItem.LastPurchased == null)
                {
                    AnItem.LastPurchased = null;
                }
                else
                {
                    AnItem.LastPurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastPurchased"]);
                }
                AnItem.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnItem.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add record to private data member
                mStockList.Add(AnItem);
                //point at next record
                Index++;
            }
        }
    }
}
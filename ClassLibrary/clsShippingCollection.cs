using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsShippingCollection
    {
        //private data members for the list
        List<clsShipping> mShipmentList = new List<clsShipping>();
        clsShipping mThisShipment = new clsShipping();


        public clsShippingCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblShipping_SelectAll");
            PopulateArray(DB);   
        }

        public List<clsShipping> ShippingList
        {
            get
            {
                return mShipmentList;
            }
            set
            {
                mShipmentList = value;
            }
        }
        public int Count
        {
            get
            {
                return mShipmentList.Count;
            }
            set
            {
                //later
            }
        }
        public clsShipping ThisShipment
        {
            get
            {
                return mThisShipment;
            }
            set
            {
                mThisShipment = value;
            } 
         } 

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@ShippingType", mThisShipment.ShippingType);
            DB.AddParameter("@Price", mThisShipment.Price);
            if (mThisShipment.DateOfDispatch == null)
            {
                DB.AddParameter("@DateOfDispatch", DBNull.Value);
            }
            else
            {
                DB.AddParameter("@DateOfDispatch", mThisShipment.DateOfDispatch);
            }
            DB.AddParameter("@Dispatched", mThisShipment.Dispatched);
            //execute query returning primary key
            return DB.Execute("sproc_tblShipping_Insert");
        }

        public void Update()
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@ShippingId", mThisShipment.ShippingId);
            DB.AddParameter("@ShippingType", mThisShipment.ShippingType);
            DB.AddParameter("@Price", mThisShipment.Price);
            if (mThisShipment.DateOfDispatch == null)
            {
                DB.AddParameter("@DateOfDispatch", DBNull.Value);
            }
            else
            {
                DB.AddParameter("@DateOfDispatch", mThisShipment.DateOfDispatch);
            }
            DB.AddParameter("@Dispatched", mThisShipment.Dispatched);
            //execute stored procedure
            DB.Execute("sproc_tblShipping_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@ShippingId", mThisShipment.ShippingId);
            //execute stored procedure
            DB.Execute("sproc_tblShipping_Delete");
        }

        public void ReportByDispatchedTrue()
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send Dispatched to the database
            DB.AddParameter("@Dispatched", mThisShipment.Dispatched);
            //execute stored procedure
            DB.Execute("sproc_tblShipping_FilterByDispatchedTrue");
            //populate array with data table
            PopulateArray(DB);
        }

        public void ClearFilter()
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblShipping_SelectAll");
            //populate array with data table
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            //ppopulates array based on the data table in parameter DB
            //index
            Int32 Index = 0;
            //store record count
            Int32 RecordCount;
            //get count of records
            RecordCount = DB.Count;
            //clear private array list
            mShipmentList = new List<clsShipping>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank item
                clsShipping AShipment = new clsShipping();
                //read in fields from current record
                AShipment.ShippingId = Convert.ToInt32(DB.DataTable.Rows[Index]["ShippingId"]);
                AShipment.ShippingType = Convert.ToString(DB.DataTable.Rows[Index]["ShippingType"]);
                AShipment.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                if (AShipment.DateOfDispatch == null)
                {
                    AShipment.DateOfDispatch = null;
                }
                else
                {
                    AShipment.DateOfDispatch = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfDispatch"]);
                }
                AShipment.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                //add record to private data member
                mShipmentList.Add(AShipment);
                //point at next record
                Index++;
            }
        }
    }
}

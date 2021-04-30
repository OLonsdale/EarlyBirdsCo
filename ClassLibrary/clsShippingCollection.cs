using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsShippingCollection
    {

        public clsShippingCollection()
        {
            clsShipping TestShipment = new clsShipping();
            TestShipment.ShippingId = 1;
            TestShipment.ShippingType = "Standard";
            TestShipment.Price = 4.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            mShipmentList.Add(TestShipment);
            //object 2
            TestShipment = new clsShipping();
            TestShipment.ShippingId = 2;
            TestShipment.ShippingType = "Express";
            TestShipment.Price = 7.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            mShipmentList.Add(TestShipment);

            /*
              Int32 Index = 0;
              Int32 RecordCount = 0;
              clsDataConnection DB = new clsDataConnection();
              DB.Execute("sproc_tblShipping_SelectAll");
              RecordCount = DB.Count;
              while (Index < RecordCount) 
              {
                    clsShipping AShipment = new clsShipping();
                    AShipment.ShippingId = Convert.ToInt32(DB.DataTable.Rows[Index]["ShippingId"]);
                    AShipment.ShippingType = Convert.ToString(DB.DataTable.Rows[Index]["ShippingType"]);
                    AShipment.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                    AShipment.DateOfDispatch = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfDispatch"]);
                    AShipment.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                    mShipmentList.Add(AShipment);
                    Index++;
              }    
              */
        }

        //private data members for the list
        List<clsShipping> mShipmentList = new List<clsShipping>();

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

        public clsShipping ThisShipment { get; set; }
    }
}

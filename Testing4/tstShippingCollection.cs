using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstShippingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            Assert.IsNotNull(AllShipments);
        }

        [TestMethod]
        public void ShippingListOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create test data in the form of a list of objects to assign to the property
            List<clsShipping> TestList = new List<clsShipping>();
            clsShipping TestShipment = new clsShipping();
            TestShipment.ShippingId = 1;
            TestShipment.ShippingType = "Standard";
            TestShipment.Price = 4.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            TestList.Add(TestShipment);
            AllShipments.ShippingList = TestList;
            Assert.AreEqual(AllShipments.ShippingList, TestList);
        }

        [TestMethod]
        public void ThisShipmentPropertyOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create test data in the form of a list of objects to assign to the property
            clsShipping TestShipment = new clsShipping();
            TestShipment.ShippingId = 1;
            TestShipment.ShippingType = "Standard";
            TestShipment.Price = 4.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            AllShipments.ThisShipment = TestShipment;
            Assert.AreEqual(AllShipments.ThisShipment, TestShipment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create test data in the form of a list of objects to assign to the property
            List<clsShipping> TestList = new List<clsShipping>();
            clsShipping TestShipment = new clsShipping();
            TestShipment.ShippingId = 1;
            TestShipment.ShippingType = "Standard";
            TestShipment.Price = 4.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            TestList.Add(TestShipment);
            AllShipments.ShippingList = TestList;
            Assert.AreEqual(AllShipments.Count, TestList.Count);
        }

        [TestMethod]
        public void AddPropertyOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create item of test data
            clsShipping TestShipment = new clsShipping();
            //store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestShipment.ShippingId = 1;
            TestShipment.ShippingType = "Standard";
            TestShipment.Price = 4.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            //set ThisItem to test data
            AllShipments.ThisShipment = TestShipment;
            //add record
            PrimaryKey = AllShipments.Add();
            //set primary key of test data
            TestShipment.ShippingId = PrimaryKey;
            //find record
            AllShipments.ThisShipment.Find(PrimaryKey);
            //test to see values are same
            Assert.AreEqual(AllShipments.ThisShipment, TestShipment);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create item of test data
            clsShipping TestShipment = new clsShipping();
            //store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestShipment.ShippingType = "Standard";
            TestShipment.Price = 4.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            //set ThisItem to test data
            AllShipments.ThisShipment = TestShipment;
            //add record
            PrimaryKey = AllShipments.Add();
            //set primary key of test data
            TestShipment.ShippingId = PrimaryKey;
            //modify test data
            TestShipment.ShippingType = "Express";
            TestShipment.Price = 7.99m;
            TestShipment.DateOfDispatch = Convert.ToDateTime("2021-04-27");
            TestShipment.Dispatched = true;
            //set record based on new test data
            AllShipments.ThisShipment = TestShipment;
            //update record
            AllShipments.Update();
            //find record
            AllShipments.ThisShipment.Find(PrimaryKey);
            //test to see ThisItem matches test data
            Assert.AreEqual(AllShipments.ThisShipment, TestShipment);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create item of test data
            clsShipping TestShipment = new clsShipping();
            //store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestShipment.ShippingType = "Standard";
            TestShipment.Price = 4.99m;
            TestShipment.DateOfDispatch = DateTime.Now.Date;
            TestShipment.Dispatched = true;
            //set ThisItem to test data
            AllShipments.ThisShipment = TestShipment;
            //add record
            PrimaryKey = AllShipments.Add();
            //set primary key of test data
            TestShipment.ShippingId = PrimaryKey;
            //find record
            AllShipments.ThisShipment.Find(PrimaryKey);
            //delete record
            AllShipments.Delete();
            //find record now
            Boolean Found = AllShipments.ThisShipment.Find(PrimaryKey);
            //test to see record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDispatchStatusOK()
        {
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create an instance of filtered data
            clsShippingCollection FilteredShipments = new clsShippingCollection();
            //apply true value (will be different from original list)
            FilteredShipments.ReportByDispatchedTrue();
            //test to see two values are not the same
            Assert.AreNotEqual(AllShipments.Count, FilteredShipments.Count);
        }
    }
}

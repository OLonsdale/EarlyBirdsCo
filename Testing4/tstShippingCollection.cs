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
    }
}

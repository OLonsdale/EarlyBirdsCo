using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsShipping AShipment = new clsShipping();
            Assert.IsNotNull(AShipment);
        }

        [TestMethod]
        public void DispatchedPropertyOK()
        {
            clsShipping AShipment = new clsShipping();
            Boolean TestData = true;
            AShipment.Dispatched = TestData;
            Assert.AreEqual(AShipment.Dispatched, TestData);
        }

        [TestMethod]
        public void DateOfDispatchPropertyOK()
        {
            clsShipping AShipment = new clsShipping();
            DateTime TestData = new DateTime(2021, 1, 15);
            AShipment.DateOfDispatch = TestData;
            Assert.AreEqual(AShipment.DateOfDispatch, TestData);
        }

        [TestMethod]
        public void ShippingIdPropertyOK()
        {
            clsShipping AShipment = new clsShipping();
            int TestData = 1;
            AShipment.ShippingId = TestData;
            Assert.AreEqual(AShipment.ShippingId, TestData);
        }

        [TestMethod]
        public void ShippingPricePropertyOK()
        {
            clsShipping AShipment = new clsShipping();
            decimal TestData = 5.75m; //the m = a decimal.
            AShipment.Price = TestData;
            Assert.AreEqual(AShipment.Price, TestData);
        }

        [TestMethod]
        public void ShippingTypePropertyOK()
        {
            clsShipping AShipment = new clsShipping();
            string TestData = "Standard";
            AShipment.ShippingType = TestData;
            Assert.AreEqual(AShipment.ShippingType, TestData);
        }
    }
}

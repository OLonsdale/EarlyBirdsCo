using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstShipping
    {
        string ShippingType = "Standard";
        string Price = "4.99";
        string DateOfDispatch = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void FindOK()
        {
            clsShipping AShipment = new clsShipping();
            Boolean Found = false;
            int ShippingId = 2;
            Found = AShipment.Find(ShippingId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestShippingIdFound()
        {
            clsShipping AShipment = new clsShipping();
            Boolean Found = false;
            Boolean OK = true;
            int ShippingId = 2;
            Found = AShipment.Find(ShippingId);
            if (AShipment.ShippingId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfDispatchFound()
        {
            clsShipping AShipment = new clsShipping();
            Boolean Found = false;
            Boolean OK = true;
            int ShippingId = 2;
            Found = AShipment.Find(ShippingId);
            if (AShipment.DateOfDispatch != Convert.ToDateTime("20/01/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingTypeFound()
        {
            clsShipping AShipment = new clsShipping();
            Boolean Found = false;
            Boolean OK = true;
            int ShippingId = 2;
            Found = AShipment.Find(ShippingId);
            if (AShipment.ShippingType != "Standard")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsShipping AShipment = new clsShipping();
            Boolean Found = false;
            Boolean OK = true;
            int ShippingId = 2;
            Found = AShipment.Find(ShippingId);
            if (AShipment.Price != 4.99m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDispatchedFound()
        {
            clsShipping AShipment = new clsShipping();
            Boolean Found = false;
            Boolean OK = true;
            int ShippingId = 2;
            Found = AShipment.Find(ShippingId);
            if (AShipment.Dispatched != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            Error = AShipment.Valid(ShippingType, Price, DateOfDispatch);
            Assert.AreEqual(Error, "");
        }
    }

   
}

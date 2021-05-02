using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstShipping
    {
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
            int ShippingId = 5;
            Found = AShipment.Find(ShippingId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestShippingIdFound()
        {
            clsShipping AShipment = new clsShipping();
            Boolean Found = false;
            Boolean OK = true;
            int ShippingId = 5;
            Found = AShipment.Find(ShippingId);
            if (AShipment.ShippingId != 5)
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
            int ShippingId = 8;
            Found = AShipment.Find(ShippingId);
            if (AShipment.DateOfDispatch != Convert.ToDateTime("20/04/2021"))
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
            int ShippingId = 5;
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
            int ShippingId = 5;
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
            int ShippingId = 8;
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
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateOfDispatchMinLessOne()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //store the minimum date
            DateTime MinimumDate = Convert.ToDateTime("2015-01-01");
            //set date to MinimumDate subtract 1 day
            String DateOfDispatch = MinimumDate.AddDays(-1).ToString();
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void DateOfDispatchMinPlusOne()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //store the minimum date
            DateTime MinimumDate = Convert.ToDateTime("2015-01-01");
            //set date to MinimumDate plus 1 day.
            String DateOfDispatch = MinimumDate.AddDays(1).ToString();
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreEqual(Error, ""); //should pass           
        }

        [TestMethod]
        public void DateOfDispatchMaxLessOne()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to yesterday's date
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string
            String DateOfDispatch = TestDate.ToString();
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void DateOfDispatchMax()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //convert the date to a string
            String DateOfDispatch = TestDate.ToString();
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void DateOfDispatchMid()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //set the date to a bit in the past
            TestDate = TestDate.AddYears(-5);
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void DateOfDispatchMaxPlusOne()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to tomorrow's date
            TestDate = TestDate.AddDays(1);
            //convert the date to a string
            String DateOfDispatch = TestDate.ToString();
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void DateOfDispatchExtremeMax()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to + 100 years
            TestDate = TestDate.AddDays(100);
            //convert the date to a string
            String DateOfDispatch = TestDate.ToString();
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void DateOfDispatchExtremeMin()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to - 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string
            String DateOfDispatch = TestDate.ToString();
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void DateOfDispatchInvalidData()
        {
            clsShipping AShipment = new clsShipping();
            String Error = "";
            //set the DateOfDispatch to a non date value
            String DateOfDispatch = "invalid input";
            Error = AShipment.Valid(DateOfDispatch);
            Assert.AreNotEqual(Error, ""); //should fail
        }
    }
}


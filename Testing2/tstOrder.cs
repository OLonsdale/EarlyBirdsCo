using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {

        String CustomerNum = "5";
        String ItemNum = "3";
        String DateFinalised = DateTime.Now.Date.ToString();
        String StandaloneOrSet = "Standalone";
        String Quantity = "5";
        String TotalPrice = "7.95";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
            
        }

        [TestMethod]
        public void OrderNumOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 3;
            AnOrder.OrderNum = TestData;
            Assert.AreEqual(AnOrder.OrderNum, TestData);
        }

        [TestMethod]
        public void CustomerNumOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 4;
            AnOrder.CustomerNum = TestData;
            Assert.AreEqual(AnOrder.CustomerNum, TestData);
        }

        [TestMethod]
        public void ItemNumOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.ItemNum = TestData;
            Assert.AreEqual(AnOrder.ItemNum, TestData);
        }

        [TestMethod]
        public void DateFinalisedOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateFinalised = TestData;
            Assert.AreEqual(AnOrder.DateFinalised, TestData);

        }

        [TestMethod]
        public void StandaloneOrSetOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Standalone";
            AnOrder.StandaloneOrSet = TestData;
            Assert.AreEqual(AnOrder.StandaloneOrSet, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 2;
            AnOrder.Quantity = TestData;
            Assert.AreEqual(AnOrder.Quantity, TestData);

        }

        [TestMethod]
        public void TotalPriceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Double TestData = 2.98;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);

        }

        [TestMethod]
        public void ReadyForShippingOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = false;
            AnOrder.ReadyForShipping = TestData;
            Assert.AreEqual(AnOrder.ReadyForShipping, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNumFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.OrderNum != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNumFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.CustomerNum != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNumFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.ItemNum != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateFinalisedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.DateFinalised != Convert.ToDateTime("27/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStandaloneOrSetFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.StandaloneOrSet != "Set")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.Quantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.TotalPrice != 14.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReadyForShippingFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNum = 2;
            Found = AnOrder.Find(OrderNum);
            if (AnOrder.ReadyForShipping != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerNum = "";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumInTable()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerNum = "5";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumNotInTable()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerNum = "45";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerNum = "Incorrect Data-Type";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNumMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ItemNum = "";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNumInTable()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ItemNum = "3";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNumNotInTable()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ItemNum = "45";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNumInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ItemNum = "Incorrect Data-Type";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateFinalisedNow()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string DateFinalised = TestDate.ToString();
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateFinalisedNowMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateFinalised = TestDate.ToString();
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateFinalsiedNowPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateFinalised = TestDate.ToString();
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateFinalisedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-100);
            string DateFinalised = TestDate.ToString();
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateFinalisedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string DateFinalised = TestDate.ToString();
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateFinalisedNullOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DateFinalised = null;
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StandaloneOrSetStandaloneInput()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StandaloneOrSet = "Standalone";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StandaloneOrSetSetInput()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StandaloneOrSet = "Set";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StandaloneOrSetInvalidString()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StandaloneOrSet = "Invalid Input";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StandaloneOrSetNullInput()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StandaloneOrSet = null;
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityValidInt()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Quantity = "5";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Quantity = "0";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Quantity = "11";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinExtreme()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Quantity = "-100";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxExtreme()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Quantity = "100";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidType()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Quantity = "Incorrect Data Type";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceValidInput()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalPrice = "7.98";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinZero()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalPrice = "0";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalPrice = "1001";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalPrice = "-100";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalPrice = "10000";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceInvalidType()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalPrice = "Incorrect Data Type";
            Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

    }
}
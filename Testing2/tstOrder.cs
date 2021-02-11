using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
            
        }

        [TestMethod]
        public void OrderIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "ID121";
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);

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
            Double TestData = 1.98;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);

        }

        [TestMethod]
        public void IsEmptyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.IsEmpty = TestData;
            Assert.AreEqual(AnOrder.IsEmpty, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            String OrderId = "Find123";
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            String OrderId = "Find123";
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != "Find123")
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
            String OrderId = "Find123";
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateFinalised != Convert.ToDateTime("11/02/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            String OrderId = "Find123";
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemId != "Item1234")
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
            String OrderId = "Find123";
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Quantity != 3)
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
            String OrderId = "Find123";
            Found = AnOrder.Find(OrderId);
            if (AnOrder.TotalPrice != 6.97)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsEmptyFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            String OrderId = "Find123";
            Found = AnOrder.Find(OrderId);
            if (AnOrder.IsEmpty != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
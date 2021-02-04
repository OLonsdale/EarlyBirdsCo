using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void instanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
            
        }

        [TestMethod]
        public void OrderIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "ID121";
            AnOrder.orderId = TestData;
            Assert.AreEqual(AnOrder.orderId, TestData);

        }

        [TestMethod]
        public void dateFinalisedOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.dateFinalised = TestData;
            Assert.AreEqual(AnOrder.dateFinalised, TestData);

        }

        [TestMethod]
        public void quantityOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 2;
            AnOrder.quantity = TestData;
            Assert.AreEqual(AnOrder.quantity, TestData);

        }

        [TestMethod]
        public void totalPriceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Double TestData = 1.98;
            AnOrder.totalPrice = TestData;
            Assert.AreEqual(AnOrder.totalPrice, TestData);

        }

        [TestMethod]
        public void isEmptyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.isEmpty = TestData;
            Assert.AreEqual(AnOrder.isEmpty, TestData);

        }
    }
}

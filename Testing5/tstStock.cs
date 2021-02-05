using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnItem = new clsStock();
            Assert.IsNotNull(AnItem);
        }

        [TestMethod]
        public void ItemIdOK()
        {
            clsStock AnItem = new clsStock();
            int TestData = 5;
            AnItem.itemID = TestData;
            Assert.AreEqual(AnItem.itemID, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsStock AnItem = new clsStock();
            double TestData = 5.75;
            AnItem.price = TestData;
            Assert.AreEqual(AnItem.price, TestData);
        }

        [TestMethod]
        public void MaterialOK()
        {
            clsStock AnItem = new clsStock();
            string TestData = "Metal";
            AnItem.material = TestData;
            Assert.AreEqual(AnItem.material, TestData);
        }

        [TestMethod]
        public void inStockOK()
        {
            clsStock AnItem = new clsStock();
            bool TestData = true;
            AnItem.inStock = TestData;
            Assert.AreEqual(AnItem.inStock, TestData);
        }

        [TestMethod]
        public void LastPurchasedOK()
        {
            clsStock AnItem = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AnItem.lastPurchased = TestData;
            Assert.AreEqual(AnItem.lastPurchased, TestData);
        }

        [TestMethod]
        public void quantityOK()
        {
            clsStock AnItem = new clsStock();
            int TestData = 20;
            AnItem.quantity = TestData;
            Assert.AreEqual(AnItem.quantity, TestData);
        }
    }
}

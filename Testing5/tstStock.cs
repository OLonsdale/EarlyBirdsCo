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
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnItem);
        }

        [TestMethod]
        public void ItemIdOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            int TestData = 5;
            //assign the data to the property
            AnItem.ItemId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.ItemId, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            double TestData = 5.75;
            //assign the data to the property
            AnItem.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Price, TestData);
        }

        [TestMethod]
        public void MaterialOK()
        {
            clsStock AnItem = new clsStock();
            string TestData = "Metal";
            AnItem.Material = TestData;
            Assert.AreEqual(AnItem.Material, TestData);
        }

        [TestMethod]
        public void inStockOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AnItem.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.InStock, TestData);
        }

        [TestMethod]
        public void LastPurchasedOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the propety
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the propety
            AnItem.LastPurchased = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.LastPurchased, TestData);
        }

        [TestMethod]
        public void quantityOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the propety
            int TestData = 20;
            //assign the data to the property
            AnItem.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 itemId = 21;
            //invoke the method
            Found = AnItem.Find(itemId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemIdFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.ItemId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.ItemName != "Keycap1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
         
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.Price != 2.49)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMaterialFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.Material != "Steel")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastPurchasedFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.LastPurchased != Convert.ToDateTime("25/01/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.Quantity != 50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        } 
    }
}

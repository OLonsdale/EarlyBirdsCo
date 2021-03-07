using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //test to see it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create test data in the form of a list of objects to assign to the property
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ItemId = 1;
            TestItem.ItemName = "Keycap";
            TestItem.Price = 12.75m;
            TestItem.Material = "Metal";
            TestItem.LastPurchased = DateTime.Now.Date;
            TestItem.Quantity = 15;
            TestItem.InStock = true;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to the property
            AllStock.StockList = TestList;
            //test to see values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create test data to assign to property
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ItemId = 1;
            TestItem.ItemName = "Keycap";
            TestItem.Price = 12.75m;
            TestItem.Material = "Metal";
            TestItem.LastPurchased = DateTime.Now.Date;
            TestItem.Quantity = 15;
            TestItem.InStock = true;
            //assign data to property
            AllStock.ThisItem = TestItem;
            //test to see values are the same
            Assert.AreEqual(AllStock.ThisItem, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create test data in the form of a list of objects to assign to the property
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ItemId = 1;
            TestItem.ItemName = "Keycap";
            TestItem.Price = 12.75m;
            TestItem.Material = "Metal";
            TestItem.LastPurchased = DateTime.Now.Date;
            TestItem.Quantity = 15;
            TestItem.InStock = true;
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllStock.StockList = TestList;
            //test to see values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
    }
}

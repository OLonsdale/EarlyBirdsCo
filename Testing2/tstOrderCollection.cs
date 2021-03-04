using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNum = 1;
            TestItem.CustomerNum = 5;
            TestItem.ItemNum = 7;
            TestItem.DateFinalised = DateTime.Now.Date;
            TestItem.StandaloneOrSet = "Set";
            TestItem.Quantity = 1;
            TestItem.TotalPrice = 14.99;
            TestItem.ReadyForShipping = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNum = 1;
            TestItem.CustomerNum = 5;
            TestItem.ItemNum = 7;
            TestItem.DateFinalised = DateTime.Now.Date;
            TestItem.StandaloneOrSet = "Set";
            TestItem.Quantity = 1;
            TestItem.TotalPrice = 14.99;
            TestItem.ReadyForShipping = true;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNum = 1;
            TestItem.CustomerNum = 5;
            TestItem.ItemNum = 7;
            TestItem.DateFinalised = DateTime.Now.Date;
            TestItem.StandaloneOrSet = "Set";
            TestItem.Quantity = 1;
            TestItem.TotalPrice = 14.99;
            TestItem.ReadyForShipping = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

    }
}

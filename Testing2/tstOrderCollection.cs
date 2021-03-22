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

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder AnOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            AnOrder.CustomerNum = 5;
            AnOrder.ItemNum = 6;
            AnOrder.DateFinalised = DateTime.Now.Date;
            AnOrder.StandaloneOrSet = "Standalone";
            AnOrder.TotalPrice = 6.98;
            AnOrder.Quantity = 2;
            AnOrder.ReadyForShipping = true;
            AllOrders.ThisOrder = AnOrder;
            PrimaryKey = AllOrders.Add();
            AnOrder.OrderNum = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, AnOrder);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection OrderList = new clsOrderCollection();
            clsOrder AnOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            AnOrder.CustomerNum = 1;
            AnOrder.ItemNum = 1;
            AnOrder.DateFinalised = DateTime.Now.Date;
            AnOrder.StandaloneOrSet = "Standalone";
            AnOrder.TotalPrice = 2.98;
            AnOrder.Quantity = 2;
            AnOrder.ReadyForShipping = true;
            OrderList.ThisOrder = AnOrder;
            PrimaryKey = OrderList.Add();
            AnOrder.OrderNum = PrimaryKey;
            OrderList.ThisOrder.Find(PrimaryKey);
            OrderList.Delete();
            Boolean Found = OrderList.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection OrderList = new clsOrderCollection();
            clsOrder AnOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            AnOrder.CustomerNum = 1;
            AnOrder.ItemNum = 1;
            AnOrder.DateFinalised = DateTime.Now.Date;
            AnOrder.StandaloneOrSet = "Standalone";
            AnOrder.TotalPrice = 2.98;
            AnOrder.Quantity = 2;
            AnOrder.ReadyForShipping = true;
            OrderList.ThisOrder = AnOrder;
            PrimaryKey = OrderList.Add();
            AnOrder.OrderNum = PrimaryKey;
            AnOrder.CustomerNum = 2;
            AnOrder.ItemNum = 4;
            AnOrder.DateFinalised = DateTime.Now.Date;
            AnOrder.StandaloneOrSet = "Set";
            AnOrder.TotalPrice = 5.99;
            AnOrder.Quantity = 1;
            AnOrder.ReadyForShipping = true;
            OrderList.ThisOrder = AnOrder;
            OrderList.Update();
            OrderList.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(OrderList.ThisOrder, AnOrder);
        }

        [TestMethod]
        public void ReportByKeyTypeMethodOK()
        {
            clsOrderCollection OrderList = new clsOrderCollection();
            clsOrderCollection FilteredList = new clsOrderCollection();
            FilteredList.ReportByKeyType("");
            Assert.AreEqual(OrderList.Count, FilteredList.Count);
        }

        [TestMethod]
        public void ReportByKeyTypeNotFound()
        {
            clsOrderCollection FilteredList = new clsOrderCollection();
            FilteredList.ReportByKeyType("Invalid");
            Assert.AreEqual(0, FilteredList.Count);
        }

    }
}

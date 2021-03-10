using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerId = 1;
            TestItem.Name = "Isaac Kleiner";
            TestItem.DateOfBirth = new DateTime(1952, 8, 21);
            TestItem.Address = "17 City Street";
            TestItem.Email = "k.isaac@blackmesa.com";
            TestItem.IsMember = false;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerProperty()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.CustomerId = 1;
            TestCustomer.Name = "Isaac Kleiner";
            TestCustomer.DateOfBirth = new DateTime(1952, 8, 21);
            TestCustomer.Address = "17 City Street";
            TestCustomer.Email = "k.isaac@blackmesa.com";
            TestCustomer.IsMember = false;

            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerId = 1;
            TestItem.Name = "Isaac Kleiner";
            TestItem.DateOfBirth = new DateTime(1952, 8, 21);
            TestItem.Address = "17 City Street";
            TestItem.Email = "k.isaac@blackmesa.com";
            TestItem.IsMember = false;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}

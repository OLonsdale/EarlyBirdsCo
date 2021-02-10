using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Gordon Freeman";
            ACustomer.Name = TestData;
            Assert.AreEqual(ACustomer.Name, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = new DateTime(1999, 2, 11);
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "808 Bass Street, NYC";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "example@mail.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void IsMemberPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            bool TestData = true;
            ACustomer.IsMember = TestData;
            Assert.AreEqual(ACustomer.IsMember, TestData);
        }

        [TestMethod]
        public void UserPasswordPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "verysecurepassword";
            ACustomer.UserPassword = TestData;
            Assert.AreEqual(ACustomer.UserPassword, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.CustomerId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Name != "Gordon Freeman")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("21/10/1970"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Address != "109 Black Mesa Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Email != "g.freeman@blackmesa.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsMemberFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (!ACustomer.IsMember)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        string Name = "Alyx Vance";
        string DateOfBirth = new DateTime(1990, 6, 19).ToString();
        string Address = "17 City Street";
        string Email = "alyx.v@whiteforest.com";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "a";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "";
            Name = Name.PadRight(500, 'a');
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate = new DateTime(1900, 1, 1);
            TestDate = TestDate.AddYears(-100);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate = new DateTime(1900, 1, 1);
            TestDate = TestDate.AddDays(-1);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate = new DateTime(1900, 1, 1);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate = new DateTime(1900, 1, 1);
            TestDate = TestDate.AddDays(1);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-13);
            TestDate = TestDate.AddYears(100);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-13);
            TestDate = TestDate.AddDays(-1);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-13);
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = new DateTime(1900, 1, 1);
            TestDate = TestDate.AddYears(54); // Just an estimate, no idea how to calculate a mid date
            String DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String DateOfBirth = "this is not a date";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "a";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "aa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(500, 'a');
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "a";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "aa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(500, 'a');
            Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);
            Assert.AreNotEqual(Error, "");
        }
    }
}

using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class
            clsStaff staffMember = new clsStaff();
            //test to see if it exists
            Assert.IsNotNull(staffMember);
        }

        //The format of the below tests is as follows:

        //An instance of clsStaff is created, named staffMember
        //A variable called TestData is created with the approprate data type
        //TestData is assigned to the field that is being tested
        //A check is ran to see if the assignment was sucessful

        [TestMethod]
        public void StaffNumberOK()
        {
            clsStaff staffMember = new clsStaff();
            int TestData = 97423;
            staffMember.StaffNumber = TestData;
            Assert.AreEqual(staffMember.StaffNumber, TestData);
        }

        //Test First Name
        [TestMethod]
        public void FirstNameOK()
        {
            clsStaff staffMember = new clsStaff();
            string TestData = "Oliver";
            staffMember.FirstName = TestData;
            Assert.AreEqual(staffMember.FirstName, TestData);
        }

        //Test Last Name
        [TestMethod]
        public void LastNameOK()
        {
            clsStaff staffMember = new clsStaff();
            string TestData = "Higgins";
            staffMember.LastName = TestData;
            Assert.AreEqual(staffMember.LastName, TestData);
        }

        //Test the Manager flag
        [TestMethod]
        public void isManagerOK()
        {
            clsStaff staffMember = new clsStaff();
            bool TestData = true;
            staffMember.IsManager = TestData;
            Assert.AreEqual(staffMember.IsManager, TestData);
        }

        //Test the hourly rate
        [TestMethod]
        public void HourlyRateOK()
        {
            clsStaff staffMember = new clsStaff();
            decimal TestData = 9.80m;   //the m indicates it's a decimal. Higher level of precision than double, hence it being used for money
            staffMember.HourlyRate = TestData;
            Assert.AreEqual(staffMember.HourlyRate, TestData);
        }

        //Test the start date
        [TestMethod]
        public void StartDateOK()
        {
            clsStaff staffMember = new clsStaff();
            DateTime TestData = DateTime.Now.Date; //setting to todays date is overkill.
            staffMember.StartDate = TestData;
            Assert.AreEqual(staffMember.StartDate, TestData);
        }

        //Test the phone number
        [TestMethod]
        public void PhoneNumberOK()
        {
            clsStaff staffMember = new clsStaff();
            string TestData = "07906069555";
            staffMember.PhoneNumber = TestData;
            Assert.AreEqual(staffMember.PhoneNumber, TestData);

        }


        /// 
        /// some scuffed stuff here
        /// Currently all fake
        /// "searches" for a specific record (that of staff number 112233)
        /// Checks if the data from 112233 has been correctly "loaded"
        /// 

        //General check
        [TestMethod]
        public void FindOK()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            int StaffNumber = 22345;
            Found = staffMember.Find(StaffNumber);
            Assert.IsTrue(Found);
        }

        //Staff Number
        [TestMethod]
        public void TestStaffNumberFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 112233;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.StaffNumber != 112233)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //First name
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 112233;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.FirstName != "Barney")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Last name
        [TestMethod]
        public void TestLastNameFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 112233;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.LastName != "Calhoun")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Manager flag
        [TestMethod]
        public void TestIsManagerFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 112233;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.IsManager != true)
            { 
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Hourly Rate
        [TestMethod]
        public void TestHourlyRateFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 112233;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.HourlyRate != 19.02m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        //Phone Number
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 112233;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.PhoneNumber != "01724280808")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        //Start Date
        [TestMethod]
        public void TestStartDateFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 112233;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.StartDate != Convert.ToDateTime("2008-10-10"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }
}

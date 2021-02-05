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
            staffMember.staffNumber = TestData;
            Assert.AreEqual(staffMember.staffNumber, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            clsStaff staffMember = new clsStaff();
            string TestData = "Oliver";
            staffMember.firstName = TestData;
            Assert.AreEqual(staffMember.firstName, TestData);
        }

        [TestMethod]
        public void SecondNameOK()
        {
            clsStaff staffMember = new clsStaff();
            string TestData = "Higgins";
            staffMember.lastName = TestData;
            Assert.AreEqual(staffMember.lastName, TestData);
        }

        [TestMethod]
        public void isManagerOK()
        {
            clsStaff staffMember = new clsStaff();
            bool TestData = true;
            staffMember.isManager = TestData;
            Assert.AreEqual(staffMember.isManager, TestData);
        }

        [TestMethod]
        public void HourlyRateOK()
        {
            clsStaff staffMember = new clsStaff();
            decimal TestData = 9.80m;   //the m indicates it's a decimal. Higher level of precision than double, hence it being used for money
            staffMember.hourlyRate = TestData;
            Assert.AreEqual(staffMember.hourlyRate, TestData);
        }


        [TestMethod]
        public void StartDateOK()
        {
            clsStaff staffMember = new clsStaff();
            DateTime TestData = DateTime.Now.Date; //setting to todays date is overkill.
            staffMember.startDate = TestData;
            Assert.AreEqual(staffMember.startDate, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            clsStaff staffMember = new clsStaff();
            string TestData = "07906069555";
            staffMember.phoneNumber = TestData;
            Assert.AreEqual(staffMember.phoneNumber, TestData);

        }
    }
}

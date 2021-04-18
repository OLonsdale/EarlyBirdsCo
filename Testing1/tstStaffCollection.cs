using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //Create instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create test list
            List<clsStaff> TestList = new List<clsStaff>();

            //Test Staff Member
            clsStaff TestItem = new clsStaff();
            TestItem.StaffNumber = 10005;
            TestItem.FirstName = "James";
            TestItem.LastName = "Bond";
            TestItem.StartDate = DateTime.Parse("2018-01-01");
            TestItem.PhoneNumber = "07492278399";
            TestItem.HourlyRate = 8.90M;

            //Add test staff member to the test list
            TestList.Add(TestItem);

            //Add test list to collections's list field
            AllStaff.StaffList = TestList;

            //check it worked
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //crate instance
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create test staff member
            clsStaff TestItem = new clsStaff();
            TestItem.StaffNumber = 10005;
            TestItem.FirstName = "James";
            TestItem.LastName = "Bond";
            TestItem.StartDate = DateTime.Parse("2018-01-01");
            TestItem.PhoneNumber = "07492278399";
            TestItem.HourlyRate = 8.90M;

            //set ThisStaff to be the test staff member
            AllStaff.ThisStaff = TestItem;

            //check they match
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create test list
            List<clsStaff> TestList = new List<clsStaff>();

            //Test Staff Member
            clsStaff TestItem = new clsStaff();
            TestItem.StaffNumber = 10005;
            TestItem.FirstName = "James";
            TestItem.LastName = "Bond";
            TestItem.StartDate = DateTime.Parse("2018-01-01");
            TestItem.PhoneNumber = "07492278399";
            TestItem.HourlyRate = 8.90M;

            //Add test staff member to the test list
            TestList.Add(TestItem);

            //Add test list to collections's list field
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            int PrimaryKey = 0;
            TestItem.FirstName = "Add-Method-Test";
            TestItem.LastName = "Testing-Add-Method";
            TestItem.StartDate = DateTime.Parse("2018-01-01");
            TestItem.PhoneNumber = "07492278399";
            TestItem.HourlyRate = 8.90M;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StaffNumber = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    }
}

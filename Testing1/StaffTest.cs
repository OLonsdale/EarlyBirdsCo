using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class StaffTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create a new instance of the class
            clsStaff staffMember = new clsStaff();
            //test to see if it exists:
            Assert.IsNotNull(staffMember);
        }
    }
}

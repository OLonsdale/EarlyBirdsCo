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


        /// Tests searching the database for a given record via the staff number

        //General check
        [TestMethod]
        public void FindOK()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            int StaffNumber = 10005;
            Found = staffMember.Find(StaffNumber);
            Assert.IsTrue(Found);
        }

        //Staff Number (I think this is worthless and should be removed?)
        [TestMethod]
        public void TestStaffNumberFound()
        {
            clsStaff staffMemeber = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffNumber = 10005;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.StaffNumber != 10005)
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
            int StaffNumber = 10005;
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
            int StaffNumber = 10005;
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
            int StaffNumber = 10005;
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
            int StaffNumber = 10005;
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
            int StaffNumber = 10005;
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
            int StaffNumber = 10005;
            Found = staffMemeber.Find(StaffNumber);
            if (staffMemeber.StartDate != Convert.ToDateTime("10/10/2008"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        ////Testing the validation method

        //Valid Data
        string FirstName = "James";
        string LastName = "Bond";
        string StartDate = "2018-01-01";
        string PhoneNumber = "07492278399";
        string HourlyRate = "30";


        [TestMethod]

        public void ValidMethodOK()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            Error += staffMember.ValidName(FirstName);
            Error += staffMember.ValidName(LastName);
            Error += staffMember.ValidHourlyRate(HourlyRate);
            Error += staffMember.ValidPhoneNumber(PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        /// First Name Valid
        /// //////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void FirstNameValidMinMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "";
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void FirstNameValidMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "A";
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void FirstNameValidMinPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "Aa";
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void FirstNameValidMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "Wolfeschlegelsteinhausenbergerdorffwelchevordgjyte";   //50 chars, part of a real name!
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void FirstNameValidMaxPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "Wolfeschlegelsteinhausenbergerdorffwelchevordepeufht";   //51 chars
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void FirstNameValidMaxMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "Wolfeschlegelsteinhausenbergerdorffwelchevorfjefk";   //49 chars
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void FirstNameValidMid()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "Wolfeschlegelsteinhausenb";   //25 chars
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void FirstNameValidExtremeMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "Davidddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd"; //100 chars
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void FirstNameValidInvalid()
        {
            clsStaff staffMemeber = new clsStaff();
            string FirstName = "Dav9d";   //51 chars
            string Error = "";
            Error = staffMemeber.ValidName(FirstName);
            Assert.AreNotEqual(Error, ""); //should error

        }

        /// Last Name Valid
        /// //////////////////////////////////////////////////////////////////////////////////////////////////


        [TestMethod]
        public void LastNameValidMinMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "";
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void LastNameValidMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "A";
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void LastNameValidMinPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "Aa";
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void LastNameValidMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "Wolfeschlegelsteinhausenbergerdorffwelchevordgjyte";   //50 chars, part of a real name!
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void LastNameValidMaxPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "Wolfeschlegelsteinhausenbergerdorffwelchevordepeufht";   //51 chars
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void LastNameValidMaxMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "Wolfeschlegelsteinhausenbergerdorffwelchevorfjefk";   //49 chars
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void LastNameValidMid()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "Wolfeschlegelsteinhausenb";   //25 chars
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void LastNameValidExtremeMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "Richardddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd"; //100 chars
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void LastNameValidInvalid()
        {
            clsStaff staffMemeber = new clsStaff();
            string LastName = "R8chardson";   //Contains a number
            string Error = "";
            Error = staffMemeber.ValidName(LastName);
            Assert.AreNotEqual(Error, ""); //should error
        }


        /// Hourly Rate Valid
        /// //////////////////////////////////////////////////////////////////////////////////////////////////


        [TestMethod]
        public void HourlyRateValidExtremeMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = "-10000";
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void HourlyRateValidMinMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = "-1";
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreNotEqual(Error, ""); //should be error
        }

        [TestMethod]
        public void HourlyRateValidMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = "0";
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void HourlyRateValidMinPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = "1";
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void HourlyRateValidMaxMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = (Decimal.MaxValue - 1).ToString();
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void HourlyRateValidMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = (Decimal.MaxValue).ToString(); ;
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreEqual(Error, ""); //should be no error
        }

        [TestMethod]
        public void HourlyRateValidMaxPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = "79228162514264337593543950336";
            //max value of a decial + 1. Too annoying to try and actually store, for obvious reasons
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void HourlyRateValidExtremeMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = "7902281625142643375935439503360000";
            //Greatly exceeds the max value of a decimal
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void HourlyRateValidInvalid()
        {
            clsStaff staffMemeber = new clsStaff();
            string HourlyRate = "David";
            string Error = "";
            Error = staffMemeber.ValidHourlyRate(HourlyRate);
            Assert.AreNotEqual(Error, ""); //should error
        }


        /// Start Date Valid
        /// //////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void StartDateValidExtremeMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string StartDate = DateTime.Now.AddYears(-100).ToString();
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void StartDateValidMinMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            //string StartDate = DateTime.Parse("2014-12-31").ToString();
            string StartDate = "2014-12-31";
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void StartDateValidMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string StartDate = "2015-01-01";
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreEqual(Error, ""); //should not be error
        }

        [TestMethod]
        public void StartDateValidMinPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string StartDate = "2015-01-02";
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreEqual(Error, ""); //should not be error
        }

        [TestMethod]
        public void StartDateValidMaxMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string StartDate = DateTime.Today.AddDays(364).ToString();
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreEqual(Error, ""); //should not be error
        }

        [TestMethod]
        public void StartDateValidMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string StartDate = DateTime.Today.AddDays(365).ToString();
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreEqual(Error, ""); //should not be error
        }

        [TestMethod]
        public void StartDateValidMaxPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string StartDate = DateTime.Today.AddDays(366).ToString();
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void StartDateValidMid()
        {
            clsStaff staffMemeber = new clsStaff();
            string StartDate = DateTime.Today.ToString();
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreEqual(Error, ""); //should not error
        }

        [TestMethod]
        public void StartDateValidExtremeMax()
        {
            clsStaff staffMemeber = new clsStaff();
            //string StartDate = DateTime.Parse("2014-12-31").ToString();
            string StartDate = "3000-01-01";
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void StartDateValidInvalidChars()
        {
            clsStaff staffMemeber = new clsStaff();
            //string StartDate = DateTime.Parse("2014-12-31").ToString();
            string StartDate = "David";
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void StartDateValidInvalidDate()
        {
            clsStaff staffMemeber = new clsStaff();
            //string StartDate = DateTime.Parse("2014-12-31").ToString();
            string StartDate = "2020-13-13";
            string Error = "";
            Error = staffMemeber.ValidStartDate(StartDate);
            Assert.AreNotEqual(Error, ""); //should error
        }

        /// Phone Number Valid
        /// //////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void PhoneNumberValidExtremeMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "";
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void PhoneNumberValidMinMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "12345";
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreNotEqual(Error, ""); //should error
        }

        [TestMethod]
        public void PhoneNumberValidMin()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "123456";
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreEqual(Error, ""); //should not
        }

        [TestMethod]
        public void PhoneNumberValidMinPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "1234567";
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreEqual(Error, ""); //should not
        }

        [TestMethod]
        public void PhoneNumberValidMaxMinusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "1234567891012131415"; //19 chars length
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreEqual(Error, ""); //should not
        }


        [TestMethod]
        public void PhoneNumberValidMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "12345678910121314150"; //20 chars length
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreEqual(Error, ""); //should not
        }

        [TestMethod]
        public void PhoneNumberValidMaxPlusOne()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "123456789101213141500"; //21 chars length
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreNotEqual(Error, ""); //should give error
        }

        [TestMethod]
        public void PhoneNumberValidMid()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "1234567891012"; //13 chars length
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreEqual(Error, ""); //should not
        }

        [TestMethod]
        public void PhoneNumberValidExtremeMax()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "12345678910121314150000000000000000000000000000000000000000000000000000000000000"; //80 chars length
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreNotEqual(Error, ""); //should give error
        }

        [TestMethod]
        public void PhoneNumberValidInvalid()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "1234567891w1"; //cheeky w in there
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreNotEqual(Error, ""); //should give error
        }

        [TestMethod]
        public void PhoneNumberValidStartWithPlus()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "+123456789"; //valid. Starts with +
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreEqual(Error, ""); //should not give error
        }

        [TestMethod]
        public void PhoneNumberValidInvalidStartWithPlus()
        {
            clsStaff staffMemeber = new clsStaff();
            string PhoneNumber = "+123456789d"; //Invalid. Starts with +, and has a letter at end
            string Error = "";
            Error = staffMemeber.ValidPhoneNumber(PhoneNumber);
            Assert.AreNotEqual(Error, ""); //should give error
        }
    }
}

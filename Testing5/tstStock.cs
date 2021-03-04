using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //test data that will pass the method
        string ItemName = "Keycap";
        string Price = "7.50";
        string Material = "Resin";
        string LastPurchased = DateTime.Now.Date.ToString();
        string Quantity = "25";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnItem);
        }

        [TestMethod]
        public void ItemIdOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            int TestData = 5;
            //assign the data to the property
            AnItem.ItemId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.ItemId, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            string TestData = "WASD Keycaps Set";
            //assign the data to the property
            AnItem.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.ItemName, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 5.75m; //the m suffix indicates a decimal. More accuracy than Double.
            //assign the data to the property
            AnItem.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Price, TestData);
        }

        [TestMethod]
        public void MaterialOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            string TestData = "Metal";
            //assign the data to the property
            AnItem.Material = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Material, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AnItem.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.InStock, TestData);
        }

        [TestMethod]
        public void LastPurchasedOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the propety
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the propety
            AnItem.LastPurchased = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.LastPurchased, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //create some test data to assign to the propety
            int TestData = 20;
            //assign the data to the property
            AnItem.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnItem.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 itemId = 2;
            //invoke the method
            Found = AnItem.Find(itemId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemIdFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 2;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.ItemId != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 2;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.ItemName != "Avengers Thor Esc Keycap")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
         
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 2;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.Price != 35.00m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMaterialFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 2;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.Material != "Aluminium")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 2;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastPurchasedFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 2;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.LastPurchased != Convert.ToDateTime("15/01/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 2;
            //invoke the method
            Found = AnItem.Find(ItemId);
            //check the property
            if (AnItem.Quantity != 7)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        } 

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //invoke the method and test to see result is correct
            Assert.AreEqual(true, AnItem.Valid(ItemName, Price, Material, LastPurchased, Quantity));
    
        }

        /// ItemName Validation
        /// ///////////////////////////// 

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            string ItemName = "";
            //invoke the method
            Error = AnItem.ValidItemName(ItemName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            string ItemName = "xy";
            //invoke the method
            Error = AnItem.ValidItemName(ItemName);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod] 
        public void ItemNameMaxLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(79, 'x');
            //invoke the method
            Error = AnItem.ValidItemName(ItemName);       
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void ItemNameMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(80, 'x');
            //invoke the method
            Error = AnItem.ValidItemName(ItemName);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void ItemNameMid()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(40, 'x');
            //invoke the method
            Error = AnItem.ValidItemName(ItemName);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            string ItemName = ""; 
            ItemName = ItemName.PadRight(81, 'x');
            //invoke the method
            Error = AnItem.ValidItemName(ItemName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            string ItemName = ""; 
            ItemName = ItemName.PadRight(300, 'x');
            //invoke the method
            Error = AnItem.ValidItemName(ItemName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        /// LastPurchased Validation
        /// ///////////////////////////// 


        [TestMethod]
        public void LastPurchasedMinLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //store the minimum date
            DateTime MinimumDate = Convert.ToDateTime("2015-01-01");
            //set date to MinimumDate subtract 1 day
            String LastPurchased = MinimumDate.AddDays(-1).ToString();
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail           
        }

        [TestMethod]
        public void LastPurchasedMinPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //store the minimum date
            DateTime MinimumDate = Convert.ToDateTime("2015-01-01");
            //set date to MinimumDate plus 1 day.
            String LastPurchased = MinimumDate.AddDays(1).ToString();
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass           
        }

        [TestMethod]
        public void LastPurchasedMaxLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to yesterday's date
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string
            string LastPurchased = TestDate.ToString();
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void LastPurchasedMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //change the date to today's date
            TestDate = DateTime.Now.Date;
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void LastPurchasedMid()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //change the date to today's date
            TestDate = DateTime.Now.Date;
            //set the date to a little in the past
            TestDate = TestDate.AddYears(-5);
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void LastPurchasedMaxPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to tomorrow's date
            TestDate = TestDate.AddDays(1);
            //convert the date to a string
            String LastPurchased = TestDate.ToString();
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void LastPurchasedExtremeMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to today's date plus 100 years
            TestDate = TestDate.AddYears(+100);
            //convert the date to a string
            String LastPurchased = TestDate.ToString();
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void LastPurchasedExtremeMin()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set date to Today's date
            TestDate = DateTime.Now.Date;
            //change the date to today's date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string
            String LastPurchased = TestDate.ToString();
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        } 

        [TestMethod]
        public void LastPurchasedInvalidData()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the LastPurchased to a non date value
            String LastPurchased = "an invalid date input";
            //invoke the method
            Error = AnItem.ValidLastPurchased(LastPurchased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        /// Price Validation 
        /// /////////////////////////////

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to -1
            String Price = "-1";
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to 1
            String Price = "1";
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to Decimal's max value subtract 1
            String Price = (Decimal.MaxValue - 1).ToString();
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to Decimal's max value 
            String Price = (Decimal.MaxValue).ToString();
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to half of Decimal's max value
            String Price = (Decimal.MaxValue / 2).ToString();
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to Decimal's max value subtract 1
            String Price = "79228162514264337593543950336"; //replacement for Decimal.MaxValue + 1 (difficult to store)
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to Decimal's max value multiplied by 2
            String Price = "7902281625142643375935439503360000"; //replacement for Decimal.MaxValue * 2 (difficult to store)
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to -1
            String Price = "-10000";
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the test data to -1
            String Price = "Fifty";
            //invoke the method
            Error = AnItem.ValidPrice(Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        /// Material Validation
        /// /////////////////////////////
         

        [TestMethod]
        public void MaterialMinLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Material = "";
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void MaterialMinPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Material = "xX";
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void MaterialMaxLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method (20 characters)
            String Material = "x";
            Material = Material.PadRight(19, 'x');
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void MaterialMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method (20 characters)
            String Material = "x";
            Material = Material.PadRight(20, 'x');
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void MaterialMid()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method (10 characters)
            String Material = "xxxxxxxxxx";
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void MaterialMaxPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Material = "x";
            Material = Material.PadRight(21, 'x');
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void MaterialExtremeMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Material = "x";
            Material = Material.PadRight(100, 'x');
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod] 
        public void MaterialInvalidData()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method (invalid)
            String Material = "M3tal";
            //invoke the method
            Error = AnItem.ValidMaterial(Material);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        /// Quantity Validation 
        /// /////////////////////////////

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = "-1";
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = "1";
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = (Int32.MaxValue - 1).ToString();
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = (Int32.MaxValue).ToString();
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = (Int32.MaxValue / 1).ToString();
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //should pass          
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = "2147483648"; //replacement for Int32.MaxValue + 1 (difficult to implement)
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = "4294967294"; //replacement for Int32.MaxValue * 2 (difficult to implement)
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            //create an instance of clsStock
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            String Quantity = "Fifty";
            //invoke the method
            Error = AnItem.ValidQuantity(Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //should fail
        }
    }
}

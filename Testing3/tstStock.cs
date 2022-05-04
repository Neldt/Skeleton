using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        public bool Found { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //v00egd00001l.lec-admin.dmu.ac.uk
            //p2559549 
            //Imat1113
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Available = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStock.Available, TestData);
        }

        [TestMethod]
        public void ItemNoPropertyOK()
        {

            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ItemNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemNo, TestData);

        }

        [TestMethod]
        public void ItemDescriptionPropertyOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnStock.ItemDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemDescription, TestData);
        }

        [TestMethod]
        public void ItemQuantityOK()

        {

            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ItemQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemQuantity, TestData);

        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);

        }
        [TestMethod]
        public void PricePropertyOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            double TestData = 6.9;
            //assign the data to the property
            AnStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Price, TestData);

        }
        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ItemNo = 24;
            //invoke the method
            Found = AnStock.Find(ItemNo);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestItemNoFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(lets assume)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 24;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the Item no
            if (AnItem.ItemNo != 24)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (lets say it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 24;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the property
            if (AnItem.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemDescriptiopnFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 24;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemDescription != "ItemDescription")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemQuantityFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 24;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemQuantity != 4545)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(lets assume)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 24;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the Price
            if (AnItem.Price != 5.5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(lets assume)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 24;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the Availibilty
            if (AnItem.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
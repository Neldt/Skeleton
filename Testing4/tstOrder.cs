using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //v00egd00001l.lec-admin.dmu.ac.uk
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 23;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderCodePropertyOK()
        {
            //create an instance of a class
            clsOrder AnOrder= new clsOrder();
            //create some test data
            Int64 TestData = 23456787654;
            //assign the data to the property
            AnOrder.PhoneNumber = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.PhoneNumber, TestData);
        }

        [TestMethod]
        public void PurchaseTimePropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.PurchaseTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PurchaseTime, TestData) ;
        }

        [TestMethod]
        public void deliveryAddressPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign the property
            String TestData = "31 the la vegas";
            //assign the data to the property
            AnOrder.deliveryAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.deliveryAddress, TestData) ;
        }

        [TestMethod]
        public void DeliveryPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Delivery = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.Delivery, TestData);
        }

        [TestMethod]
        public void ItemQuantityPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test to assign the property
            int TestData = 34;
            //assign the data to the property
            AnOrder.ItemQuantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.ItemQuantity, TestData);
        }
        [TestMethod]
        public void NotesPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test to assign the property
            String TestData = "We should win this one";
            //assign the data to the property
            AnOrder.Notes = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.Notes, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test to assign the property
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the metod
            Found = AnOrder.Find(OrderID);

            //check the method
            if(AnOrder.OrderID != 6)
            {
                OK = false;
            }

            //Test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPurchaseTimeFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if(AnOrder.PurchaseTime != Convert.ToDateTime("20/04/2006"))
            {
                OK = false;
            }

            //test to see that the result is coorect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestdeliveryAddressFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if(AnOrder.deliveryAddress != "Test deliveryAddress")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.PhoneNumber != 23456787654)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.ItemQuantity != 5)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.Delivery != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNotesFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.Notes != "We should win this one")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

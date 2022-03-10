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
        public void ActivepropertOK()
        {
            //Create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderCode()
        {
            //create an instance of a class
            clsOrder AnOrder= new clsOrder();
            //create some test data
            Guid TestData = System.Guid.NewGuid();
            //assign the data to the property
            AnOrder.OrderCode = TestData;
            //test to see he two values are the same
            Assert.AreEqual(AnOrder.OrderCode, TestData);
        }

        [TestMethod]
        public void PurchaseTimeOK()
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
        public void DeliveryAddressOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign the property
            String TestData = "31 the la vegas";
            //assign the data to the property
            AnOrder.DeliveryAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData) ;
        }

        [TestMethod]
        public void DeliveryOK()
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
        public void ItemQuantityOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test to assign the property
            Int32 TestData = 34;
            //assign the data to the property
            AnOrder.ItemQuantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.ItemQuantity, TestData);
        }
        [TestMethod]
        public void NotesOK()
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
    }
}

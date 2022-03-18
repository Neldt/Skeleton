using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ReceiveMarketingPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.ReceiveMarketing = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ReceiveMarketing, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);

        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Random Address";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);

        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Random Email";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "John Smith";
            ACustomer.Name = TestData;
            Assert.AreEqual(ACustomer.Name, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        
        

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerID != 8)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.DateAdded != Convert.ToDateTime("01/01/2001 00:00"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.Address != "Test Address")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.Email != "Test Email")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.Name != "Test Name")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestReceiveMarketingFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.ReceiveMarketing != true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}

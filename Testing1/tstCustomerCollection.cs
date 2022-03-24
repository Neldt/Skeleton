using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data
            List<clsCustomer> TestList = new List<clsCustomer> ();
            //create a test customer
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ReceiveMarketing = true;
            TestItem.CustomerID = 40;
            TestItem.Name = "John Smith";
            TestItem.Email = "John@Smith.co.uk";
            TestItem.Address = "12a street";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the customer to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.ReceiveMarketing = true;
            TestCustomer.CustomerID = 40;
            TestCustomer.Name = "John Smith";
            TestCustomer.Email = "John@Smith.co.uk";
            TestCustomer.Address = "12a street";
            TestCustomer.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.ReceiveMarketing = true;
            TestItem.CustomerID = 40;
            TestItem.Name = "John Smith";
            TestItem.Email = "John@Smith.co.uk";
            TestItem.Address = "12a street";
            TestItem.DateAdded = DateTime.Now.Date;
            //add item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two count values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}

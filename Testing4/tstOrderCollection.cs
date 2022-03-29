using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing4
{
    /// <summary>
    /// Summary description for tstOrderCollection
    /// </summary>
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //test to see it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 8;
            TestItem.PhoneNumber = 465967544567;
            TestItem.ItemQuantity = 3;
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.Delivery = true;
            TestItem.DeliveryAddress = "1 des vegas";
            TestItem.Notes = "leave at the door";

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestOrder = new clsOrder();

            TestOrder.OrderID = 8;
            TestOrder.PhoneNumber = 465967544567;
            TestOrder.ItemQuantity = 3;
            TestOrder.DeliveryTime = DateTime.Now.Date;
            TestOrder.Delivery = true;
            TestOrder.DeliveryAddress = "1 des vegas";
            TestOrder.Notes = "leave at the door";

            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 9;
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.DeliveryAddress = "23 RTYUJH CTI ";
            TestItem.Delivery = true;
            TestItem.ItemQuantity = 5;
            TestItem.PhoneNumber = 67876543456;
            TestItem.Notes = "RTUYIK FYUGHJL YUIGHKJL";

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}

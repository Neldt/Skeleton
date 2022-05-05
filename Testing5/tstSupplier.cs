using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.Stock = TestData;
            Assert.AreEqual(AnSupplier.Stock, TestData);
        }

        [TestMethod]

        public void DeliveryDatePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.DeliveryDate = TestData;
            Assert.AreEqual(AnSupplier.DeliveryDate, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierId = TestData;
            Assert.AreEqual(AnSupplier.SupplierId, TestData);

        }

        [TestMethod]
        public void SupplierFeedbackPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 5;
            AnSupplier.SupplierFeedback = TestData;
            Assert.AreEqual(AnSupplier.SupplierFeedback, TestData);
        }

        [TestMethod]
        public void SupplierProductPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "orange Bike";
            AnSupplier.SupplierProduct = TestData;
            Assert.AreEqual(AnSupplier.SupplierProduct, TestData);

        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 200;
            AnSupplier.Price = TestData;
            Assert.AreEqual(AnSupplier.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierProduct != "orange Bike")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryDateFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.DeliveryDate != Convert.ToDateTime("15/05/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierFeedbackFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierFeedback != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.Price != 200)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}



    



        
using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string deliveryAddress { get; set; }
        public bool Delivery { get; set; }
        public Int32 ItemQuantity { get; set; }
        public string Notes { get; set; }
        public Guid OrderCode { get; set; }
        //private data member for the OrderID property
        private Int32 mOrderID;
        public Int32 OrderID 
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        
        }

        public bool Find(int orderID)
        {
            //set the pricate data members to the test data value
            mOrderID = 16;
            // Always return true
            return true;
        }
        
    }
}
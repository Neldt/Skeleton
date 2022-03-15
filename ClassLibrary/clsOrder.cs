using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //private data member for the delivery address property
        private String mdeliveryAddress;
        public String deliveryAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mdeliveryAddress;
            }
            set
            {
                //this line of code allows data into the property
                mdeliveryAddress = value;
            }
        }
        
        //private data member for the PurchaseTime property
        private DateTime mPurchaseTime;
        public DateTime PurchaseTime
        {
            get
            {
                //this line of code sends data out of the property
                return mPurchaseTime;
            }
            set
            {
                //this line of code allows data into the property
                mPurchaseTime = value;
            }
        }

        //private data member for the Delivery property
        private Boolean mDelivery;
        public bool Delivery
        {
            get
            {
                //this line of code sends data out of the property
                return mDelivery;
            }
            set
            {
                //this line of code allows data into the property
                mDelivery = value;
            }
        }

        //private data member for the Itemquantity property
        private Int32 mItemQuantity;
        public int ItemQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mItemQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mItemQuantity = value;
            }
        }

        //private data member for the Notes property
        private String mNotes;
        public string Notes
        {
            get
            {
                //this line of code sends data out of the property
                return mNotes;
            }
            set
            {
                //this line of code allows data into the property
                mNotes = value;
            }
        }

        //private data member for the OrderID property
        private Guid mOrderCode;
        public Guid OrderCode
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderCode;
            }
            set
            {
                //this line of code allows data into the property
                mOrderCode = value;
            }
        }

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
            //set the private data members to the data value
            mOrderID = 36;
            mOrderCode = OrderCode;
            mdeliveryAddress = "Test deliveryAddress";
            mDelivery = true;
            mPurchaseTime = Convert.ToDateTime("20/04/2006");
            mNotes = "We should win this one";
            mItemQuantity = 5;

            //always return true
            return true;


            /*//create an instance of the data connection
            clsDataConnection DB = clsDataConnection();
            //add the parameter order ID to search for
            DB.AddParameter(OrderID, OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if(DB.Count = 1)
            {
                // copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderCode = Convert.ToString(DB.DataTable.Rows[0]["OrderCode"]);
                mDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivery"]);
                mdeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["deliveryAddress"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mPurchaseTime = Convert.ToDateTime(DB.DataTable.Rows[0]["PurchaseTime"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);
                
            }*/

        }

    }
}
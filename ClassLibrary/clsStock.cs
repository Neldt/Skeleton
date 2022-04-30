using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private bool mAvailable;
        public bool Available { get; set; }
        /*{
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }*/
        //ItemNo private member variable
        private Int32 mItemNo;
        //ItemNo public property
        public Int32 ItemNo
        {
            get
            {
                //this line of code sends data out of the property
                return mItemNo;
            }
            set
            {
                //this line of code allows data into the property
                mItemNo = value;
            }
        }
        private String mItemDescription;
        public string ItemDescription
        {
            get
            {
                return mItemDescription;
            }
            set
            {
                mItemDescription = value;
            }
        }
        private Int32 mItemQuantity;
        public Int32 ItemQuantity
        {
            get
            {
                return mItemQuantity;
            }
            set
            {
                mItemQuantity = value;
            }
        }
        //private double mPrice;
        public double Price { get; set; }
        {
            /*get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }*/
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public bool Find(int ItemNo)
        {
            //set the private data members to the test data value
            mItemNo = 24;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mItemDescription = "ItemDescription";
            mItemQuantity = "ItemQuantity";
            //mPrice = "Price";
            //mAvailable = "Available";
            //always return true
            return true;
        }
    }
}
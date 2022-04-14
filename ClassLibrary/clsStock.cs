using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Available { get; set; }

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
        public string ItemDescription { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Find(int itemNo)
        {
            //set the private data members to the test data value
            mItemNo = 24;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            //always return true
            return true;
        }
    }
}
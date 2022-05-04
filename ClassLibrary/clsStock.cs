using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private bool mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
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
        private double mPrice;
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {

                mPrice = value;
            }
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

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Item no to search for
            DB.AddParameter("@ItemNo", ItemNo);
            //execute the stored procedure
            DB.Execute("dbo.sproc_tblStock_FilterByItemNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNo"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem

                return false;
            }

        }
    }
}
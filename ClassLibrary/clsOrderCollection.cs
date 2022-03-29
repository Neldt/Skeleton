using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {

        List<clsOrder> mOrderList = new List<clsOrder>();

        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectAll");

            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();

                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                AnOrder.PhoneNumber = Convert.ToInt64(DB.DataTable.Rows[0]["PhoneNumber"]);
                AnOrder.Delivery = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivery"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                AnOrder.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                AnOrder.DeliveryTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryTime"]);
                AnOrder.Notes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);

                mOrderList.Add(AnOrder);

                Index++;
            }


        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Phonenumber", mThisOrder.PhoneNumber);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@DeliveryTime",mThisOrder.DeliveryTime);
            DB.AddParameter("@Delivery",mThisOrder.Delivery);
            DB.AddParameter("@DeliveryAddress",mThisOrder.DeliveryAddress);
            DB.AddParameter("@Notes",mThisOrder.Notes);

            return DB.Execute("sproc_tblOrder_Insert");
        }
    }
}
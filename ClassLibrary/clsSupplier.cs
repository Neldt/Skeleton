using System;
using System.Text;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 mSupplierFeedback;
        private Int32 mSupplierId;
        private Decimal mPrice;
        private Boolean mStock;
        private String mSupplierProduct;
        private DateTime mDeliveryDate;
        public bool Stock
        {
            get
            {
                return mStock;
            }
            set
            {
                mStock = value;
            }
        }
        public DateTime DeliveryDate
        {
            get
            {
                return mDeliveryDate;
            }
            set
            {
                mDeliveryDate = value;
            }
        }
        public int SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }
        public int SupplierFeedback
        {
            get
            {
                return mSupplierFeedback;
            }
            set
            {
                mSupplierFeedback = value;
            }
        }
        public string SupplierProduct
        {
            get
            {
                return mSupplierProduct;
            }
            set
            {
                mSupplierProduct = value;
            }
        }
        public decimal Price
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

        public bool Find(int SupplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", SupplierId);
            DB.Execute("sproc_tblSupplier_FilterBuSupplierId");
            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["SupplierPrice"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierDeliveryDate"]);
                mStock = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierStock"]);
                mSupplierFeedback = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierFeedback"]);
                mSupplierProduct = Convert.ToString(DB.DataTable.Rows[0]["SupplierProduct"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

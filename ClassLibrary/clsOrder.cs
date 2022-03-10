using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string DeliveryAddress { get; set; }
        public bool Delivery { get; set; }
    }
}
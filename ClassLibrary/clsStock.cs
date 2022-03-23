using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Available { get; set; }
        public int ItemNo { get; set; }
        public string ItemDescription { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
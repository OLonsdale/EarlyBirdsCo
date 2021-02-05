using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public double price { get; set; }
        public string material { get; set; }
        public bool inStock { get; set; }
        public DateTime lastPurchased { get; set; }
        public int quantity { get; set; }
    }
}
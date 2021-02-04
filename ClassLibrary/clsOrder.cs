using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public string orderId { get; set; }
        public DateTime dateFinalised { get; set; }
        public string itemId { get; set; }
        public int quantity { get; set; }
        public double totalPrice { get; set; }
        public bool isEmpty { get; set; }
    }
}
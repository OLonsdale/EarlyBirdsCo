using System;

namespace ClassLibrary
{
    public class clsShipping
    {
        public bool Dispatched { get; set; }
        public DateTime DateOfDispatch { get; set; }
        public int ShippingId { get; set; }
        public decimal Price { get; set; }
        public string ShippingType { get; set; }
    }
}
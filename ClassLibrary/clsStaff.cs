using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public string   firstName   { get; set; }
        public string   lastName    { get; set; }
        public int      staffNumber { get; set; }
        public bool     isManager   { get; set; }
        public decimal  hourlyRate  { get; set; }
        public string   phoneNumber { get; set; }
        public DateTime startDate { get; set; }
    }
}
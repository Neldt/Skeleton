using System;

namespace ClassLibrary
{
    internal class clsStaff
    {
        public string StaffFullName { get; internal set; }
        public int StaffID { get; internal set; }
        public bool Availability { get; internal set; }
        public string StaffRole { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public int CustomerID { get; internal set; }
    }
}
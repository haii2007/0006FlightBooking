//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightBookingService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TravelDestMaster_Table
    {
        public long Id { get; set; }
        public string Dest { get; set; }
        public string Dest_Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Country_Name { get; set; }
        public Nullable<int> Area_Code { get; set; }
        public System.DateTime Add_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public bool Active { get; set; }
    }
}

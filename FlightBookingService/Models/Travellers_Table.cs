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
    
    public partial class Travellers_Table
    {
        public long Id { get; set; }
        public long User_ID { get; set; }
        public System.DateTime Reg_Date { get; set; }
        public string Type { get; set; }
        public string SSN { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public long Pref_Food { get; set; }
        public string Sex { get; set; }
        public string Father_Name { get; set; }
        public string Address1 { get; set; }
        public string Land_Mark { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip_Code { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string ISD { get; set; }
        public string Contact_No { get; set; }
        public string Email_ID { get; set; }
        public System.DateTime Add_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public bool Active { get; set; }
    }
}

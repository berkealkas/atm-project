//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bills
    {
        public long id { get; set; }
        public decimal amount { get; set; }
        public decimal phone_number { get; set; }
        public string bill { get; set; }
        public decimal bill_price { get; set; }
        public System.DateTime create_date { get; set; }
    }
}

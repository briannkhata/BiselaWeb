//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiselaWeb.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int AccountId { get; set; }
        public double OpeningBalance { get; set; }
        public double ClosingBalance { get; set; }
        public System.DateTime ActivityDate { get; set; }
        public int ShopId { get; set; }
        public int Deleted { get; set; }
    }
}

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
    
    public partial class ReceivingDetail
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<double> OrderPrice { get; set; }
        public Nullable<double> SellingPrice { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<int> ReceivingId { get; set; }
    }
}

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
    
    public partial class StockMovement
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> To { get; set; }
        public Nullable<int> From { get; set; }
        public Nullable<System.DateTime> DateMoved { get; set; }
        public Nullable<double> Qty { get; set; }
        public string Comment { get; set; }
    }
}

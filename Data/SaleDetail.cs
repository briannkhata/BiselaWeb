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
    
    public partial class SaleDetail
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public double SellingPrice { get; set; }
        public double Discount { get; set; }
        public double SoldPrice { get; set; }
        public int ShopId { get; set; }
        public double Qty { get; set; }
        public double TaxValue { get; set; }
        public int UserId { get; set; }
        public System.DateTime DateSold { get; set; }
    
        public virtual Product Product { get; set; }
    }
}

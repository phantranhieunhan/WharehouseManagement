//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockManagement.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleOrderDetail
    {
        public System.Guid SaleOrderDetailId { get; set; }
        public Nullable<System.Guid> ProductId { get; set; }
        public Nullable<System.Guid> SaleOrderId { get; set; }
        public Nullable<decimal> QuanlityOfCustomer { get; set; }
        public Nullable<decimal> QuanlityAvailable { get; set; }
        public Nullable<decimal> Status { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }
    }
}

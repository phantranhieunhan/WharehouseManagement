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
    
    public partial class PurchaseOrderDetail
    {
        public System.Guid PurchaseOrderDetailId { get; set; }
        public Nullable<System.Guid> PurchaseOrderId { get; set; }
        public Nullable<System.Guid> ProductId { get; set; }
        public Nullable<decimal> Status { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> QualityPurchase { get; set; }
        public Nullable<decimal> QualityAvalible { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}

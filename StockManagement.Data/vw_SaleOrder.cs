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
    
    public partial class vw_SaleOrder
    {
        public System.Guid SaleOrderId { get; set; }
        public string SaleOrderCode { get; set; }
        public string Customer { get; set; }
        public string ProductName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}

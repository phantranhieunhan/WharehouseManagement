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
    
    public partial class ProductOnStock
    {
        public System.Guid ProductOnStockId { get; set; }
        public Nullable<System.Guid> ProductId { get; set; }
        public Nullable<System.Guid> StockId { get; set; }
        public Nullable<decimal> MinQuanlity { get; set; }
        public Nullable<decimal> MaxQuanlity { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Stock Stock { get; set; }
    }
}

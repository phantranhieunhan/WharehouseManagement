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
    
    public partial class StockOutTransfer
    {
        public System.Guid StockOutId { get; set; }
        public Nullable<System.Guid> StockId { get; set; }
        public Nullable<System.Guid> Sto_StockId { get; set; }
        public Nullable<System.Guid> StockOutType { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string StockOutCode { get; set; }
        public Nullable<decimal> Status { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string PercentComplete { get; set; }
    
        public virtual Stock Stock { get; set; }
        public virtual StockOut StockOut { get; set; }
    }
}
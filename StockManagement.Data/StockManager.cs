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
    
    public partial class StockManager
    {
        public System.Guid StockManagerId { get; set; }
        public Nullable<System.Guid> StockId { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
    
        public virtual Stock Stock { get; set; }
    }
}

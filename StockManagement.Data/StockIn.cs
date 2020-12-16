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
    
    public partial class StockIn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockIn()
        {
            this.StockInDetail = new HashSet<StockInDetail>();
        }
    
        public System.Guid StockInId { get; set; }
        public Nullable<System.Guid> FromStock { get; set; }
        public Nullable<System.Guid> ToStock { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.Guid> PurchaseOrderId { get; set; }
        public Nullable<System.Guid> StockInTypeId { get; set; }
        public string StockInCode { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> Status { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> AccountingDate { get; set; }
        public Nullable<double> PercentComplete { get; set; }
        public string ReasonReturn { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Stock Stock1 { get; set; }
        public virtual StockInType StockInType { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockInDetail> StockInDetail { get; set; }
    }
}

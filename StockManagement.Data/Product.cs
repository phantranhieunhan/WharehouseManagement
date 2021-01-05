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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductOnStocks = new HashSet<ProductOnStock>();
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            this.SaleOrderDetails = new HashSet<SaleOrderDetail>();
            this.SupplierProducts = new HashSet<SupplierProduct>();
        }
    
        public System.Guid ProductId { get; set; }
        public Nullable<System.Guid> ProductCategoryId { get; set; }
        public Nullable<System.Guid> ProductTypeId { get; set; }
        public Nullable<System.Guid> ProductUnitId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> Size { get; set; }
        public string Color { get; set; }
        public string Picture { get; set; }
    
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProductUnit ProductUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOnStock> ProductOnStocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}

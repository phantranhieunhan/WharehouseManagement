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
    
    public partial class UserPermission
    {
        public System.Guid UserPermissionID { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<bool> btn_EmployeeList { get; set; }
        public Nullable<bool> btn_TypeEmployee { get; set; }
        public Nullable<bool> btn_Decentralization { get; set; }
        public Nullable<bool> btn_CustomerGroup { get; set; }
        public Nullable<bool> btn_CustomerList { get; set; }
        public Nullable<bool> btn_SupplierList { get; set; }
        public Nullable<bool> btn_SupplierProduct { get; set; }
        public Nullable<bool> btn_WarehouseList { get; set; }
        public Nullable<bool> btn_InventoryManagement { get; set; }
        public Nullable<bool> btn_ProductPortfolio { get; set; }
        public Nullable<bool> btn_ProductList { get; set; }
        public Nullable<bool> btn_StockIn { get; set; }
        public Nullable<bool> btn_StockOut { get; set; }
        public Nullable<bool> btn_SaleOrder { get; set; }
        public Nullable<bool> btn_PurchaseOrder { get; set; }
        public Nullable<bool> btn_Report1 { get; set; }
        public Nullable<bool> btn_Report2 { get; set; }
        public Nullable<bool> btn_Report3 { get; set; }
        public Nullable<bool> btn_Report4 { get; set; }
        public Nullable<bool> btn_Report5 { get; set; }
        public Nullable<bool> btn_Setting1 { get; set; }
        public Nullable<bool> btn_Setting2 { get; set; }
        public Nullable<bool> btn_Setting3 { get; set; }
        public Nullable<bool> btn_Setting4 { get; set; }
        public Nullable<bool> btn_Setting5 { get; set; }
    
        public virtual User User { get; set; }
    }
}

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
    
    public partial class Permission
    {
        public string PermissionId { get; set; }
        public string NamePermission { get; set; }
        public Nullable<bool> ViewPermission { get; set; }
        public Nullable<bool> AddPermission { get; set; }
        public Nullable<bool> EditPermission { get; set; }
        public Nullable<bool> DeletePermission { get; set; }
        public string GroupBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Business
{
    public class SupplierBO:Repository<Supplier>, ISupplier
    {
        public List<Supplier> GetSuppliers(bool isActive)
        {
            List<Supplier> suppliers;
            using(var db = new StockManagementEntities())
            {
                suppliers = db.Supplier.Include("SupplierProduct").Include("PurchaseOrder").Include("StockOut").ToList();
            }
            return suppliers;
        }
        public List<SupplierProduct> GetSupplierProducts(bool isActive)
        {
            List<SupplierProduct> supplierProducts;
            using (var db = new StockManagementEntities())
            {
                supplierProducts = db.SupplierProduct.Include("Supplier").Include("Product").Where(x => x.Supplier.Active == isActive).ToList();

            }
            return supplierProducts;
        }
    }
}

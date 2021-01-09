using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockManagement.Data;

namespace StockManagement.Business
{
    public interface ISupplier:IRepository<Supplier>
    {
        List<Supplier> GetSuppliers(bool isActive);
        List<SupplierProduct> GetSupplierProducts(bool isActive);

    }
}

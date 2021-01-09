using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Business
{
    public interface IProduct:IRepository<Product>
    {
        List<vw_ProductOnStock> GetProductOnStock();
        List<vw_ProductOnStockDetail> GetProductOnStockDetail(Guid productId);
        List<vw_ProductOnStockDetail> GetProductOnStockDetail();
        List<ProductType> GetProductTypes();
        List<vw_Product> GetProducts();
    }
}

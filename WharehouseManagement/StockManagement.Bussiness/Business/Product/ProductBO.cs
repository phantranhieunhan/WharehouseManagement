using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Business
{
    public class ProductBO:Repository<Product>, IProduct
    {
        public List<vw_ProductOnStockDetail> GetProductOnStock(Guid productId)
        {
            using (var db = new StockManagementEntities())
            {
                List<vw_ProductOnStockDetail> vw_ProductOnStockDetailList = db.vw_ProductOnStockDetail.Where(x => x.ProductId == productId).ToList();

                return vw_ProductOnStockDetailList;
            }
        }
    }
}

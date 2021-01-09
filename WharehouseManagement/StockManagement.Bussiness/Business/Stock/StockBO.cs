using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Business
{
    public class StockBO:Repository<Stock>, IStock
    {
        public List<Stock> GetStockList()
        {
            using (var db = new StockManagementEntities())
            {
                return db.Stock
                    .Include("ProductOnStock")
                    .Include("User")
                    .Include("StockOut1")
                    .Include("StockOut")
                    .Include("StockManager")
                    .Include("StockIn1")
                    .Include("StockIn")
                    .Include("PurchaseOrder").ToList();
            }
        }
    }
}

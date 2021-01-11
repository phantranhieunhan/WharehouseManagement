using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Business;
using StockManagement.Data;


namespace StockManagement.Business
{
    public class StockInBO:Repository<StockIn>, IStockIn
    {
        public List<vw_StockIn> GetVw_StockIns(int status)
        {
            using (var db = new StockManagementEntities())
            {
                return db.vw_StockIn.Where(x=>x.Status== status).ToList();
            }
        }

    }
}

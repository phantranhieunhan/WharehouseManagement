using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Business;
using StockManagement.Data;

namespace StockManagement.Business
{
    public interface IStockIn:IRepository<StockIn>
    {
        List<vw_StockIn> GetVw_StockIns(int status);
    }
}

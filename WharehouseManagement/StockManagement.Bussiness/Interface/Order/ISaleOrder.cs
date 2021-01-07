using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Business
{
    public interface ISaleOrder:IRepository<SaleOrder>
    {
        List<vw_SaleOrder> GetData(int status);
        void ChangeStatus(Guid saleOrderId, Guid updatedPerson, int status);
    }
}

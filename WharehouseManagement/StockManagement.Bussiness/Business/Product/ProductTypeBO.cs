using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Business
{
    public class ProductTypeBO:Repository<ProductType>, IProductType
    {
    }
}

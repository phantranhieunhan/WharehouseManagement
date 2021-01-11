using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Business.Model
{
    public class RequireStockOutModel
    {
        public Guid RequireStockOutModelId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        public int QuanlityRequire { get; set; }
        public Guid StockId { get; set; }
        public string StockName { get; set; }
        public int QuanlityProvide { get; set; }
    }
}

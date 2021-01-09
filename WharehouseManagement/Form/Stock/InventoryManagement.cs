using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Form.Stock
{
    public partial class InventoryManagement : DevExpress.XtraEditors.XtraUserControl
    {
        public InventoryManagement()
        {
            InitializeComponent();
            GetInit();
        }
        private void GetInit()
        {
            IProduct productBO = new ProductBO();
            gC_DanhSach.DataSource = productBO.GetProductOnStockDetail();
        }
    }
}

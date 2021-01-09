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
    public partial class WareHouse : DevExpress.XtraEditors.XtraUserControl
    {
        public WareHouse()
        {
            InitializeComponent();
            GetInit();
        }
        IStock stockBO = new StockBO();
        private void GetInit()
        {
            gC_DanhSach.DataSource = stockBO.GetStockList();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            AddWareHouse f = new AddWareHouse();
            f.Show();
        }
    }
}

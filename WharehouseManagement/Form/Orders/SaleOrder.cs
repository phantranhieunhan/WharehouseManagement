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

namespace StockManagement.Form.Orders
{
    public partial class SaleOrder : DevExpress.XtraEditors.XtraUserControl
    {
        public SaleOrder()
        {
            InitializeComponent();//nhấn f12
        }

        private void SaleOrder2_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            btn_ThemKH.Controls.Add(new SalesOrderAdd() { Dock = DockStyle.Fill });
        }
    }
}

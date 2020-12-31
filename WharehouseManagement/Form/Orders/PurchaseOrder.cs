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
    public partial class PurchaseOrder : DevExpress.XtraEditors.XtraUserControl
    {
        public PurchaseOrder()
        {
            InitializeComponent();//nhấn f12
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            PurchaseOrderAdd f = new PurchaseOrderAdd();
            f.Show();
        }
    }
}

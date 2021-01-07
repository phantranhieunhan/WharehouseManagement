using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StockManagement.Form.Orders
{
    public partial class SaleOrderAdd : DevExpress.XtraEditors.XtraForm
    {
        public SaleOrderAdd()
        {
            InitializeComponent();
        }

        private void btn_Info_EditValueChanged(object sender, EventArgs e)
        {
            SaleOrderProductDetail f = new SaleOrderProductDetail();
            f.Show();
        }
    }
}
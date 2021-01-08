using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Form.StockOut
{
    public partial class StockOutList : DevExpress.XtraEditors.XtraUserControl
    {
        public StockOutList()
        {
            InitializeComponent();
        }

        private void gC_DangXuLy_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddStockOut f = new AddStockOut();
            f.Show();
        }

        private void txt_TenKhachHang_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

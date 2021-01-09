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

namespace StockManagement.Form.Orders
{
    public partial class SaleOrder : DevExpress.XtraEditors.XtraUserControl
    {
        public SaleOrder()
        {
            InitializeComponent();//nhấn f12
            GetInit();
        }
        private void GetInit()
        {
            ISaleOrder saleOrderBO = new SaleOrderBO();
            List<vw_SaleOrder> vw_SaleOrders = saleOrderBO.GetData(1);
            gC_DanhSachDonMoi.DataSource = vw_SaleOrders;
        }


        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            SaleOrderAdd f = new SaleOrderAdd();
            f.Show();
        }

        private void buttonRecieve_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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

        private void btn_Sua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Data.Stock stock =(Data.Stock) gridView1.GetFocusedRow();
            AddWareHouse addWareHouse = new AddWareHouse(stock);
            addWareHouse.Show();
        }

        private void btn_Xoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Data.Stock stock = (Data.Stock)gridView1.GetFocusedRow();
            string message = "Bạn có muốn xóa " +stock.StockName + " không?";
            string title = "Cảnh báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                stockBO.Delete(stock);
                gC_DanhSach.DataSource = stockBO.GetStockList();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

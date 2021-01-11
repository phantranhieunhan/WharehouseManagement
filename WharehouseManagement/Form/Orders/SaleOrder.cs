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
        ISaleOrder saleOrderBO = new SaleOrderBO();
        private void GetInit()
        {

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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestData();

        }
        
        private void bt_requireStockOut_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            vw_SaleOrder vw_Sale = (vw_SaleOrder)gridView2.GetFocusedRow();
            List<vw_SaleOrder> vw_SaleOrderList = saleOrderBO.GetData(2).Where(x => x.SaleOrderId == vw_Sale.SaleOrderId).ToList();

            
            RequireStockOut requireStockOut = new RequireStockOut(vw_SaleOrderList);
            requireStockOut.Show();
        }

        private void buttonRecieve_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UpdateStatus(gridView1, 2);
            RequestData();
        }
        private bool UpdateStatus( DevExpress.XtraGrid.Views.Grid.GridView gridView, int status)
        {
            vw_SaleOrder vw_Sale = (vw_SaleOrder)gridView.GetFocusedRow();
            Data.SaleOrder saleOrder = saleOrderBO.GetByID(vw_Sale.SaleOrderId);
            saleOrder.Status = status;

            return saleOrderBO.Update(saleOrder);
        }
        private void RequestData()
        {
            int selectedIndex = tabControl.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex <= 3)
            {
                ISaleOrder saleOrderBO = new SaleOrderBO();
                List<vw_SaleOrder> vw_SaleOrders = saleOrderBO.GetData(selectedIndex + 1);

                if (selectedIndex == 0)
                {
                    gC_DanhSachDonMoi.DataSource = vw_SaleOrders;
                }
                else if (selectedIndex == 1)
                {
                    gC_DanhSachDaTiepNhan.DataSource = vw_SaleOrders;

                }
                else if (selectedIndex == 2)
                {
                    gC_DanhSachYeuCauNhapKho.DataSource = vw_SaleOrders;

                }
                else
                {
                    gC_DanhSachDonHuy.DataSource = vw_SaleOrders;
                }
            }
        }

        private void bt_require_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            UpdateStatus(gridView2, 3);
            RequestData();
        }

        private void bt_cancel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UpdateStatus(gridView2, 4);
            RequestData();
        }
    }
}

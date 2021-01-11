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
    public partial class PurchaseOrder : DevExpress.XtraEditors.XtraUserControl
    {
        public PurchaseOrder()
        {
            InitializeComponent();//nhấn f12

            GetInit();
        }
        private void GetInit()
        {
            IPurchaseOrder purchaseOrderBO = new PurchaseOrderBO();
            List<vw_PurchaseOrder> vw_PurchaseOrderList = purchaseOrderBO.GetData(1);
            gC_DanhSachDonMoi.DataSource = vw_PurchaseOrderList;
        }

        private void SaleOrder2_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            PurchaseOrderAdd f = new PurchaseOrderAdd();
            f.Show();
        }



        private void abc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl newSender = (TabControl)sender;
            int selectedIndex = newSender.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex <= 3)
            {
                IPurchaseOrder purchaseOrderBO = new PurchaseOrderBO();
                List<vw_PurchaseOrder> vw_PurchaseOrderList = purchaseOrderBO.GetData(selectedIndex + 1);

                if (selectedIndex == 0)
                {
                    gC_DanhSachDonMoi.DataSource = vw_PurchaseOrderList;
                }
                else if (selectedIndex == 1)
                {
                    gC_DanhSachDaTiepNhan.DataSource = vw_PurchaseOrderList;

                }
                else if (selectedIndex == 2)
                {
                    gC_DanhSachYeuCauNhapKho.DataSource = vw_PurchaseOrderList;

                }
                else
                {
                    gC_DanhSachDonHuy.DataSource = vw_PurchaseOrderList;
                }
            }

        }
    }
}

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

        private void SaleOrder2_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            SalesOrderAdd f = new SalesOrderAdd();
            f.Show();
        }

        private void buttonRecieve_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl newSender = (TabControl)sender;
            int selectedIndex = newSender.SelectedIndex;
            if (selectedIndex >=0 && selectedIndex <=3)
            {
                ISaleOrder saleOrderBO = new SaleOrderBO();
                List<vw_SaleOrder> vw_SaleOrders = saleOrderBO.GetData(selectedIndex + 1);

                if (selectedIndex == 0)
                {
                    gC_DanhSachDonMoi.DataSource = vw_SaleOrders;
                }
                else if(selectedIndex == 1)
                {
                    gC_DanhSachDaTiepNhan.DataSource = vw_SaleOrders;

                }
                else if(selectedIndex == 2)
                {
                    gC_DanhSachYeuCauNhapKho.DataSource = vw_SaleOrders;

                }
                else
                {
                    gC_DanhSachDonHuy.DataSource = vw_SaleOrders;
                }
            }
        }


    }
}

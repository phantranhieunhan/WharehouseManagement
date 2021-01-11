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

using StockManagement.Business;
using StockManagement.Data;

namespace StockManagement.Form.StockIn
{
    public partial class StockInList : DevExpress.XtraEditors.XtraUserControl
    {
        public StockInList()
        {
            InitializeComponent();
            GetInit();
            
        }
        IStockIn stockInBO = new StockInBO();
        private void GetInit()
        {
            gC_PhieuMoi.DataSource = stockInBO.GetVw_StockIns(1);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddStockIn f = new AddStockIn();
            f.Show();
        }


        private bool UpdateStatus(DevExpress.XtraGrid.Views.Grid.GridView gridView, int status)
        {
            vw_StockIn vwstockIn = (vw_StockIn)gridView.GetFocusedRow();
            Data.StockIn stockIn = stockInBO.GetByID(vwstockIn.StockInId);
            stockIn.Status = status;
            return stockInBO.Update(stockIn);
        }

        private void gC_DSNhapKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            int selectedIndex = gC_DSNhapKho.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex <= 4)
            {
                List<vw_StockIn> vw_StockInList = stockInBO.GetVw_StockIns(selectedIndex + 1);

                if (selectedIndex == 0)
                {
                    gC_PhieuMoi.DataSource = vw_StockInList;
                }
                else if (selectedIndex == 1)
                {
                    gC_DangKiemTra.DataSource = vw_StockInList;

                }
                else if (selectedIndex == 2)
                {
                    gC_HoanThanh.DataSource = vw_StockInList;

                }
                else if (selectedIndex == 3)
                {
                    gC_PhieuBiLoiHang.DataSource = vw_StockInList;
                }
                else
                {
                    gC_DonBiHuy.DataSource = vw_StockInList;
                }
            }

        }

        private void btn_TienHanhXuLy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UpdateStatus(gridView1, 2))
            {
                XtraMessageBox.Show("Đã tiến hành xữ lý");
            }
            else
            {
                XtraMessageBox.Show("Thất bại! Thử lại!");
            }
            RefreshData();
        }
        private void bt_atten_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UpdateStatus(gridView2, 4))
            {
                XtraMessageBox.Show("Đã tiến hành xữ lý");
            }
            else
            {
                XtraMessageBox.Show("Thất bại! Thử lại!");
            }
            RefreshData();
        }

        private void bt_Oke_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UpdateStatus(gridView2, 3))
            {
                vw_StockIn vwstockIn = (vw_StockIn)gridView2.GetFocusedRow();

                IProduct productBO = new ProductBO();
                productBO.UpdateProductOnStock(vwstockIn);
                XtraMessageBox.Show("Đã tiến hành xữ lý");
            }
            else
            {
                XtraMessageBox.Show("Thất bại! Thử lại!");
            }
            RefreshData();
        }

        private void bt_history_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        private void btn_HuyPhieu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UpdateStatus(gridView1, 5))
            {
                XtraMessageBox.Show("Đã tiến hành xữ lý");
            }
            else
            {
                XtraMessageBox.Show("Thất bại! Thử lại!");
            }
            RefreshData();
        }
        private void bt_save_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (UpdateStatus(gridView 6))
            //{
            //    XtraMessageBox.Show("Đã tiến hành xữ lý");
            //}
            //else
            //{
            //    XtraMessageBox.Show("Thất bại! Thử lại!");
            //}
            //gC_PhieuMoi.RefreshDataSource();
        }
    }
}

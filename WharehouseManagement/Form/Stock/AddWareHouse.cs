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
using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Form.Stock
{
    public partial class AddWareHouse : DevExpress.XtraEditors.XtraForm
    {
        Data.Stock stock;
        public AddWareHouse()
        {
            InitializeComponent();
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            this.Text = "Thêm kho hàng";
        }
        public AddWareHouse(Data.Stock stock)
        {
            InitializeComponent();
            txt_MaKH.Text = stock.StockCode;
            txt_TenKH.Text = stock.StockName;
            txt_SDT.Text = stock.PhoneNumber.ToString();
            txt_DiaChiKH.Text = stock.Address;
            txt_MaKH.Enabled = false;
            this.stock = stock;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = true;
            this.Text = "Cập nhật kho hàng";
        }

        IStock stockBO = new StockBO();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txt_MaKH.Text) ||
                    !String.IsNullOrEmpty(txt_TenKH.Text) ||
                    !String.IsNullOrEmpty(txt_DiaChiKH.Text) ||
                    !String.IsNullOrEmpty(txt_SDT.Text))
                {
                    Data.Stock stock = new Data.Stock()
                    {
                        StockId = Guid.NewGuid(),
                        StockCode = txt_MaKH.Text,
                        StockName = txt_TenKH.Text,
                        Address = txt_DiaChiKH.Text,
                        PhoneNumber = Convert.ToInt32(txt_SDT.Text)
                    };

                    if (stockBO.Add(stock))
                    {
                        XtraMessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
                }
            }
            catch
            {

                throw;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (
    !String.IsNullOrEmpty(txt_TenKH.Text) ||
    !String.IsNullOrEmpty(txt_DiaChiKH.Text) ||
    !String.IsNullOrEmpty(txt_SDT.Text))
            {
                this.stock.StockName = txt_TenKH.Text;
                this.stock.Address = txt_DiaChiKH.Text;
                this.stock.PhoneNumber = Convert.ToInt32(txt_SDT.Text);

                if (stockBO.Update(stock))
                {
                    XtraMessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật thất bại");
                }
                
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            }
        }
    }
}
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
        public AddWareHouse()
        {
            InitializeComponent();
        }

        IStock stockBO = new StockBO();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(txt_MaKH.Text) ||
                    !String.IsNullOrEmpty(txt_TenKH.Text) || 
                    !String.IsNullOrEmpty(txt_DiaChiKH.Text) ||
                    !String.IsNullOrEmpty(txt_SDT.Text))
                {
                    Data.Stock stock= new Data.Stock()
                    {
                        StockId = Guid.NewGuid(),
                        StockCode = txt_MaKH.Text,
                        StockName = txt_TenKH.Text,
                        Address = txt_DiaChiKH.Text,
                        PhoneNumber = Convert.ToInt32(txt_SDT.Text)
                    };

                    stockBO.Add(stock);
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
    }
}
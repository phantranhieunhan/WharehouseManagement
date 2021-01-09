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

namespace StockManagement.Form.Product
{
    public partial class ProductsList : DevExpress.XtraEditors.XtraUserControl
    {
        public ProductsList()
        {
            InitializeComponent();
            GetInit();
        }
        IProduct productBO = new ProductBO();
        private void GetInit()
        {
            gridControl1.DataSource = productBO.GetProducts();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            AddProduct listOfProduct = new AddProduct();
            listOfProduct.Show();
        }
    }
}

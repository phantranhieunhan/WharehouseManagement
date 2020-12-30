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

namespace StockManagement.Form.Product
{
    public partial class ListOfProducts : DevExpress.XtraEditors.XtraUserControl
    {
        public ListOfProducts()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            AddProduct listOfProduct = new AddProduct();
            listOfProduct.Show();
        }
    }
}

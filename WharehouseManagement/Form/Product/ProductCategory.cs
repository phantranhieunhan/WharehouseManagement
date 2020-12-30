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
    public partial class ProductCategory : DevExpress.XtraEditors.XtraUserControl
    {
        public ProductCategory()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            AddProductCategories productCategories = new AddProductCategories();
            productCategories.Show();
        }
    }
}

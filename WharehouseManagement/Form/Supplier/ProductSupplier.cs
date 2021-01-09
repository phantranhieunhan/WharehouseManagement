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

using StockManagement.Business;
using StockManagement.Data;

namespace StockManagement.Form.Supplier
{
    public partial class ProductSupplier : DevExpress.XtraEditors.XtraUserControl
    {
        ISupplier supplierBO = new SupplierBO();
        public ProductSupplier()
        {
            InitializeComponent();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            AddProductSupplier productSupplier = new AddProductSupplier();
            productSupplier.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                gridControl1.DataSource = supplierBO.GetSupplierProducts(true);
            }
            else
            {
                gridControl2.DataSource = supplierBO.GetSupplierProducts(false);
            }
        }
    }
}

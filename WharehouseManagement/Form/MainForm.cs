using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using StockManagement.Form.Supplier;

namespace StockManagement.Form
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainSupplier mainSupplier = new MainSupplier();
            mainSupplier.MdiParent = this;
            mainSupplier.Show();
        }

    }
}
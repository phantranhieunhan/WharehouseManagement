using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockManagement.Form.Orders;

namespace StockManagement.Form
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_SaleOrder_Click(object sender, EventArgs e)
        {
            SalesOrder saleOrder = new SalesOrder();
            saleOrder.MdiParent = this;
            saleOrder.Show();
        }

        private void container_Click(object sender, EventArgs e)
        {

        }
    }
}

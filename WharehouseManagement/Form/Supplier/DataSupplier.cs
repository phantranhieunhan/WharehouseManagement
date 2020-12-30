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

namespace StockManagement.Form.Supplier
{
    public partial class DataSupplier : DevExpress.XtraEditors.XtraUserControl
    {
        public DataSupplier()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            AddSupplier dataSupplier = new AddSupplier();
            dataSupplier.Show();
        }
    }
}

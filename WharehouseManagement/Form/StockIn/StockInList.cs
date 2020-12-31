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

namespace StockManagement.Form.StockIn
{
    public partial class StockInList : DevExpress.XtraEditors.XtraUserControl
    {
        public StockInList()
        {
            InitializeComponent();
            //
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddStockIn f = new AddStockIn();
            f.Show();
        }
    }
}

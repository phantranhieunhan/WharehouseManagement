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
    public partial class AddStockIn : DevExpress.XtraEditors.XtraForm
    {
        public AddStockIn()
        {
            InitializeComponent();
        }

        private void lud_Product_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lud_Product_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void AddStockIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.stockManagementDataSet.Supplier);
            // TODO: This line of code loads data into the 'stockManagementDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stockManagementDataSet.Stock);
            // TODO: This line of code loads data into the 'stockManagementDataSet.StockInType' table. You can move, or remove it, as needed.
            this.stockInTypeTableAdapter.Fill(this.stockManagementDataSet.StockInType);

        }
    }
}
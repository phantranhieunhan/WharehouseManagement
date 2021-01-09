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

namespace StockManagement.Form.Product
{
    public partial class ProductCategory : DevExpress.XtraEditors.XtraUserControl
    {
        public ProductCategory()
        {
            InitializeComponent();
            GetInit();
        }
        IProduct productBO = new ProductBO();
        private void GetInit()
        {
            Gc_Main.DataSource = productBO.GetProductTypes();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            AddProductCategories productCategories = new AddProductCategories();
            productCategories.Show();
        }

        private void gc_master_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {

        }

        private void gc_master_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {

        }

        private void gc_master_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {

        }

        private void gc_master_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {

        }
    }
}

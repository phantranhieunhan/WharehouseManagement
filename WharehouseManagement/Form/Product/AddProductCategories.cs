using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Form.Product
{
    public partial class AddProductCategories : DevExpress.XtraEditors.XtraForm
    {
        public AddProductCategories()
        {
            InitializeComponent();
        }
       
        //public AddProductCategories(ProductCategory productCategory)
        //{
           
        //}
        IProductType productTypeBO = new ProductTypeBO();
        private void sb_save_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_CategoryCode.Text) || !String.IsNullOrEmpty(txt_CatagoryName.Text) || !String.IsNullOrEmpty(cbb_Parent.Text))
            {
                Data.ProductType productCategory = new Data.ProductType();
                productCategory.ProductTypeId = Guid.NewGuid();
                productCategory.ProductTypeCode = txt_CategoryCode.Text;
                productCategory.ProductTypeName = txt_CatagoryName.Text;
                productCategory.ProductType2.ProductTypeId = ((Data.ProductType)cbb_Parent.EditValue).ProductTypeId;

                if (productTypeBO.Add(productCategory))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            }
        }

        private void AddProductCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementDataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.stockManagementDataSet.ProductType);

        }
    }
}
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
using StockManagement.Business;
using StockManagement.Data;
using System.IO;
using System.Drawing.Imaging;

namespace StockManagement.Form.Product
{
    public partial class AddProduct : DevExpress.XtraEditors.XtraForm
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var db = new StockManagementEntities())
            {
                byte[] bytes;
                MemoryStream ms = new MemoryStream();
                pictureEdit1.Image.Save(ms, ImageFormat.Jpeg);

                bytes = ms.ToArray();
                Data.Product product = new Data.Product();
                product.ProductId = Guid.NewGuid();
                
                //db.Product.Add()
            }
        }
    }
}
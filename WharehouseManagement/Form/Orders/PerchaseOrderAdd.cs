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

namespace StockManagement.Form.Orders
{
    public partial class PerchaseOrderAdd : DevExpress.XtraEditors.XtraForm
    {
        public PerchaseOrderAdd()
        {
            InitializeComponent();
            GetInit();
        }

        public void GetInit()
        {
            using (var db = new StockManagementEntities())
            {
                List<Data.Supplier> supplierList = db.Supplier.ToList();
                txt_NCC.Properties.DataSource = supplierList;
                txt_NCC.Properties.DisplayMember = "SupplierCode";
                txt_NCC.Properties.ValueMember = "SupplierId";

                List<Data.Stock> stockList = db.Stock.ToList();
                txt_KhoGiao.Properties.DataSource = stockList;
                txt_KhoGiao.Properties.DisplayMember = "StockCode";
                txt_KhoGiao.Properties.ValueMember = "StockId";

                txt_MaDon.Text = "";

                List<Data.vw_ProductOnStock> vw_ProductOnStockList = db.vw_ProductOnStock.ToList();
                lud_Product.Properties.DataSource = vw_ProductOnStockList;
                lud_Product.Properties.DisplayMember = "ProductName";
                lud_Product.Properties.ValueMember = "ProductId";

                
            }
        }

        private void btn_Info_MouseHover(object sender, EventArgs e)
        {
            if (lud_Product.SelectedText != "")
            {
                Data.vw_ProductOnStock vw_ProductOnStock = (Data.vw_ProductOnStock)lud_Product.GetSelectedDataRow();

                IProduct productBO = new ProductBO();
                List<vw_ProductOnStockDetail> productOnStockDetailList = productBO.GetProductOnStock(vw_ProductOnStock.ProductId);

                ProductOnStockDetail salesOrderProductDetail = new ProductOnStockDetail();
                salesOrderProductDetail = new ProductOnStockDetail(productOnStockDetailList);
                salesOrderProductDetail.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn sản phẩm!!!");
            }
        }

        private void lud_Product_EditValueChanged(object sender, EventArgs e)
        {
            if (lud_Product.SelectedText.Any())
            {
                Data.vw_ProductOnStock vw_ProductOnStock = (Data.vw_ProductOnStock)lud_Product.GetSelectedDataRow();
                spinEditQuanlity.Properties.MaxValue = Convert.ToInt32(vw_ProductOnStock.TotalQuanlity);
                spinEditQuanlity.Properties.MinValue = 0;
            }
        }
    }
}
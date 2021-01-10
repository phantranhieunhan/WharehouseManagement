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
    public partial class PurchaseOrderAdd : DevExpress.XtraEditors.XtraForm
    {
        public PurchaseOrderAdd()
        {
            InitializeComponent();
            GetInit();
        }
        Data.PurchaseOrder purchaseOrder = new Data.PurchaseOrder();
        List<Data.PurchaseOrderDetail> purchaseOrderDetailList = new List<Data.PurchaseOrderDetail>();
        List<vw_PurchaseOrderDetail> vw_PurchaseOrderDetailList = new List<vw_PurchaseOrderDetail>();
        public void GetInit()
        {
            purchaseOrder.PurchaseOrderId = Guid.NewGuid();

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
            Gc_ListProduct.DataSource = vw_PurchaseOrderDetailList;

        }

        private void btn_Info_MouseHover(object sender, EventArgs e)
        {
            if (lud_Product.SelectedText != "")
            {
                Data.vw_ProductOnStock vw_ProductOnStock = (Data.vw_ProductOnStock)lud_Product.GetSelectedDataRow();

                IProduct productBO = new ProductBO();
                List<vw_ProductOnStockDetail> productOnStockDetailList = productBO.GetProductOnStockDetail(vw_ProductOnStock.ProductId);

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

        private void button2_Click(object sender, EventArgs e)
        {
            vw_PurchaseOrderDetail vw_PurchaseOrderDetail = new vw_PurchaseOrderDetail();
            if (!String.IsNullOrEmpty(txt_MaDon.Text) || lud_Product.EditValue != null)
            {
                vw_PurchaseOrderDetail.PurchaseOrderDetailId = Guid.NewGuid();
                Data.vw_ProductOnStock vw_ProductOnStock = (Data.vw_ProductOnStock)lud_Product.GetSelectedDataRow();
                vw_PurchaseOrderDetail.ProductId = vw_ProductOnStock.ProductId;
                vw_PurchaseOrderDetail.ProductCode = vw_ProductOnStock.ProductCode;
                vw_PurchaseOrderDetail.ProductName = vw_ProductOnStock.ProductName;
                vw_PurchaseOrderDetail.QuanlityPurchase = spinEditQuanlity.Value;
                vw_PurchaseOrderDetail.Status = 1;
                vw_PurchaseOrderDetail.PurchaseOrderId = purchaseOrder.PurchaseOrderId;
                vw_PurchaseOrderDetailList.Add(vw_PurchaseOrderDetail);
                Gc_ListProduct.RefreshDataSource();


                PurchaseOrderDetail purchaseOrderDetail = new PurchaseOrderDetail();
                purchaseOrderDetail.PurchaseOrderDetailId = vw_PurchaseOrderDetail.PurchaseOrderDetailId;
                purchaseOrderDetail.PurchaseOrderId = vw_PurchaseOrderDetail.PurchaseOrderId;
                purchaseOrderDetail.Status = vw_PurchaseOrderDetail.Status;
                purchaseOrderDetail.ProductId = vw_PurchaseOrderDetail.ProductId;
                purchaseOrderDetail.QuanlityAvalible = vw_PurchaseOrderDetail.QuanlityAvalible;
                purchaseOrderDetail.QuanlityPurchase = vw_PurchaseOrderDetail.QuanlityPurchase;

                purchaseOrderDetailList.Add(purchaseOrderDetail);
            }
            else
            {
                MessageBox.Show("Bạn phải nhập mã đặt hàng trước");
            }

        }
    }
}
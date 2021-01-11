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
    public partial class SaleOrderAdd : DevExpress.XtraEditors.XtraForm
    {
        public SaleOrderAdd()
        {
            InitializeComponent();
            GetInit();
        }
        Data.SaleOrder saleOrder = new Data.SaleOrder();
        List<SaleOrderDetail> saleOrderDetailList = new List<SaleOrderDetail>();
        List<vw_SaleOrderDetail> vw_SaleOrderDetaiList = new List<vw_SaleOrderDetail>();
        bool isChangeAddress = false;

        public void GetInit()
        {
            saleOrder.SaleOrderId = Guid.NewGuid();

            cbb_TenKH.Visible = true;
            txt_NameCustom.Visible = false;
            checkEdit1.Checked = false;

            ICustomer customerBO = new CustomerBO();
            cbb_TenKH.Properties.DisplayMember = "FullName";
            cbb_TenKH.Properties.ValueMember = "CustomerId";
            cbb_TenKH.Properties.DataSource = customerBO.GetAll();

            cbb_TinhTP.Properties.DataSource = customerBO.GetProvince();
            cbb_TinhTP.Properties.DisplayMember = "name";

            cbb_QuanHuyen.Properties.DataSource = customerBO.GetDistricts();
            cbb_QuanHuyen.Properties.DisplayMember = "name";


            cbb_PhuongXa.Properties.DataSource = customerBO.GetWards();
            cbb_PhuongXa.Properties.DisplayMember = "name";

            txt_MaDon.Text = "";

            cbb_DiaChiDaLuu.Properties.DisplayMember = "FullAddress";

            IProduct productBO = new ProductBO();

            List<Data.vw_ProductOnStock> vw_ProductOnStockList = productBO.GetProductOnStock();
            lud_Product.Properties.DataSource = vw_ProductOnStockList;
            lud_Product.Properties.DisplayMember = "ProductName";

            gC_SanPham.DataSource = vw_SaleOrderDetaiList;
        }

        private void btn_Info_EditValueChanged(object sender, EventArgs e)
        {
            ProductOnStockDetail f = new ProductOnStockDetail();
            f.Show();

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                cbb_TenKH.Visible = false;
                txt_NameCustom.Visible = true;
            }
            else
            {
                cbb_TenKH.Visible = true;
                txt_NameCustom.Visible = false;
            }

            txt_Email.Text = "";
            txt_SDT.Text = "";
            txt_DiaChiCuThe.Text = "";

            isChangeAddress = true;

            cbb_TinhTP.Reset();
            cbb_QuanHuyen.Reset();

            cbb_PhuongXa.Reset();

            cbb_DiaChiDaLuu.Reset();
        }

        private void txt_NameCustom_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbb_TinhTP_EditValueChanged(object sender, EventArgs e)
        {
            if (isChangeAddress)
            {
                ICustomer customerBO = new CustomerBO();

                DevExpress.XtraEditors.Controls.ChangingEventArgs changingEventArgs = (DevExpress.XtraEditors.Controls.ChangingEventArgs)e;

                province provinceSender = (province)changingEventArgs.NewValue;

                cbb_QuanHuyen.Properties.DataSource = customerBO.GetDistrictsByProvinceId(provinceSender.id);
            }
        }

        private void cbb_QuanHuyen_EditValueChanged(object sender, EventArgs e)
        {
            if (isChangeAddress)
            {
                ICustomer customerBO = new CustomerBO();

                DevExpress.XtraEditors.Controls.ChangingEventArgs changingEventArgs = (DevExpress.XtraEditors.Controls.ChangingEventArgs)e;

                district districtSender = (district)changingEventArgs.NewValue;
                cbb_PhuongXa.Properties.DataSource = customerBO.GetWardsByDistrictId(districtSender.id);
                isChangeAddress = true;
            }
        }

        private void lud_Product_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (lud_Product.EditValue != null)
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
            if (lud_Product.EditValue != null)
            {
                Data.vw_ProductOnStock vw_ProductOnStock = (Data.vw_ProductOnStock)lud_Product.GetSelectedDataRow();
                spinEditQuanlity.Properties.MaxValue = Convert.ToInt32(vw_ProductOnStock.TotalQuanlity);
                spinEditQuanlity.Properties.MinValue = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vw_SaleOrderDetail vw_SaleOrderDetail = new vw_SaleOrderDetail();
            if (!String.IsNullOrEmpty(txt_MaDon.Text) || lud_Product.EditValue != null)
            {
                vw_SaleOrderDetail.SaleOrderDetailId = Guid.NewGuid();
                Data.vw_ProductOnStock vw_ProductOnStock = (Data.vw_ProductOnStock)lud_Product.GetSelectedDataRow();
                vw_SaleOrderDetail.ProductId = vw_ProductOnStock.ProductId;
                vw_SaleOrderDetail.ProductCode = vw_ProductOnStock.ProductCode;
                vw_SaleOrderDetail.ProductName = vw_ProductOnStock.ProductName;
                vw_SaleOrderDetail.QuanlityOfCustomer = spinEditQuanlity.Value;
                vw_SaleOrderDetail.Status = 1;
                vw_SaleOrderDetail.SaleOrderId = saleOrder.SaleOrderId;
                vw_SaleOrderDetaiList.Add(vw_SaleOrderDetail);
                gC_SanPham.RefreshDataSource();


                SaleOrderDetail saleOrderDetail = new SaleOrderDetail();
                saleOrderDetail.SaleOrderDetailId = vw_SaleOrderDetail.SaleOrderDetailId;
                saleOrderDetail.SaleOrderId = vw_SaleOrderDetail.SaleOrderId;
                saleOrderDetail.Status = vw_SaleOrderDetail.Status;
                saleOrderDetail.ProductId = vw_SaleOrderDetail.ProductId;
                saleOrderDetail.QuanlityAvailable = vw_SaleOrderDetail.QuanlityAvailable;
                saleOrderDetail.QuanlityOfCustomer = vw_SaleOrderDetail.QuanlityOfCustomer;

                saleOrderDetailList.Add(saleOrderDetail);
            }
            else
            {
                MessageBox.Show("Bạn phải nhập mã đặt hàng trước");
            }
        }

        private void btn_Info_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            
            saleOrder.CreatedBy = new Guid("217F9628-607F-4F74-8DFD-685B97696263");
            saleOrder.CreatedDate = DateTime.Now;
            saleOrder.SaleOrderCode = txt_MaDon.Text;

            saleOrder.SaleOrderDetail = saleOrderDetailList;

            ISaleOrder saleOrderBO = new SaleOrderBO();
            saleOrderBO.Add(saleOrder);
        }

        private void cbb_TenKH_EditValueChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(cbb_TenKH.SelectedText.ToString()))
            {
                ICustomer customerBO = new CustomerBO();

                Data.Customer customer = (Data.Customer)cbb_TenKH.GetSelectedDataRow();
                saleOrder.CustomerId = customer.CustomerId;


                txt_Email.Text = customer.Email;
                txt_SDT.Text = customer.NumberPhone.ToString();

                List<vw_AddressCustomer> vw_AddressCustomerList = customerBO.GetAddressCustomers(customer.CustomerId);

                vw_AddressCustomer addressCustomerDefault = vw_AddressCustomerList.FirstOrDefault();

                isChangeAddress = false;

                txt_DiaChiCuThe.Text = addressCustomerDefault.Detail;

                cbb_TinhTP.EditValue = customerBO.GetProvinceById(addressCustomerDefault.ProvinceId);
                cbb_TinhTP.Text = customerBO.GetProvinceById(addressCustomerDefault.ProvinceId).name;

                cbb_QuanHuyen.EditValue = customerBO.GetDistrictsById(addressCustomerDefault.DistrictId);
                cbb_QuanHuyen.Text = customerBO.GetDistrictsById(addressCustomerDefault.DistrictId).name;

                cbb_PhuongXa.EditValue = customerBO.GetWardsById(addressCustomerDefault.WardId);
                cbb_PhuongXa.Text = customerBO.GetWardsById(addressCustomerDefault.WardId).name;

                saleOrder.ShipAddress = addressCustomerDefault.AddressCustomerId.ToString();

                cbb_DiaChiDaLuu.Properties.DataSource = vw_AddressCustomerList;
            }
        }

        private void cbb_DiaChiDaLuu_Properties_EditValueChanged(object sender, EventArgs e)
        {

            DevExpress.XtraEditors.Controls.ChangingEventArgs changingEventArgs = (DevExpress.XtraEditors.Controls.ChangingEventArgs)e;

            vw_AddressCustomer Sender = (vw_AddressCustomer)changingEventArgs.NewValue;

            isChangeAddress = false;

            txt_DiaChiCuThe.Text = Sender.Detail;

            ICustomer customerBO = new CustomerBO();

            cbb_TinhTP.EditValue = customerBO.GetProvinceById(Sender.ProvinceId);
            cbb_TinhTP.Text = customerBO.GetProvinceById(Sender.ProvinceId).name;

            cbb_QuanHuyen.EditValue = customerBO.GetDistrictsById(Sender.DistrictId);
            cbb_QuanHuyen.Text = customerBO.GetDistrictsById(Sender.DistrictId).name;

            cbb_PhuongXa.EditValue = customerBO.GetWardsById(Sender.WardId);
            cbb_PhuongXa.Text = customerBO.GetWardsById(Sender.WardId).name;

        }
    }
}
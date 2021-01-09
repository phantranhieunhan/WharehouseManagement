using DevExpress.XtraEditors;
using StockManagement.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Data;

namespace StockManagement.Form.Customer
{
    public partial class AddressCustomerList : DevExpress.XtraEditors.XtraForm
    {
        List<vw_AddressCustomer> vw_AddressCustomerList = new List<vw_AddressCustomer>();
        bool isChangeAddress = true;
        public AddressCustomerList()
        {
            InitializeComponent();
            GetInit();
        }
        public AddressCustomerList(List<vw_AddressCustomer> addressCustomer)
        {
            InitializeComponent();
            this.vw_AddressCustomerList = addressCustomer;
            GetInit();
        }
        public void GetInit()
        {
            ICustomer customerBO = new CustomerBO();

            cbb_TinhTP.Properties.DataSource = customerBO.GetProvince();
            cbb_TinhTP.Properties.DisplayMember = "name";

            cbb_QuanHuyen.Properties.DataSource = customerBO.GetDistricts();
            cbb_QuanHuyen.Properties.DisplayMember = "name";

            cbb_PhuongXa.Properties.DataSource = customerBO.GetWards();
            cbb_PhuongXa.Properties.DisplayMember = "name";

            txt_Detail.Text = "";
            gv_DiaChiDaLuu.Refresh();
            gv_DiaChiDaLuu.DataSource = vw_AddressCustomerList;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if(cbb_TinhTP.EditValue!=null && cbb_QuanHuyen != null && cbb_PhuongXa != null && !String.IsNullOrEmpty(txt_Detail.Text))
            {
                vw_AddressCustomer addressCustomer = new vw_AddressCustomer()
                {
                    AddressCustomerId = Guid.NewGuid(),
                    ProvinceId = ((province)cbb_TinhTP.EditValue).id,
                    ProvinceName = ((province)cbb_TinhTP.EditValue).name,
                    DistrictId = ((district)cbb_QuanHuyen.EditValue).id,
                    DistrictName = ((district)cbb_QuanHuyen.EditValue).name,
                    WardId = ((ward)cbb_PhuongXa.EditValue).id,
                    WardName = ((ward)cbb_PhuongXa.EditValue).name,
                    Detail = txt_Detail.Text
                };

                vw_AddressCustomerList.Add(addressCustomer);


                gv_DiaChiDaLuu.RefreshDataSource();
            }
            else
            {
                XtraMessageBox.Show("Bạn cần phải nhập đầy đủ thông tin");
            }
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

        private void cbb_PhuongXa_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
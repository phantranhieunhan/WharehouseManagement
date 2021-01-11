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
using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Form.Customer
{
    public partial class AddCustomerList : DevExpress.XtraEditors.XtraForm
    {
        public AddCustomerList()
        {
            InitializeComponent();
            GetInit();
        }
        Data.Customer customer = new Data.Customer();
        List<vw_AddressCustomer> vw_AddressCustomerList = new List<vw_AddressCustomer>();
        
        private void GetInit()
        {
            txt_MaKhachHang.Text = "";
            txt_TenKhachHang.Text = "";
            txt_Email.Text = "";
            txt_SDT.Text = "";
            dtp_Birthday.Value = DateTime.Now;
            dtp_CreatedDate.Value = DateTime.Now;
            dtp_LastUpdate.Value = DateTime.Now;
        }
        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            AddressCustomerList addressCustomerList = new AddressCustomerList(vw_AddressCustomerList);
            addressCustomerList.Show();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            ICustomer customerBO = new CustomerBO();
            foreach (vw_AddressCustomer item in vw_AddressCustomerList)
            {
                customer.AddressCustomer.Add(customerBO.TransferAddressCustomer(item));
            }
            
            if(!String.IsNullOrEmpty(txt_MaKhachHang.Text) || !String.IsNullOrEmpty(txt_TenKhachHang.Text) || !String.IsNullOrEmpty(txt_Email.Text) || !String.IsNullOrEmpty(txt_SDT.Text))
            {
                customer.CustomerId = Guid.NewGuid();
                customer.CustomerCode = txt_MaKhachHang.Text;
                customer.FullName = txt_TenKhachHang.Text;
                customer.Email = txt_Email.Text;
                customer.NumberPhone = Convert.ToInt32(txt_SDT.Text);
                customer.CreatedDate = DateTime.Now;
                customer.Birthday = dtp_Birthday.Value;

                customerBO.Add(customer);
            }
            else
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin");
            }
        }

        private void AddCustomerList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementDataSet.AddressCustomer' table. You can move, or remove it, as needed.
           // this.addressCustomerTableAdapter.Fill(this.stockManagementDataSet.AddressCustomer);
            // TODO: This line of code loads data into the 'stockManagementDataSet.GroupCustomer' table. You can move, or remove it, as needed.
            //this.groupCustomerTableAdapter.Fill(this.stockManagementDataSet.GroupCustomer);

        }
    }
}
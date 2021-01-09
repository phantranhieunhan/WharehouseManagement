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

using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Form.Customer
{
    public partial class CustomerList : DevExpress.XtraEditors.XtraUserControl
    {
        public CustomerList()
        {
            InitializeComponent();
            InitData();
        }
        ICustomer customerBO = new CustomerBO();
        public void InitData()
        {
            gridControl1.DataSource = customerBO.GetAll();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddCustomerList addCustomerList = new AddCustomerList();

            addCustomerList.Show();
        }
    }
}

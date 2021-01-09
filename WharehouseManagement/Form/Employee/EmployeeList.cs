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
using StockManagement.Business;
using StockManagement.Data;

namespace StockManagement.Form.Employee
{
    public partial class EmployeeList : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
            StockManagementEntities dbContext = new StockManagementEntities();

            gC_DanhSach.DataSource = dbContext.User.ToList();
        }

        public void InitData()
        {
            
        }

        private void btnChitiet_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail();
            employeeDetail.Show();
        }
    }
}

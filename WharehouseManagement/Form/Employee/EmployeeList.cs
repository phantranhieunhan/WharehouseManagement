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

            gridControl1.DataSource = dbContext.Users.ToList();
        }

        public void InitData()
        {
            
        }
    }
}

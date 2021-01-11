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

namespace StockManagement.Form.Employee
{
    public partial class TypeEmployee : DevExpress.XtraEditors.XtraUserControl
    {
        public TypeEmployee()
        {
            InitializeComponent();
            GetInit();
        }
        IUser userBO = new UserBO();
        public void GetInit()
        {
            gC_DanhSach.DataSource = userBO.GetUserTypes();
        }
    }
}

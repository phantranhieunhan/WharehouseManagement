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

namespace StockManagement.Form.Orders
{
    public partial class SalesOrder : DevExpress.XtraEditors.XtraForm
    {
        private static SalesOrder _instance;

        public static SalesOrder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SalesOrder();
                return _instance;
            }
        }


        public SalesOrder()
        {
            InitializeComponent();
        }
    }
}
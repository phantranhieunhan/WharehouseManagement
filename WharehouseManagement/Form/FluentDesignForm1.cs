using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockManagement.Form.Stock;

namespace StockManagement.Form
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FluentDesignForm1()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new XtraUserControl1() { Dock = DockStyle.Fill });

        }
    }
}

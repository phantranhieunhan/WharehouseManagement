﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockManagement.Form.Orders;
using StockManagement.Form.Stock;

namespace StockManagement.Form
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_SaleOrder_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new XtraUserControl1() { Dock = DockStyle.Fill });
        }

        private void container_Click(object sender, EventArgs e)
        {
            //flu
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}

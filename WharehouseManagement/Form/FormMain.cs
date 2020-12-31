using DevExpress.XtraBars;
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
using StockManagement.Form.Customer;
using StockManagement.Form.Employee;
using StockManagement.Form.StockIn;
using StockManagement.Form.StockOut;

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
            fluentDesignFormContainer1.Controls.Add(new SaleOrder() { Dock = DockStyle.Fill });
        }
        
      
        private void container_Click(object sender, EventArgs e)
        {
            //flu
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_InventoryManagement_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new InventoryManagement() { Dock = DockStyle.Fill });

        }

        private void btn_WarehouseList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new WareHouse() { Dock = DockStyle.Fill });
        }

        private void btn_EmployeeList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new EmployeeList() { Dock = DockStyle.Fill });
        }

        private void btn_CustomerGroup_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new CustomerGroup() { Dock = DockStyle.Fill });
        }

        private void btn_CustomerList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new CustomerList() { Dock = DockStyle.Fill });
        }

        private void btn_Decentralization_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Decentralization() { Dock = DockStyle.Fill });
        }

        private void btn_TypeEmployee_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new TypeEmployee() { Dock = DockStyle.Fill });
        }

        private void btn_StockOut_Click(object sender, EventArgs e)
        {
          //  fluentDesignFormContainer1.Controls.Add(new StockOut() { Dock = DockStyle.Fill });
        }

        private void btn_StockIn_Click(object sender, EventArgs e)
        {
          // fluentDesignFormContainer1.Controls.Add(new StockIn() { Dock = DockStyle.Fill });
        }

        private void btn_PurchaseOrder_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new PurchaseOrder() { Dock = DockStyle.Fill });
        }
    }
}

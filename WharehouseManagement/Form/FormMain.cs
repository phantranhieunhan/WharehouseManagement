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
using StockManagement.Form.Supplier;
using StockManagement.Form.Product;
using StockManagement.Data;

namespace StockManagement.Form
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
            //LoadPermission();
           // LoadUser();
        }

        public void LoadUser()
        {
            lb_UserName.Text = Session.UserId.ToString();
        }
        public void LoadPermission()
        {
            List<string> permissionList = new List<string>() {
                "btn_CustomerGroup",
                "btn_CustomerList",
                "btn_SupplierList",
                "btn_WarehouseList"
            };

            foreach (DevExpress.XtraBars.Navigation.AccordionControlElement item in this.accordionControl1.Elements)
            {
                item.Visible = false;
                foreach (DevExpress.XtraBars.Navigation.AccordionControlElement itemChild in item.Elements)
                {
                    itemChild.Visible = false;
                    
                    foreach (string itemString in permissionList)
                    {
                        if (itemChild.Name.Equals(itemString)|| item.Name.Equals(itemString))
                        {
                            item.Visible = true;
                            itemChild.Visible = true;
                            
                        }    
                            
                    }

                }
            }
            //foreach (Control control in this.Controls)
            //{
            //    foreach (string permission in permissionList)
            //    {
            //        if (control.Name.Equals(permission))
            //        {
                        
            //        }
            //    }
            //}
        }
        private void btn_SaleOrder_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Orders.SaleOrder() { Dock = DockStyle.Fill });
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
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new InventoryManagement() { Dock = DockStyle.Fill });

        }

        private void btn_WarehouseList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new WareHouse() { Dock = DockStyle.Fill });
        }

        private void btn_EmployeeList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new EmployeeList() { Dock = DockStyle.Fill });
        }

        private void btn_CustomerGroup_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new CustomerGroup() { Dock = DockStyle.Fill });
        }

        private void btn_CustomerList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new CustomerList() { Dock = DockStyle.Fill });
        }

        private void btn_Decentralization_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Decentralization() { Dock = DockStyle.Fill });
        }

        private void btn_TypeEmployee_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new TypeEmployee() { Dock = DockStyle.Fill });
        }

        private void btn_StockOut_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new StockOutList() { Dock = DockStyle.Fill });
        }

        private void btn_StockIn_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new StockInList() { Dock = DockStyle.Fill });
        }

        private void btn_PurchaseOrder_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Orders.PurchaseOrder() { Dock = DockStyle.Fill });
        }

        private void btn_SupplierList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new SupplierList() { Dock = DockStyle.Fill });
        }

        private void btn_SupplierProduct_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new ProductSupplier() { Dock = DockStyle.Fill });
        }

        private void btn_ProductPortfolio_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Product.ProductCategory() { Dock = DockStyle.Fill });
        }

        private void btn_ListProducts_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new ProductsList() { Dock = DockStyle.Fill });

        }
    }
}

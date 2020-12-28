namespace StockManagement.Form
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Employee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_EmployeeList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_TypeEmployee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Decentralization = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Report = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Customer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_CustomerGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_CustomerList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Supplier = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_SupplierList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_SupplierProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Warehouse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_WarehouseList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_InventoryManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Product = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_ProductPortfolio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_ListProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_StockIn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_StockOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Order = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_SaleOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_PurchaseOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1145, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(164, 92);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(125, 22);
            this.buttonEdit1.TabIndex = 2;
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Text = "Cài đặt";
            // 
            // btn_Employee
            // 
            this.btn_Employee.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_EmployeeList,
            this.btn_TypeEmployee,
            this.btn_Decentralization});
            this.btn_Employee.Expanded = true;
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Text = "Nhân viên";
            // 
            // btn_EmployeeList
            // 
            this.btn_EmployeeList.Name = "btn_EmployeeList";
            this.btn_EmployeeList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_EmployeeList.Text = "Danh sách nhân viên";
            this.btn_EmployeeList.Click += new System.EventHandler(this.btn_EmployeeList_Click);
            // 
            // btn_TypeEmployee
            // 
            this.btn_TypeEmployee.Name = "btn_TypeEmployee";
            this.btn_TypeEmployee.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_TypeEmployee.Text = "Loại nhân viên";
            this.btn_TypeEmployee.Click += new System.EventHandler(this.btn_TypeEmployee_Click);
            // 
            // btn_Decentralization
            // 
            this.btn_Decentralization.Name = "btn_Decentralization";
            this.btn_Decentralization.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Decentralization.Text = "Phân quyền";
            this.btn_Decentralization.Click += new System.EventHandler(this.btn_Decentralization_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Text = "Báo cáo";
            // 
            // btn_Customer
            // 
            this.btn_Customer.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_CustomerGroup,
            this.btn_CustomerList});
            this.btn_Customer.Expanded = true;
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Text = "Khách hàng";
            // 
            // btn_CustomerGroup
            // 
            this.btn_CustomerGroup.Name = "btn_CustomerGroup";
            this.btn_CustomerGroup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_CustomerGroup.Text = "Nhóm khách hàng";
            this.btn_CustomerGroup.Click += new System.EventHandler(this.btn_CustomerGroup_Click);
            // 
            // btn_CustomerList
            // 
            this.btn_CustomerList.Name = "btn_CustomerList";
            this.btn_CustomerList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_CustomerList.Text = "Danh sách khách hàng";
            this.btn_CustomerList.Click += new System.EventHandler(this.btn_CustomerList_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_SupplierList,
            this.btn_SupplierProduct});
            this.btn_Supplier.Expanded = true;
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Text = "Nhà cung cấp";
            // 
            // btn_SupplierList
            // 
            this.btn_SupplierList.Name = "btn_SupplierList";
            this.btn_SupplierList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_SupplierList.Text = "Danh sách NCC";
            // 
            // btn_SupplierProduct
            // 
            this.btn_SupplierProduct.Name = "btn_SupplierProduct";
            this.btn_SupplierProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_SupplierProduct.Text = "Sản phẩm từ NCC";
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_WarehouseList,
            this.btn_InventoryManagement});
            this.btn_Warehouse.Expanded = true;
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.Text = "Kho hàng";
            // 
            // btn_WarehouseList
            // 
            this.btn_WarehouseList.Name = "btn_WarehouseList";
            this.btn_WarehouseList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_WarehouseList.Text = "Danh sách kho hàng";
            this.btn_WarehouseList.Click += new System.EventHandler(this.btn_WarehouseList_Click);
            // 
            // btn_InventoryManagement
            // 
            this.btn_InventoryManagement.Name = "btn_InventoryManagement";
            this.btn_InventoryManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_InventoryManagement.Text = "Quản lý tồn kho";
            this.btn_InventoryManagement.Click += new System.EventHandler(this.btn_InventoryManagement_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_ProductPortfolio,
            this.btn_ListProducts});
            this.btn_Product.Expanded = true;
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Text = "Sản phẩm";
            // 
            // btn_ProductPortfolio
            // 
            this.btn_ProductPortfolio.Name = "btn_ProductPortfolio";
            this.btn_ProductPortfolio.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_ProductPortfolio.Text = "Danh mục sản phẩm ";
            // 
            // btn_ListProducts
            // 
            this.btn_ListProducts.Name = "btn_ListProducts";
            this.btn_ListProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_ListProducts.Text = "Danh sách sản phẩm";
            // 
            // btn_StockIn
            // 
            this.btn_StockIn.Expanded = true;
            this.btn_StockIn.Name = "btn_StockIn";
            this.btn_StockIn.Text = "Nhập kho";
            // 
            // btn_StockOut
            // 
            this.btn_StockOut.Expanded = true;
            this.btn_StockOut.Name = "btn_StockOut";
            this.btn_StockOut.Text = "Xuất kho";
            // 
            // btn_Order
            // 
            this.btn_Order.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_SaleOrder,
            this.btn_PurchaseOrder});
            this.btn_Order.Expanded = true;
            this.btn_Order.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Text = "Đơn hàng";
            // 
            // btn_SaleOrder
            // 
            this.btn_SaleOrder.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btn_SaleOrder.Name = "btn_SaleOrder";
            this.btn_SaleOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_SaleOrder.Text = "Đặt hàng bán hàng";
            this.btn_SaleOrder.Click += new System.EventHandler(this.btn_SaleOrder_Click);
            // 
            // btn_PurchaseOrder
            // 
            this.btn_PurchaseOrder.Name = "btn_PurchaseOrder";
            this.btn_PurchaseOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_PurchaseOrder.Text = "Đặt hàng mua hàng";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.accordionControl1.Appearance.AccordionControl.BackColor2 = System.Drawing.Color.Teal;
            this.accordionControl1.Appearance.AccordionControl.BorderColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Disabled.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Pressed.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_Order,
            this.btn_StockOut,
            this.btn_StockIn,
            this.btn_Product,
            this.btn_Warehouse,
            this.btn_Supplier,
            this.btn_Customer,
            this.btn_Report,
            this.btn_Employee,
            this.accordionControlElement10});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 260;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(325, 586);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(331, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(814, 586);
            this.fluentDesignFormContainer1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 625);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "FormMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "FormMain";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Order;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_SaleOrder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_PurchaseOrder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_StockOut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_StockIn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Product;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_ProductPortfolio;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_ListProducts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Warehouse;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_WarehouseList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_InventoryManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Supplier;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_SupplierList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_SupplierProduct;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Customer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Report;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Employee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_EmployeeList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_TypeEmployee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Decentralization;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_CustomerGroup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_CustomerList;
    }
}
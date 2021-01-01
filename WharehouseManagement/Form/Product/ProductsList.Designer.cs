namespace StockManagement.Form.Product
{
    partial class ProductsList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_timkiem = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.btn_timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.btn_timkiem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 535);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(5, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 323);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductCode,
            this.ProductName,
            this.Price,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.btn_Sua,
            this.btn_Xoa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ProductCode
            // 
            this.ProductCode.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCode.AppearanceHeader.Options.UseFont = true;
            this.ProductCode.Caption = "Mã sản phẩm";
            this.ProductCode.FieldName = "ProductCode";
            this.ProductCode.MinWidth = 25;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Visible = true;
            this.ProductCode.VisibleIndex = 0;
            this.ProductCode.Width = 94;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.Caption = "Tên sản phẩm";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 94;
            // 
            // Price
            // 
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.Caption = "Giá bán";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 25;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Danh mục";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Ngày tạo";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // btn_Sua
            // 
            this.btn_Sua.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.btn_Sua.AppearanceHeader.Options.UseFont = true;
            this.btn_Sua.Caption = "edit";
            this.btn_Sua.MinWidth = 25;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Visible = true;
            this.btn_Sua.VisibleIndex = 6;
            this.btn_Sua.Width = 94;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.btn_Xoa.AppearanceHeader.Options.UseFont = true;
            this.btn_Xoa.Caption = "delete";
            this.btn_Xoa.MinWidth = 25;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Visible = true;
            this.btn_Xoa.VisibleIndex = 7;
            this.btn_Xoa.Width = 94;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Controls.Add(this.simpleButton2);
            this.btn_timkiem.Controls.Add(this.btn_them);
            this.btn_timkiem.Controls.Add(this.textEdit1);
            this.btn_timkiem.Location = new System.Drawing.Point(5, 31);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(788, 142);
            this.btn_timkiem.TabIndex = 0;
            this.btn_timkiem.TabStop = false;
            this.btn_timkiem.Text = "Tìm kiếm";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(601, 53);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Tìm kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(455, 53);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm ";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(20, 61);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(203, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ProductsList";
            this.Size = new System.Drawing.Size(798, 535);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.btn_timkiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Xoa;
        private System.Windows.Forms.GroupBox btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}

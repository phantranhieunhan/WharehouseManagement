﻿namespace StockManagement.Form.Orders
{
    partial class SalesOrderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrderAdd));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NCC = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaDon = new DevExpress.XtraEditors.TextEdit();
            this.txt_KhoGiao = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Info = new DevExpress.XtraEditors.PictureEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lud_Product = new DevExpress.XtraEditors.LookUpEdit();
            this.gC_DanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sửa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xóa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.spinEditQuanlity = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KhoGiao.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Info.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lud_Product.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sửa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xóa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuanlity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // txt_NCC
            // 
            this.txt_NCC.Location = new System.Drawing.Point(120, 6);
            this.txt_NCC.Name = "txt_NCC";
            this.txt_NCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NCC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierCode", "Mã NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Tên NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaxCode", "MS thuế")});
            this.txt_NCC.Properties.NullText = "Tên NCC";
            this.txt_NCC.Size = new System.Drawing.Size(317, 22);
            this.txt_NCC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kho giao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã đơn:";
            // 
            // txt_MaDon
            // 
            this.txt_MaDon.EditValue = "Mã đơn";
            this.txt_MaDon.Location = new System.Drawing.Point(120, 43);
            this.txt_MaDon.Name = "txt_MaDon";
            this.txt_MaDon.Size = new System.Drawing.Size(317, 22);
            this.txt_MaDon.TabIndex = 5;
            // 
            // txt_KhoGiao
            // 
            this.txt_KhoGiao.Location = new System.Drawing.Point(515, 6);
            this.txt_KhoGiao.Name = "txt_KhoGiao";
            this.txt_KhoGiao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_KhoGiao.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã Kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên Kho")});
            this.txt_KhoGiao.Properties.NullText = "Kho giao";
            this.txt_KhoGiao.Size = new System.Drawing.Size(309, 22);
            this.txt_KhoGiao.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gC_DanhSach);
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 330);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // btn_Info
            // 
            this.btn_Info.EditValue = ((object)(resources.GetObject("btn_Info.EditValue")));
            this.btn_Info.Location = new System.Drawing.Point(782, 76);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_Info.Size = new System.Drawing.Size(35, 37);
            this.btn_Info.TabIndex = 6;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // lud_Product
            // 
            this.lud_Product.Location = new System.Drawing.Point(18, 80);
            this.lud_Product.Name = "lud_Product";
            this.lud_Product.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lud_Product.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductCode", "Mã SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Tên SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TotalQuanlity", "Số lượng")});
            this.lud_Product.Properties.NullText = "Tìm kiếm sản phẩm";
            this.lud_Product.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lud_Product.Size = new System.Drawing.Size(336, 22);
            this.lud_Product.TabIndex = 1;
            this.lud_Product.EditValueChanged += new System.EventHandler(this.lud_Product_EditValueChanged);
            // 
            // gC_DanhSach
            // 
            this.gC_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_DanhSach.Location = new System.Drawing.Point(3, 19);
            this.gC_DanhSach.MainView = this.gridView1;
            this.gC_DanhSach.Name = "gC_DanhSach";
            this.gC_DanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Sửa,
            this.Xóa});
            this.gC_DanhSach.Size = new System.Drawing.Size(803, 308);
            this.gC_DanhSach.TabIndex = 0;
            this.gC_DanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gC_DanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã SP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên SP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 227;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá bán";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 134;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 136;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sửa";
            this.gridColumn5.ColumnEdit = this.Sửa;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 100;
            // 
            // Sửa
            // 
            this.Sửa.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            serializableAppearanceObject9.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject9.Image")));
            serializableAppearanceObject9.Options.UseImage = true;
            this.Sửa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Sửa.Name = "Sửa";
            this.Sửa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Xóa";
            this.gridColumn6.ColumnEdit = this.Xóa;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 107;
            // 
            // Xóa
            // 
            this.Xóa.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.Xóa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Xóa.Name = "Xóa";
            this.Xóa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // spinEditQuanlity
            // 
            this.spinEditQuanlity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditQuanlity.Location = new System.Drawing.Point(446, 82);
            this.spinEditQuanlity.Name = "spinEditQuanlity";
            this.spinEditQuanlity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditQuanlity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinEditQuanlity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinEditQuanlity.Size = new System.Drawing.Size(50, 22);
            this.spinEditQuanlity.TabIndex = 2;
            // 
            // SalesOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 438);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_KhoGiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MaDon);
            this.Controls.Add(this.lud_Product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinEditQuanlity);
            this.Controls.Add(this.txt_NCC);
            this.Controls.Add(this.label1);
            this.Name = "SalesOrderAdd";
            this.Text = "Thêm đơn đặt hàng mua hàng";
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KhoGiao.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Info.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lud_Product.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sửa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xóa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuanlity.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit txt_NCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_MaDon;
        private DevExpress.XtraEditors.LookUpEdit txt_KhoGiao;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit lud_Product;
        private DevExpress.XtraGrid.GridControl gC_DanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit btn_Info;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Sửa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Xóa;
        private DevExpress.XtraEditors.SpinEdit spinEditQuanlity;
    }
}
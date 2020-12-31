﻿namespace StockManagement.Form.Supplier
{
    partial class ProductSupplier
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
            this.gc_danhsachSPNCC = new DevExpress.XtraEditors.GroupControl();
            this.gc_danhsach = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_timkiem = new DevExpress.XtraEditors.GroupControl();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_danhsachSPNCC)).BeginInit();
            this.gc_danhsachSPNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_danhsach)).BeginInit();
            this.gc_danhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_timkiem)).BeginInit();
            this.gc_timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_danhsachSPNCC
            // 
            this.gc_danhsachSPNCC.Controls.Add(this.gc_danhsach);
            this.gc_danhsachSPNCC.Controls.Add(this.gc_timkiem);
            this.gc_danhsachSPNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_danhsachSPNCC.Location = new System.Drawing.Point(0, 0);
            this.gc_danhsachSPNCC.Name = "gc_danhsachSPNCC";
            this.gc_danhsachSPNCC.Size = new System.Drawing.Size(781, 442);
            this.gc_danhsachSPNCC.TabIndex = 0;
            this.gc_danhsachSPNCC.Text = "Danh sách sản phẩm của NCC";
            // 
            // gc_danhsach
            // 
            this.gc_danhsach.Controls.Add(this.gridControl1);
            this.gc_danhsach.Location = new System.Drawing.Point(5, 163);
            this.gc_danhsach.Name = "gc_danhsach";
            this.gc_danhsach.Size = new System.Drawing.Size(771, 274);
            this.gc_danhsach.TabIndex = 1;
            this.gc_danhsach.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(7, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 239);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Mã SP NCC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Mã SP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Mã NCC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Chất lượng cao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Chất lượng thấp";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gc_timkiem
            // 
            this.gc_timkiem.Controls.Add(this.btn_timkiem);
            this.gc_timkiem.Controls.Add(this.btn_them);
            this.gc_timkiem.Controls.Add(this.textEdit1);
            this.gc_timkiem.Location = new System.Drawing.Point(5, 28);
            this.gc_timkiem.Name = "gc_timkiem";
            this.gc_timkiem.Size = new System.Drawing.Size(771, 129);
            this.gc_timkiem.TabIndex = 0;
            this.gc_timkiem.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(641, 61);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(94, 29);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(497, 61);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(22, 65);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(234, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // ProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_danhsachSPNCC);
            this.Name = "ProductSupplier";
            this.Size = new System.Drawing.Size(781, 442);
            ((System.ComponentModel.ISupportInitialize)(this.gc_danhsachSPNCC)).EndInit();
            this.gc_danhsachSPNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_danhsach)).EndInit();
            this.gc_danhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_timkiem)).EndInit();
            this.gc_timkiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gc_danhsachSPNCC;
        private DevExpress.XtraEditors.GroupControl gc_danhsach;
        private DevExpress.XtraEditors.GroupControl gc_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
namespace StockManagement.Form.Orders
{
    partial class PurchaseOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_NguoiXuLy = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_TenNCC = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaDon = new DevExpress.XtraEditors.TextEdit();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.txt_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiemKH = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gB_DanhSach = new System.Windows.Forms.GroupBox();
            this.tab_DanhSach = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gC_DanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PurchaseOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_NguoiXuLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.gB_DanhSach.SuspendLayout();
            this.tab_DanhSach.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gC_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbb_NguoiXuLy);
            this.groupBox1.Controls.Add(this.txt_TenNCC);
            this.groupBox1.Controls.Add(this.txt_MaDon);
            this.groupBox1.Controls.Add(this.btn_ThemKH);
            this.groupBox1.Controls.Add(this.txt_DenNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TuNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_TimKiemKH);
            this.groupBox1.Location = new System.Drawing.Point(5, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbb_NguoiXuLy
            // 
            this.cbb_NguoiXuLy.Location = new System.Drawing.Point(548, 30);
            this.cbb_NguoiXuLy.Name = "cbb_NguoiXuLy";
            this.cbb_NguoiXuLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_NguoiXuLy.Properties.NullText = "Người xử lý";
            this.cbb_NguoiXuLy.Size = new System.Drawing.Size(254, 22);
            this.cbb_NguoiXuLy.TabIndex = 11;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.EditValue = "Tên NCC";
            this.txt_TenNCC.Location = new System.Drawing.Point(297, 30);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(234, 22);
            this.txt_TenNCC.TabIndex = 10;
            // 
            // txt_MaDon
            // 
            this.txt_MaDon.EditValue = "Mã đơn ";
            this.txt_MaDon.Location = new System.Drawing.Point(51, 27);
            this.txt_MaDon.Name = "txt_MaDon";
            this.txt_MaDon.Size = new System.Drawing.Size(240, 22);
            this.txt_MaDon.TabIndex = 9;
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_ThemKH.Location = new System.Drawing.Point(908, 68);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(161, 23);
            this.btn_ThemKH.TabIndex = 8;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = true;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // txt_DenNgay
            // 
            this.txt_DenNgay.Location = new System.Drawing.Point(509, 74);
            this.txt_DenNgay.Name = "txt_DenNgay";
            this.txt_DenNgay.Size = new System.Drawing.Size(200, 23);
            this.txt_DenNgay.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày:";
            // 
            // txt_TuNgay
            // 
            this.txt_TuNgay.Location = new System.Drawing.Point(175, 73);
            this.txt_TuNgay.Name = "txt_TuNgay";
            this.txt_TuNgay.Size = new System.Drawing.Size(200, 23);
            this.txt_TuNgay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ ngày:";
            // 
            // btn_TimKiemKH
            // 
            this.btn_TimKiemKH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_TimKiemKH.Location = new System.Drawing.Point(908, 30);
            this.btn_TimKiemKH.Name = "btn_TimKiemKH";
            this.btn_TimKiemKH.Size = new System.Drawing.Size(161, 23);
            this.btn_TimKiemKH.TabIndex = 2;
            this.btn_TimKiemKH.Text = "Tìm kiếm";
            this.btn_TimKiemKH.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gB_DanhSach);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1087, 526);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Đặt hàng mua hàng";
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_DanhSach.Controls.Add(this.tab_DanhSach);
            this.gB_DanhSach.Location = new System.Drawing.Point(5, 151);
            this.gB_DanhSach.Name = "gB_DanhSach";
            this.gB_DanhSach.Size = new System.Drawing.Size(1077, 375);
            this.gB_DanhSach.TabIndex = 1;
            this.gB_DanhSach.TabStop = false;
            this.gB_DanhSach.Text = "Danh sách";
            // 
            // tab_DanhSach
            // 
            this.tab_DanhSach.Controls.Add(this.tabPage1);
            this.tab_DanhSach.Controls.Add(this.tabPage2);
            this.tab_DanhSach.Controls.Add(this.tabPage3);
            this.tab_DanhSach.Controls.Add(this.tabPage4);
            this.tab_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_DanhSach.Location = new System.Drawing.Point(3, 19);
            this.tab_DanhSach.Name = "tab_DanhSach";
            this.tab_DanhSach.SelectedIndex = 0;
            this.tab_DanhSach.Size = new System.Drawing.Size(1071, 353);
            this.tab_DanhSach.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gC_DanhSach);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đơn mới";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gC_DanhSach
            // 
            this.gC_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_DanhSach.Location = new System.Drawing.Point(3, 3);
            this.gC_DanhSach.MainView = this.gridView1;
            this.gC_DanhSach.Name = "gC_DanhSach";
            this.gC_DanhSach.Size = new System.Drawing.Size(1057, 318);
            this.gC_DanhSach.TabIndex = 0;
            this.gC_DanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PurchaseOrderCode,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.CreatedBy,
            this.btn_Action});
            this.gridView1.GridControl = this.gC_DanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // PurchaseOrderCode
            // 
            this.PurchaseOrderCode.Caption = "Mã đơn";
            this.PurchaseOrderCode.FieldName = "PurchaseOrderCode";
            this.PurchaseOrderCode.Name = "PurchaseOrderCode";
            this.PurchaseOrderCode.Visible = true;
            this.PurchaseOrderCode.VisibleIndex = 0;
            this.PurchaseOrderCode.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Khách hàng";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 158;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mặt hàng";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 133;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tổng tiền";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 164;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày đặt";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 164;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Caption = "Người xử lý";
            this.CreatedBy.FieldName = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Visible = true;
            this.CreatedBy.VisibleIndex = 5;
            this.CreatedBy.Width = 171;
            // 
            // btn_Action
            // 
            this.btn_Action.Caption = "Hành động";
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Visible = true;
            this.btn_Action.VisibleIndex = 6;
            this.btn_Action.Width = 167;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gC_DanhSach;
            this.gridView3.Name = "gridView3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đã tiếp nhận";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1048, 307);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã đơn";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 66;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Khách hàng";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 158;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Mặt hàng";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 133;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tổng tiền";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 164;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ngày đặt";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 164;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Người xử lý";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            this.gridColumn12.Width = 171;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Hành động";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            this.gridColumn13.Width = 167;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1054, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yêu cầu xuất kho";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1054, 313);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Đơn bị hủy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "PurchaseOrder";
            this.Size = new System.Drawing.Size(1087, 526);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_NguoiXuLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.gB_DanhSach.ResumeLayout(false);
            this.tab_DanhSach.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gC_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit cbb_NguoiXuLy;
        private DevExpress.XtraEditors.TextEdit txt_TenNCC;
        private DevExpress.XtraEditors.TextEdit txt_MaDon;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.DateTimePicker txt_DenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_TuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TimKiemKH;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.TabControl tab_DanhSach;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gC_DanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PurchaseOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Action;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedBy;
    }
}

﻿namespace StockManagement.Form
{
    partial class CustomerGroup
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGroup));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_ChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaNhom = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(865, 551);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Nhóm khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(3, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 376);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Sua,
            this.Xoa,
            this.ChiTiet});
            this.gridControl1.Size = new System.Drawing.Size(839, 354);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GroupCustomerCode,
            this.GroupCustomerName,
            this.CreatedDate,
            this.CreatedPerson,
            this.btn_Sua,
            this.btn_Xoa,
            this.btn_ChiTiet});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // GroupCustomerCode
            // 
            this.GroupCustomerCode.Caption = "Mã nhóm";
            this.GroupCustomerCode.FieldName = "GroupCustomerCode";
            this.GroupCustomerCode.MinWidth = 25;
            this.GroupCustomerCode.Name = "GroupCustomerCode";
            this.GroupCustomerCode.Visible = true;
            this.GroupCustomerCode.VisibleIndex = 0;
            this.GroupCustomerCode.Width = 80;
            // 
            // GroupCustomerName
            // 
            this.GroupCustomerName.Caption = "Tên nhóm";
            this.GroupCustomerName.FieldName = "GroupCustomerName";
            this.GroupCustomerName.MinWidth = 25;
            this.GroupCustomerName.Name = "GroupCustomerName";
            this.GroupCustomerName.Visible = true;
            this.GroupCustomerName.VisibleIndex = 1;
            this.GroupCustomerName.Width = 181;
            // 
            // CreatedDate
            // 
            this.CreatedDate.Caption = "Ngày tạo";
            this.CreatedDate.FieldName = "CreatedDate";
            this.CreatedDate.MinWidth = 25;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Visible = true;
            this.CreatedDate.VisibleIndex = 2;
            this.CreatedDate.Width = 167;
            // 
            // CreatedPerson
            // 
            this.CreatedPerson.Caption = "Người tạo";
            this.CreatedPerson.FieldName = "CreatedPerson";
            this.CreatedPerson.MinWidth = 25;
            this.CreatedPerson.Name = "CreatedPerson";
            this.CreatedPerson.Visible = true;
            this.CreatedPerson.VisibleIndex = 3;
            this.CreatedPerson.Width = 173;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Caption = "Sửa ";
            this.btn_Sua.ColumnEdit = this.Sua;
            this.btn_Sua.MinWidth = 25;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Visible = true;
            this.btn_Sua.VisibleIndex = 4;
            this.btn_Sua.Width = 65;
            // 
            // Sua
            // 
            this.Sua.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.Sua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Sua.Name = "Sua";
            this.Sua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.ColumnEdit = this.Xoa;
            this.btn_Xoa.MinWidth = 25;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Visible = true;
            this.btn_Xoa.VisibleIndex = 5;
            this.btn_Xoa.Width = 66;
            // 
            // Xoa
            // 
            this.Xoa.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.Xoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Xoa.Name = "Xoa";
            this.Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Caption = "Chi tiết";
            this.btn_ChiTiet.ColumnEdit = this.ChiTiet;
            this.btn_ChiTiet.MinWidth = 25;
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Visible = true;
            this.btn_ChiTiet.VisibleIndex = 6;
            this.btn_ChiTiet.Width = 67;
            // 
            // ChiTiet
            // 
            this.ChiTiet.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.ChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_MaNhom);
            this.groupBox1.Location = new System.Drawing.Point(1, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.Location = new System.Drawing.Point(653, 53);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(76, 26);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.Location = new System.Drawing.Point(746, 53);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(76, 26);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txt_MaNhom
            // 
            this.txt_MaNhom.EditValue = "Mã, tên nhóm";
            this.txt_MaNhom.Location = new System.Drawing.Point(33, 50);
            this.txt_MaNhom.Name = "txt_MaNhom";
            this.txt_MaNhom.Size = new System.Drawing.Size(484, 22);
            this.txt_MaNhom.TabIndex = 0;
            // 
            // CustomerGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "CustomerGroup";
            this.Size = new System.Drawing.Size(865, 551);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GroupCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn GroupCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedPerson;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Sua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Sua;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Xoa;
        private DevExpress.XtraGrid.Columns.GridColumn btn_ChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_MaNhom;
    }
}

namespace StockManagement.Form
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sửa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xóa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.Sửa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xóa)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Sửa,
            this.Xóa,
            this.ChiTiet});
            this.gridControl1.Size = new System.Drawing.Size(830, 347);
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
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhóm";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhóm";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 181;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày tạo";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 167;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Người tạo";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 173;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sửa ";
            this.gridColumn5.ColumnEdit = this.Sửa;
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 65;
            // 
            // Sửa
            // 
            this.Sửa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.Sửa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Sửa.Name = "Sửa";
            this.Sửa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Xóa";
            this.gridColumn6.ColumnEdit = this.Xóa;
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 66;
            // 
            // Xóa
            // 
            this.Xóa.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.Xóa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Xóa.Name = "Xóa";
            this.Xóa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Chi tiết";
            this.gridColumn7.ColumnEdit = this.ChiTiet;
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 67;
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
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_MaNhom);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(653, 53);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(76, 26);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
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
            this.txt_MaNhom.Size = new System.Drawing.Size(438, 22);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sửa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xóa)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Sửa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Xóa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_MaNhom;
    }
}


namespace StockManagement.Form.Employee
{
    partial class EmployeeList
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_MaNhom = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdentityCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CellPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaritalStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Avatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_ChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChitiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gC_DanhSach = new DevExpress.XtraGrid.GridControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_DanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.Location = new System.Drawing.Point(838, 53);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(117, 23);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_MaNhom
            // 
            this.txt_MaNhom.EditValue = "Mã, tên, sđt, email nhân viên";
            this.txt_MaNhom.Location = new System.Drawing.Point(35, 50);
            this.txt_MaNhom.Name = "txt_MaNhom";
            this.txt_MaNhom.Size = new System.Drawing.Size(600, 22);
            this.txt_MaNhom.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserId,
            this.FullName,
            this.UserName,
            this.IdentityCard,
            this.Address,
            this.gridColumn3,
            this.CellPhone,
            this.Email,
            this.Gender,
            this.MaritalStatus,
            this.Avatar,
            this.gridColumn7,
            this.btn_Xoa,
            this.btn_Sua,
            this.btn_ChiTiet});
            this.gridView1.GridControl = this.gC_DanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // UserId
            // 
            this.UserId.Caption = "Mã nhân viên";
            this.UserId.FieldName = "UserId";
            this.UserId.MinWidth = 25;
            this.UserId.Name = "UserId";
            this.UserId.Visible = true;
            this.UserId.VisibleIndex = 0;
            this.UserId.Width = 67;
            // 
            // FullName
            // 
            this.FullName.Caption = "Tên nhân viên";
            this.FullName.FieldName = "FullName";
            this.FullName.MinWidth = 25;
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            this.FullName.Width = 96;
            // 
            // UserName
            // 
            this.UserName.Caption = "Tên đăng nhập";
            this.UserName.FieldName = "UserName";
            this.UserName.MinWidth = 25;
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 2;
            this.UserName.Width = 114;
            // 
            // IdentityCard
            // 
            this.IdentityCard.Caption = "CMND";
            this.IdentityCard.FieldName = "IdentityCard";
            this.IdentityCard.MinWidth = 25;
            this.IdentityCard.Name = "IdentityCard";
            this.IdentityCard.Visible = true;
            this.IdentityCard.VisibleIndex = 3;
            this.IdentityCard.Width = 67;
            // 
            // Address
            // 
            this.Address.Caption = "Địa chỉ";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 25;
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 7;
            this.Address.Width = 92;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày sinh";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 74;
            // 
            // CellPhone
            // 
            this.CellPhone.Caption = "Số điện thoại";
            this.CellPhone.FieldName = "CellPhone";
            this.CellPhone.MinWidth = 25;
            this.CellPhone.Name = "CellPhone";
            this.CellPhone.Visible = true;
            this.CellPhone.VisibleIndex = 5;
            this.CellPhone.Width = 93;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 25;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 6;
            this.Email.Width = 83;
            // 
            // Gender
            // 
            this.Gender.Caption = "Giới tính";
            this.Gender.FieldName = "Gender";
            this.Gender.MinWidth = 25;
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 8;
            this.Gender.Width = 64;
            // 
            // MaritalStatus
            // 
            this.MaritalStatus.Caption = "Tình trạng hôn nhân";
            this.MaritalStatus.FieldName = "MaritalStatus";
            this.MaritalStatus.MinWidth = 25;
            this.MaritalStatus.Name = "MaritalStatus";
            this.MaritalStatus.Visible = true;
            this.MaritalStatus.VisibleIndex = 9;
            this.MaritalStatus.Width = 64;
            // 
            // Avatar
            // 
            this.Avatar.Caption = "Hình đại diện";
            this.Avatar.FieldName = "Avatar";
            this.Avatar.MinWidth = 25;
            this.Avatar.Name = "Avatar";
            this.Avatar.Visible = true;
            this.Avatar.VisibleIndex = 10;
            this.Avatar.Width = 64;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Loại NV";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 11;
            this.gridColumn7.Width = 46;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.ColumnEdit = this.btnXoa;
            this.btn_Xoa.MinWidth = 25;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Visible = true;
            this.btn_Xoa.VisibleIndex = 12;
            this.btn_Xoa.Width = 94;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Caption = "Sửa";
            this.btn_Sua.ColumnEdit = this.btnSua;
            this.btn_Sua.MinWidth = 25;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Visible = true;
            this.btn_Sua.VisibleIndex = 13;
            this.btn_Sua.Width = 94;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSua.Name = "btnSua";
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Caption = "Chi tiết";
            this.btn_ChiTiet.ColumnEdit = this.btnChitiet;
            this.btn_ChiTiet.MinWidth = 25;
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Visible = true;
            this.btn_ChiTiet.VisibleIndex = 14;
            this.btn_ChiTiet.Width = 94;
            // 
            // btnChitiet
            // 
            this.btnChitiet.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.btnChitiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gC_DanhSach
            // 
            this.gC_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_DanhSach.Location = new System.Drawing.Point(3, 19);
            this.gC_DanhSach.MainView = this.gridView1;
            this.gC_DanhSach.Name = "gC_DanhSach";
            this.gC_DanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChitiet,
            this.btnSua,
            this.btnXoa});
            this.gC_DanhSach.Size = new System.Drawing.Size(1072, 376);
            this.gC_DanhSach.TabIndex = 0;
            this.gC_DanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gC_DanhSach);
            this.groupBox2.Location = new System.Drawing.Point(5, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 398);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1088, 569);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_MaNhom);
            this.groupBox1.Location = new System.Drawing.Point(5, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.Location = new System.Drawing.Point(978, 53);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "EmployeeList";
            this.Size = new System.Drawing.Size(1088, 569);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_DanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private DevExpress.XtraEditors.TextEdit txt_MaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn CellPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn UserId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gC_DanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Them;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn IdentityCard;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn MaritalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn Avatar;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Sua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn btn_ChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChitiet;
    }
}


namespace StockManagement.Form.Customer
{
    partial class AddCustomerList
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_LastUpdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.cbb_DiaChi = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.dtp_CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_MaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.cb_GroupCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.stockManagementDataSet = new StockManagement.StockManagementDataSet();
            this.groupCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupCustomerTableAdapter = new StockManagement.StockManagementDataSetTableAdapters.GroupCustomerTableAdapter();
            this.stockManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressCustomerTableAdapter = new StockManagement.StockManagementDataSetTableAdapters.AddressCustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GroupCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cập nhật lần cuối:";
            // 
            // dtp_LastUpdate
            // 
            this.dtp_LastUpdate.Location = new System.Drawing.Point(409, 178);
            this.dtp_LastUpdate.Name = "dtp_LastUpdate";
            this.dtp_LastUpdate.Size = new System.Drawing.Size(200, 23);
            this.dtp_LastUpdate.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ngày tạo:";
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Location = new System.Drawing.Point(517, 127);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(108, 35);
            this.btn_ChiTiet.TabIndex = 44;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = true;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // cbb_DiaChi
            // 
            this.cbb_DiaChi.Location = new System.Drawing.Point(15, 133);
            this.cbb_DiaChi.Name = "cbb_DiaChi";
            this.cbb_DiaChi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_DiaChi.Properties.DataSource = this.stockManagementDataSet;
            this.cbb_DiaChi.Properties.DisplayMember = "AddressCustomerId";
            this.cbb_DiaChi.Properties.NullText = "Nhóm";
            this.cbb_DiaChi.Properties.ValueMember = "AddressCustomerId";
            this.cbb_DiaChi.Size = new System.Drawing.Size(491, 22);
            this.cbb_DiaChi.TabIndex = 43;
            // 
            // txt_Email
            // 
            this.txt_Email.EditValue = "Email";
            this.txt_Email.Location = new System.Drawing.Point(307, 81);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(173, 22);
            this.txt_Email.TabIndex = 41;
            // 
            // dtp_CreatedDate
            // 
            this.dtp_CreatedDate.Location = new System.Drawing.Point(101, 178);
            this.dtp_CreatedDate.Name = "dtp_CreatedDate";
            this.dtp_CreatedDate.Size = new System.Drawing.Size(200, 23);
            this.dtp_CreatedDate.TabIndex = 40;
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.Location = new System.Drawing.Point(91, 80);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(200, 23);
            this.dtp_Birthday.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ngày sinh:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.EditValue = "Số điện thoại";
            this.txt_SDT.Location = new System.Drawing.Point(433, 32);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(192, 22);
            this.txt_SDT.TabIndex = 37;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.EditValue = "Tên khách hàng";
            this.txt_TenKhachHang.Location = new System.Drawing.Point(183, 32);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(244, 22);
            this.txt_TenKhachHang.TabIndex = 36;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(534, 359);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 36);
            this.btn_Luu.TabIndex = 35;
            this.btn_Luu.Text = "Lưu lại";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.EditValue = "Mã khách hàng";
            this.txt_MaKhachHang.Location = new System.Drawing.Point(15, 32);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(162, 22);
            this.txt_MaKhachHang.TabIndex = 34;
            // 
            // cb_GroupCustomer
            // 
            this.cb_GroupCustomer.Location = new System.Drawing.Point(493, 82);
            this.cb_GroupCustomer.Name = "cb_GroupCustomer";
            this.cb_GroupCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_GroupCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupCustomerCode", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupCustomerName", "Tên nhóm")});
            this.cb_GroupCustomer.Properties.DataSource = this.groupCustomerBindingSource;
            this.cb_GroupCustomer.Properties.DisplayMember = "GroupCustomerName";
            this.cb_GroupCustomer.Properties.NullText = "Nhóm";
            this.cb_GroupCustomer.Properties.ValueMember = "GroupCustomerId";
            this.cb_GroupCustomer.Size = new System.Drawing.Size(125, 22);
            this.cb_GroupCustomer.TabIndex = 42;
            // 
            // stockManagementDataSet
            // 
            this.stockManagementDataSet.DataSetName = "StockManagementDataSet";
            this.stockManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupCustomerBindingSource
            // 
            this.groupCustomerBindingSource.DataMember = "GroupCustomer";
            this.groupCustomerBindingSource.DataSource = this.stockManagementDataSet;
            // 
            // groupCustomerTableAdapter
            // 
            this.groupCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // stockManagementDataSetBindingSource
            // 
            this.stockManagementDataSetBindingSource.DataSource = this.stockManagementDataSet;
            this.stockManagementDataSetBindingSource.Position = 0;
            // 
            // addressCustomerBindingSource
            // 
            this.addressCustomerBindingSource.DataMember = "AddressCustomer";
            this.addressCustomerBindingSource.DataSource = this.stockManagementDataSetBindingSource;
            // 
            // addressCustomerTableAdapter
            // 
            this.addressCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // AddCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_LastUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ChiTiet);
            this.Controls.Add(this.cbb_DiaChi);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.dtp_CreatedDate);
            this.Controls.Add(this.dtp_Birthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_MaKhachHang);
            this.Controls.Add(this.cb_GroupCustomer);
            this.Name = "AddCustomerList";
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.AddCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbb_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GroupCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_LastUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ChiTiet;
        private DevExpress.XtraEditors.LookUpEdit cbb_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private System.Windows.Forms.DateTimePicker dtp_CreatedDate;
        private System.Windows.Forms.DateTimePicker dtp_Birthday;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.TextEdit txt_TenKhachHang;
        private System.Windows.Forms.Button btn_Luu;
        private DevExpress.XtraEditors.TextEdit txt_MaKhachHang;
        private DevExpress.XtraEditors.LookUpEdit cb_GroupCustomer;
        private StockManagementDataSet stockManagementDataSet;
        private System.Windows.Forms.BindingSource groupCustomerBindingSource;
        private StockManagementDataSetTableAdapters.GroupCustomerTableAdapter groupCustomerTableAdapter;
        private System.Windows.Forms.BindingSource stockManagementDataSetBindingSource;
        private System.Windows.Forms.BindingSource addressCustomerBindingSource;
        private StockManagementDataSetTableAdapters.AddressCustomerTableAdapter addressCustomerTableAdapter;
    }
}
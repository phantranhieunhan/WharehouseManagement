
namespace StockManagement.Form.Customer
{
    partial class AddressCustomerList
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
            this.gv_DiaChiDaLuu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.glk_Province = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_Detail = new DevExpress.XtraEditors.TextEdit();
            this.cbb_PhuongXa = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_QuanHuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_TinhTP = new DevExpress.XtraEditors.LookUpEdit();
            this.bt_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DiaChiDaLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glk_Province)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Detail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_PhuongXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_QuanHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TinhTP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_DiaChiDaLuu
            // 
            this.gv_DiaChiDaLuu.Location = new System.Drawing.Point(4, 190);
            this.gv_DiaChiDaLuu.MainView = this.gridView1;
            this.gv_DiaChiDaLuu.Name = "gv_DiaChiDaLuu";
            this.gv_DiaChiDaLuu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_Sua,
            this.btn_Xoa,
            this.glk_Province});
            this.gv_DiaChiDaLuu.Size = new System.Drawing.Size(801, 268);
            this.gv_DiaChiDaLuu.TabIndex = 11;
            this.gv_DiaChiDaLuu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.gv_DiaChiDaLuu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tỉnh/ Thành phố";
            this.gridColumn1.FieldName = "ProvinceName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Quận/ huyện";
            this.gridColumn2.FieldName = "DistrictName";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Phường/ xã";
            this.gridColumn3.FieldName = "WardName";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cụ thể";
            this.gridColumn4.FieldName = "Detail";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sửa";
            this.gridColumn5.ColumnEdit = this.btn_Sua;
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // btn_Sua
            // 
            this.btn_Sua.AutoHeight = false;
            this.btn_Sua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Xóa";
            this.gridColumn6.ColumnEdit = this.btn_Xoa;
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoHeight = false;
            this.btn_Xoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // glk_Province
            // 
            this.glk_Province.AutoHeight = false;
            this.glk_Province.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glk_Province.Name = "glk_Province";
            this.glk_Province.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã tỉnh thành";
            this.gridColumn7.FieldName = "id";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên tỉnh thành";
            this.gridColumn8.FieldName = "name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(683, 475);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 49);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu lại";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_Detail
            // 
            this.txt_Detail.EditValue = "Địa chỉ cụ thể";
            this.txt_Detail.Location = new System.Drawing.Point(40, 76);
            this.txt_Detail.Name = "txt_Detail";
            this.txt_Detail.Size = new System.Drawing.Size(718, 22);
            this.txt_Detail.TabIndex = 9;
            // 
            // cbb_PhuongXa
            // 
            this.cbb_PhuongXa.Location = new System.Drawing.Point(566, 26);
            this.cbb_PhuongXa.Name = "cbb_PhuongXa";
            this.cbb_PhuongXa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_PhuongXa.Properties.NullText = "Phường/ xã";
            this.cbb_PhuongXa.Size = new System.Drawing.Size(192, 22);
            this.cbb_PhuongXa.TabIndex = 8;
            this.cbb_PhuongXa.EditValueChanged += new System.EventHandler(this.cbb_PhuongXa_EditValueChanged);
            // 
            // cbb_QuanHuyen
            // 
            this.cbb_QuanHuyen.Location = new System.Drawing.Point(311, 26);
            this.cbb_QuanHuyen.Name = "cbb_QuanHuyen";
            this.cbb_QuanHuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_QuanHuyen.Properties.NullText = "Quận/ huyện";
            this.cbb_QuanHuyen.Size = new System.Drawing.Size(192, 22);
            this.cbb_QuanHuyen.TabIndex = 7;
            this.cbb_QuanHuyen.EditValueChanged += new System.EventHandler(this.cbb_QuanHuyen_EditValueChanged);
            // 
            // cbb_TinhTP
            // 
            this.cbb_TinhTP.Location = new System.Drawing.Point(40, 26);
            this.cbb_TinhTP.Name = "cbb_TinhTP";
            this.cbb_TinhTP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_TinhTP.Properties.NullText = "Tỉnh/ thành phố";
            this.cbb_TinhTP.Size = new System.Drawing.Size(192, 22);
            this.cbb_TinhTP.TabIndex = 6;
            this.cbb_TinhTP.EditValueChanged += new System.EventHandler(this.cbb_TinhTP_EditValueChanged);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(683, 120);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 49);
            this.bt_Add.TabIndex = 12;
            this.bt_Add.Text = "Thêm";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // AddressCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 536);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.gv_DiaChiDaLuu);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_Detail);
            this.Controls.Add(this.cbb_PhuongXa);
            this.Controls.Add(this.cbb_QuanHuyen);
            this.Controls.Add(this.cbb_TinhTP);
            this.Name = "AddressCustomerList";
            this.Text = "Danh sách địa chỉ khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gv_DiaChiDaLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glk_Province)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Detail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_PhuongXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_QuanHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TinhTP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gv_DiaChiDaLuu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private DevExpress.XtraEditors.TextEdit txt_Detail;
        private DevExpress.XtraEditors.LookUpEdit cbb_PhuongXa;
        private DevExpress.XtraEditors.LookUpEdit cbb_QuanHuyen;
        private DevExpress.XtraEditors.LookUpEdit cbb_TinhTP;
        private System.Windows.Forms.Button bt_Add;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glk_Province;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}
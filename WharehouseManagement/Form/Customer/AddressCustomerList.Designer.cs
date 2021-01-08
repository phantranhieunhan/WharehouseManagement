
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cbb_PhuongXa = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_QuanHuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_TinhThanhPho = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_PhuongXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_QuanHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TinhThanhPho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 190);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_Sua,
            this.btn_Xoa});
            this.gridControl1.Size = new System.Drawing.Size(801, 268);
            this.gridControl1.TabIndex = 11;
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
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.Caption = "Tỉnh/ Thành phố";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.Caption = "Quận/ huyện";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.Caption = "Phường/ xã";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.Caption = "Cụ thể";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
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
            this.gridColumn6.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
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
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Luu.Location = new System.Drawing.Point(638, 126);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(120, 40);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu lại";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Địa chỉ cụ thể";
            this.textEdit1.Location = new System.Drawing.Point(40, 76);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(718, 22);
            this.textEdit1.TabIndex = 9;
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
            // 
            // cbb_TinhThanhPho
            // 
            this.cbb_TinhThanhPho.Location = new System.Drawing.Point(40, 26);
            this.cbb_TinhThanhPho.Name = "cbb_TinhThanhPho";
            this.cbb_TinhThanhPho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_TinhThanhPho.Properties.NullText = "Tỉnh/ thành phố";
            this.cbb_TinhThanhPho.Size = new System.Drawing.Size(192, 22);
            this.cbb_TinhThanhPho.TabIndex = 6;
            // 
            // AddressCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 485);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.cbb_PhuongXa);
            this.Controls.Add(this.cbb_QuanHuyen);
            this.Controls.Add(this.cbb_TinhThanhPho);
            this.Name = "AddressCustomerList";
            this.Text = "Danh sách địa chỉ khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_PhuongXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_QuanHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TinhThanhPho.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit cbb_PhuongXa;
        private DevExpress.XtraEditors.LookUpEdit cbb_QuanHuyen;
        private DevExpress.XtraEditors.LookUpEdit cbb_TinhThanhPho;
    }
}
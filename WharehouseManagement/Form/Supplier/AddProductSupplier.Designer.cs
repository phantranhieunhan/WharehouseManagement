namespace StockManagement.Form.Supplier
{
    partial class AddProductSupplier
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NCC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_SP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gC_themncc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_themncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhà cung cấp";
            // 
            // txt_NCC
            // 
            this.txt_NCC.Location = new System.Drawing.Point(146, 31);
            this.txt_NCC.Name = "txt_NCC";
            this.txt_NCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NCC.Size = new System.Drawing.Size(125, 22);
            this.txt_NCC.TabIndex = 1;
            // 
            // txt_SP
            // 
            this.txt_SP.Location = new System.Drawing.Point(615, 34);
            this.txt_SP.Name = "txt_SP";
            this.txt_SP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_SP.Size = new System.Drawing.Size(202, 22);
            this.txt_SP.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(479, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sản phẩm";
            // 
            // gC_themncc
            // 
            this.gC_themncc.Location = new System.Drawing.Point(44, 114);
            this.gC_themncc.MainView = this.gridView1;
            this.gC_themncc.Name = "gC_themncc";
            this.gC_themncc.Size = new System.Drawing.Size(773, 360);
            this.gC_themncc.TabIndex = 4;
            this.gC_themncc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gC_themncc;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.FieldName = "Mã SP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.FieldName = "Tên SP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.FieldName = "Delete";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_them.Appearance.Options.UseBackColor = true;
            this.btn_them.Location = new System.Drawing.Point(723, 481);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            // 
            // AddProductSupplier
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.gC_themncc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_SP);
            this.Controls.Add(this.txt_NCC);
            this.Controls.Add(this.labelControl1);
            this.Name = "AddProductSupplier";
            this.Text = "Thêm danh sách sản phẩm NCC";
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_themncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txt_NCC;
        private DevExpress.XtraEditors.ComboBoxEdit txt_SP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gC_themncc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_them;
    }
}
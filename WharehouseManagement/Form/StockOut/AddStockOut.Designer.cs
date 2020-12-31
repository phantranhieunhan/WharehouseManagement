namespace StockManagement.Form.StockOut
{
	partial class AddStockOut
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
            this.cbb_KhoDi1 = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_LoaiXuatKho = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_NCC = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_KhoDi2 = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_LyDo = new DevExpress.XtraEditors.TextEdit();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_LoaiXuatKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_NCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LyDo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_KhoDi1
            // 
            this.cbb_KhoDi1.Location = new System.Drawing.Point(68, 51);
            this.cbb_KhoDi1.Name = "cbb_KhoDi1";
            this.cbb_KhoDi1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_KhoDi1.Properties.NullText = "Kho đi";
            this.cbb_KhoDi1.Size = new System.Drawing.Size(205, 22);
            this.cbb_KhoDi1.TabIndex = 0;
            // 
            // cbb_LoaiXuatKho
            // 
            this.cbb_LoaiXuatKho.Location = new System.Drawing.Point(426, 51);
            this.cbb_LoaiXuatKho.Name = "cbb_LoaiXuatKho";
            this.cbb_LoaiXuatKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_LoaiXuatKho.Properties.NullText = "Loại xuất kho";
            this.cbb_LoaiXuatKho.Size = new System.Drawing.Size(205, 22);
            this.cbb_LoaiXuatKho.TabIndex = 1;
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.Location = new System.Drawing.Point(68, 145);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_NCC.Properties.NullText = "Nhà cung cấp";
            this.cbb_NCC.Size = new System.Drawing.Size(205, 22);
            this.cbb_NCC.TabIndex = 2;
            // 
            // cbb_KhoDi2
            // 
            this.cbb_KhoDi2.Location = new System.Drawing.Point(426, 145);
            this.cbb_KhoDi2.Name = "cbb_KhoDi2";
            this.cbb_KhoDi2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_KhoDi2.Properties.NullText = "Kho đi";
            this.cbb_KhoDi2.Size = new System.Drawing.Size(205, 22);
            this.cbb_KhoDi2.TabIndex = 3;
            // 
            // txt_LyDo
            // 
            this.txt_LyDo.EditValue = "Lý do trả hoặc hủy sản phẩm";
            this.txt_LyDo.Location = new System.Drawing.Point(68, 252);
            this.txt_LyDo.Name = "txt_LyDo";
            this.txt_LyDo.Size = new System.Drawing.Size(563, 22);
            this.txt_LyDo.TabIndex = 4;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(565, 486);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // AddStockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 544);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_LyDo);
            this.Controls.Add(this.cbb_KhoDi2);
            this.Controls.Add(this.cbb_NCC);
            this.Controls.Add(this.cbb_LoaiXuatKho);
            this.Controls.Add(this.cbb_KhoDi1);
            this.Name = "AddStockOut";
            this.Text = "Thêm phiếu xuất kho";
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_LoaiXuatKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_NCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LyDo.Properties)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbb_KhoDi1;
        private DevExpress.XtraEditors.LookUpEdit cbb_LoaiXuatKho;
        private DevExpress.XtraEditors.LookUpEdit cbb_NCC;
        private DevExpress.XtraEditors.LookUpEdit cbb_KhoDi2;
        private DevExpress.XtraEditors.TextEdit txt_LyDo;
        private System.Windows.Forms.Button btn_Them;
    }
}
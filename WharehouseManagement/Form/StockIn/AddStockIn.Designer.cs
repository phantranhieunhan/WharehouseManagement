
namespace StockManagement.Form.StockIn
{
    partial class AddStockIn
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_LyDo = new DevExpress.XtraEditors.TextEdit();
            this.cbb_KhoDi2 = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_NCC = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_LoaiXuatKho = new DevExpress.XtraEditors.LookUpEdit();
            this.cbb_KhoDi1 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_NCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_LoaiXuatKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(553, 471);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 41);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txt_LyDo
            // 
            this.txt_LyDo.EditValue = "Lý do trả hoặc hủy sản phẩm";
            this.txt_LyDo.Location = new System.Drawing.Point(56, 255);
            this.txt_LyDo.Name = "txt_LyDo";
            this.txt_LyDo.Size = new System.Drawing.Size(563, 22);
            this.txt_LyDo.TabIndex = 10;
            // 
            // cbb_KhoDi2
            // 
            this.cbb_KhoDi2.Location = new System.Drawing.Point(414, 148);
            this.cbb_KhoDi2.Name = "cbb_KhoDi2";
            this.cbb_KhoDi2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_KhoDi2.Properties.NullText = "Kho đi";
            this.cbb_KhoDi2.Size = new System.Drawing.Size(205, 22);
            this.cbb_KhoDi2.TabIndex = 9;
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.Location = new System.Drawing.Point(56, 148);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_NCC.Properties.NullText = "Nhà cung cấp";
            this.cbb_NCC.Size = new System.Drawing.Size(205, 22);
            this.cbb_NCC.TabIndex = 8;
            // 
            // cbb_LoaiXuatKho
            // 
            this.cbb_LoaiXuatKho.Location = new System.Drawing.Point(414, 54);
            this.cbb_LoaiXuatKho.Name = "cbb_LoaiXuatKho";
            this.cbb_LoaiXuatKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_LoaiXuatKho.Properties.NullText = "Loại xuất kho";
            this.cbb_LoaiXuatKho.Size = new System.Drawing.Size(205, 22);
            this.cbb_LoaiXuatKho.TabIndex = 7;
            // 
            // cbb_KhoDi1
            // 
            this.cbb_KhoDi1.Location = new System.Drawing.Point(56, 54);
            this.cbb_KhoDi1.Name = "cbb_KhoDi1";
            this.cbb_KhoDi1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_KhoDi1.Properties.NullText = "Kho đi";
            this.cbb_KhoDi1.Size = new System.Drawing.Size(205, 22);
            this.cbb_KhoDi1.TabIndex = 6;
            // 
            // AddStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 567);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_LyDo);
            this.Controls.Add(this.cbb_KhoDi2);
            this.Controls.Add(this.cbb_NCC);
            this.Controls.Add(this.cbb_LoaiXuatKho);
            this.Controls.Add(this.cbb_KhoDi1);
            this.Name = "AddStockIn";
            this.Text = "Thêm phiếu nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.txt_LyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_NCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_LoaiXuatKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_KhoDi1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_LyDo;
        private DevExpress.XtraEditors.LookUpEdit cbb_KhoDi2;
        private DevExpress.XtraEditors.LookUpEdit cbb_NCC;
        private DevExpress.XtraEditors.LookUpEdit cbb_LoaiXuatKho;
        private DevExpress.XtraEditors.LookUpEdit cbb_KhoDi1;
    }
}
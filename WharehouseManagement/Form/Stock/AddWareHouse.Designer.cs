namespace StockManagement.Form.Stock
{
    partial class AddWareHouse
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
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.txt_MaKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.txt_DiaChiKH = new DevExpress.XtraEditors.TextEdit();
            this.lb_DiaChiKH = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChiKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Location = new System.Drawing.Point(12, 38);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(92, 17);
            this.lb_MaKH.TabIndex = 0;
            this.lb_MaKH.Text = "Mã kho hàng:";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(117, 33);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(138, 22);
            this.txt_MaKH.TabIndex = 1;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(445, 33);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(211, 22);
            this.txt_TenKH.TabIndex = 3;
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(331, 36);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(98, 17);
            this.lb_TenKH.TabIndex = 2;
            this.lb_TenKH.Text = "Tên kho hàng:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(117, 92);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(225, 22);
            this.txt_SDT.TabIndex = 5;
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(12, 95);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(92, 17);
            this.lb_SDT.TabIndex = 4;
            this.lb_SDT.Text = "Số điện thoại:";
            // 
            // txt_DiaChiKH
            // 
            this.txt_DiaChiKH.Location = new System.Drawing.Point(117, 145);
            this.txt_DiaChiKH.Name = "txt_DiaChiKH";
            this.txt_DiaChiKH.Size = new System.Drawing.Size(539, 22);
            this.txt_DiaChiKH.TabIndex = 7;
            // 
            // lb_DiaChiKH
            // 
            this.lb_DiaChiKH.AutoSize = true;
            this.lb_DiaChiKH.Location = new System.Drawing.Point(12, 148);
            this.lb_DiaChiKH.Name = "lb_DiaChiKH";
            this.lb_DiaChiKH.Size = new System.Drawing.Size(80, 17);
            this.lb_DiaChiKH.TabIndex = 6;
            this.lb_DiaChiKH.Text = "Địa chỉ kho:";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(479, 206);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(581, 206);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // AddWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_DiaChiKH);
            this.Controls.Add(this.lb_DiaChiKH);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.lb_SDT);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.lb_MaKH);
            this.Name = "AddWareHouse";
            this.Text = "Thêm kho hàng";
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChiKH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MaKH;
        private DevExpress.XtraEditors.TextEdit txt_MaKH;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private System.Windows.Forms.Label lb_TenKH;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private System.Windows.Forms.Label lb_SDT;
        private DevExpress.XtraEditors.TextEdit txt_DiaChiKH;
        private System.Windows.Forms.Label lb_DiaChiKH;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
    }
}
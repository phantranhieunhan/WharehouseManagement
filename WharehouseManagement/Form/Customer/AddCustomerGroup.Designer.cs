
namespace StockManagement.Form.Customer
{
    partial class AddCustomerGroup
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
            this.txt_TenNhom = new DevExpress.XtraEditors.TextEdit();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_MaNhom = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenNhom
            // 
            this.txt_TenNhom.EditValue = "Tên nhóm";
            this.txt_TenNhom.Location = new System.Drawing.Point(335, 45);
            this.txt_TenNhom.Name = "txt_TenNhom";
            this.txt_TenNhom.Size = new System.Drawing.Size(192, 22);
            this.txt_TenNhom.TabIndex = 6;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(482, 155);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(120, 40);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu lại";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // txt_MaNhom
            // 
            this.txt_MaNhom.EditValue = "Mã nhóm";
            this.txt_MaNhom.Location = new System.Drawing.Point(59, 45);
            this.txt_MaNhom.Name = "txt_MaNhom";
            this.txt_MaNhom.Size = new System.Drawing.Size(192, 22);
            this.txt_MaNhom.TabIndex = 4;
            // 
            // AddCustomerGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 233);
            this.Controls.Add(this.txt_TenNhom);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_MaNhom);
            this.Name = "AddCustomerGroup";
            this.Text = "Thêm nhóm khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TenNhom;
        private System.Windows.Forms.Button btn_Luu;
        private DevExpress.XtraEditors.TextEdit txt_MaNhom;
    }
}
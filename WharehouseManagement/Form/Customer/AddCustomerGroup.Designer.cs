
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenNhom
            // 
            this.txt_TenNhom.EditValue = "";
            this.txt_TenNhom.Location = new System.Drawing.Point(101, 76);
            this.txt_TenNhom.Name = "txt_TenNhom";
            this.txt_TenNhom.Size = new System.Drawing.Size(501, 22);
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
            this.txt_MaNhom.EditValue = "";
            this.txt_MaNhom.Location = new System.Drawing.Point(101, 23);
            this.txt_MaNhom.Name = "txt_MaNhom";
            this.txt_MaNhom.Size = new System.Drawing.Size(501, 22);
            this.txt_MaNhom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên nhóm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã nhóm:";
            // 
            // AddCustomerGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenNhom);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_MaNhom);
            this.Name = "AddCustomerGroup";
            this.Text = "Thêm nhóm khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TenNhom;
        private System.Windows.Forms.Button btn_Luu;
        private DevExpress.XtraEditors.TextEdit txt_MaNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
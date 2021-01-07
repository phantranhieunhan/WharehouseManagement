namespace StockManagement.Form
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_Login = new DevExpress.XtraEditors.LabelControl();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bt_submit = new DevExpress.XtraEditors.SimpleButton();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Login.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lb_Login.Appearance.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Appearance.ForeColor = System.Drawing.Color.White;
            this.lb_Login.Appearance.Options.UseBackColor = true;
            this.lb_Login.Appearance.Options.UseFont = true;
            this.lb_Login.Appearance.Options.UseForeColor = true;
            this.lb_Login.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lb_Login.IndentBetweenImageAndText = 10;
            this.lb_Login.Location = new System.Drawing.Point(230, 87);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Padding = new System.Windows.Forms.Padding(10);
            this.lb_Login.Size = new System.Drawing.Size(369, 117);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "Đăng nhập";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(243, 61);
            this.txt_username.Name = "txt_username";
            this.txt_username.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Properties.Appearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Properties.Appearance.Options.UseBackColor = true;
            this.txt_username.Properties.Appearance.Options.UseBorderColor = true;
            this.txt_username.Properties.Appearance.Options.UseFont = true;
            this.txt_username.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_username.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.txt_username.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txt_username.Size = new System.Drawing.Size(203, 28);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(243, 114);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.Options.UseBackColor = true;
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txt_password.Properties.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(203, 28);
            this.txt_password.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(103, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 24);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên đăng nhập";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(103, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // bt_submit
            // 
            this.bt_submit.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_submit.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.bt_submit.Appearance.Options.UseBackColor = true;
            this.bt_submit.Appearance.Options.UseFont = true;
            this.bt_submit.Appearance.Options.UseForeColor = true;
            this.bt_submit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.bt_submit.Location = new System.Drawing.Point(185, 206);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(152, 43);
            this.bt_submit.TabIndex = 3;
            this.bt_submit.Text = "Đăng nhập";
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // imageSlider1
            // 
            this.imageSlider1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imageSlider1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.imageSlider1.Appearance.Options.UseBackColor = true;
            this.imageSlider1.Appearance.Options.UseForeColor = true;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(65, 64);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(32, 24);
            this.imageSlider1.TabIndex = 4;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // imageSlider2
            // 
            this.imageSlider2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imageSlider2.Appearance.Options.UseBackColor = true;
            this.imageSlider2.CurrentImageIndex = 0;
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images"))));
            this.imageSlider2.Location = new System.Drawing.Point(65, 118);
            this.imageSlider2.Name = "imageSlider2";
            this.imageSlider2.Size = new System.Drawing.Size(32, 24);
            this.imageSlider2.TabIndex = 4;
            this.imageSlider2.Text = "imageSlider1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bt_submit);
            this.groupBox1.Controls.Add(this.imageSlider2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.imageSlider1);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Location = new System.Drawing.Point(153, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(823, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lb_Login;
        private DevExpress.XtraEditors.TextEdit txt_username;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bt_submit;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider2;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
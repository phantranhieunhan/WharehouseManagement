namespace StockManagement.Form.Orders
{
    partial class PurchaseOrderProductDetail
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.lb_MaSP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_TongSoLuong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(15, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(708, 281);
            this.gridControl1.TabIndex = 12;
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
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.Caption = "Mã Kho";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 77;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.Caption = "Tên Kho";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 182;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.Caption = "Cảnh báo Max";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 162;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.Caption = "Cảnh báo Min";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 153;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.Caption = "Số lượng";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 111;
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoSize = true;
            this.lb_TenSP.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenSP.Location = new System.Drawing.Point(415, 9);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(121, 17);
            this.lb_TenSP.TabIndex = 11;
            this.lb_TenSP.Text = "Đậu phộng rang";
            // 
            // lb_MaSP
            // 
            this.lb_MaSP.AutoSize = true;
            this.lb_MaSP.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaSP.Location = new System.Drawing.Point(125, 9);
            this.lb_MaSP.Name = "lb_MaSP";
            this.lb_MaSP.Size = new System.Drawing.Size(44, 17);
            this.lb_MaSP.TabIndex = 10;
            this.lb_MaSP.Text = "SP01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Location = new System.Drawing.Point(546, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Chấp nhận với số lượng này";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lb_TongSoLuong
            // 
            this.lb_TongSoLuong.AutoSize = true;
            this.lb_TongSoLuong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongSoLuong.Location = new System.Drawing.Point(222, 344);
            this.lb_TongSoLuong.Name = "lb_TongSoLuong";
            this.lb_TongSoLuong.Size = new System.Drawing.Size(26, 17);
            this.lb_TongSoLuong.TabIndex = 14;
            this.lb_TongSoLuong.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tổng số lượng khuyên nhập:";
            // 
            // PurchaseOrderProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lb_TenSP);
            this.Controls.Add(this.lb_MaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_TongSoLuong);
            this.Controls.Add(this.label5);
            this.Name = "PurchaseOrderProductDetail";
            this.Text = "Chi tiết đơn đặt hàng bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label lb_TenSP;
        private System.Windows.Forms.Label lb_MaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_TongSoLuong;
        private System.Windows.Forms.Label label5;
    }
}
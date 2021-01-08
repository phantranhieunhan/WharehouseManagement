namespace StockManagement.Form.Orders
{
    partial class SalesOrderProductDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_MaSP = new System.Windows.Forms.Label();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TongSoLuong = new System.Windows.Forms.Label();
            this.btn_ChapNhan = new System.Windows.Forms.Button();
            this.Gc_ProductOnStock = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaxQuanlity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MinQuanlity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_ProductOnStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // lb_MaSP
            // 
            this.lb_MaSP.AutoSize = true;
            this.lb_MaSP.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaSP.Location = new System.Drawing.Point(153, 27);
            this.lb_MaSP.Name = "lb_MaSP";
            this.lb_MaSP.Size = new System.Drawing.Size(44, 17);
            this.lb_MaSP.TabIndex = 2;
            this.lb_MaSP.Text = "SP01";
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoSize = true;
            this.lb_TenSP.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenSP.Location = new System.Drawing.Point(443, 27);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(121, 17);
            this.lb_TenSP.TabIndex = 3;
            this.lb_TenSP.Text = "Đậu phộng rang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng số lượng khuyên nhập:";
            // 
            // lb_TongSoLuong
            // 
            this.lb_TongSoLuong.AutoSize = true;
            this.lb_TongSoLuong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongSoLuong.Location = new System.Drawing.Point(233, 374);
            this.lb_TongSoLuong.Name = "lb_TongSoLuong";
            this.lb_TongSoLuong.Size = new System.Drawing.Size(26, 17);
            this.lb_TongSoLuong.TabIndex = 6;
            this.lb_TongSoLuong.Text = "90";
            // 
            // btn_ChapNhan
            // 
            this.btn_ChapNhan.Location = new System.Drawing.Point(579, 363);
            this.btn_ChapNhan.Name = "btn_ChapNhan";
            this.btn_ChapNhan.Size = new System.Drawing.Size(197, 40);
            this.btn_ChapNhan.TabIndex = 7;
            this.btn_ChapNhan.Text = "Chấp nhận với số lượng này";
            this.btn_ChapNhan.UseVisualStyleBackColor = true;
            // 
            // Gc_ProductOnStock
            // 
            this.Gc_ProductOnStock.Location = new System.Drawing.Point(43, 63);
            this.Gc_ProductOnStock.MainView = this.gridView1;
            this.Gc_ProductOnStock.Name = "Gc_ProductOnStock";
            this.Gc_ProductOnStock.Size = new System.Drawing.Size(733, 282);
            this.Gc_ProductOnStock.TabIndex = 8;
            this.Gc_ProductOnStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.MaxQuanlity,
            this.MinQuanlity,
            this.gridColumn5});
            this.gridView1.GridControl = this.Gc_ProductOnStock;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã kho";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên kho";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // MaxQuanlity
            // 
            this.MaxQuanlity.Caption = "Canh báo Max";
            this.MaxQuanlity.FieldName = "MaxQuanlity";
            this.MaxQuanlity.MinWidth = 25;
            this.MaxQuanlity.Name = "MaxQuanlity";
            this.MaxQuanlity.Visible = true;
            this.MaxQuanlity.VisibleIndex = 2;
            this.MaxQuanlity.Width = 94;
            // 
            // MinQuanlity
            // 
            this.MinQuanlity.Caption = "Canh báo Min";
            this.MinQuanlity.FieldName = "MinQuanlity";
            this.MinQuanlity.MinWidth = 25;
            this.MinQuanlity.Name = "MinQuanlity";
            this.MinQuanlity.Visible = true;
            this.MinQuanlity.VisibleIndex = 3;
            this.MinQuanlity.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số lượng";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // SalesOrderProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 422);
            this.Controls.Add(this.Gc_ProductOnStock);
            this.Controls.Add(this.btn_ChapNhan);
            this.Controls.Add(this.lb_TongSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_TenSP);
            this.Controls.Add(this.lb_MaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesOrderProductDetail";
            this.Text = "Chi tiết đơn đặt hàng mua hàng";
            ((System.ComponentModel.ISupportInitialize)(this.Gc_ProductOnStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_MaSP;
        private System.Windows.Forms.Label lb_TenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TongSoLuong;
        private System.Windows.Forms.Button btn_ChapNhan;
        private DevExpress.XtraGrid.GridControl Gc_ProductOnStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn MaxQuanlity;
        private DevExpress.XtraGrid.Columns.GridColumn MinQuanlity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
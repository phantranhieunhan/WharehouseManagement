namespace StockManagement.Form.Product
{
    partial class ProductCategory
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gc_Main = new DevExpress.XtraGrid.GridControl();
            this.gc_master = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductCategoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MaSP = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_master)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(933, 600);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh mục sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Gc_Main);
            this.groupBox2.Location = new System.Drawing.Point(9, 207);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(916, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // Gc_Main
            // 
            this.Gc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gc_Main.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Gc_Main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "gc_detail";
            this.Gc_Main.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.Gc_Main.Location = new System.Drawing.Point(5, 20);
            this.Gc_Main.MainView = this.gc_master;
            this.Gc_Main.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Gc_Main.Name = "Gc_Main";
            this.Gc_Main.Size = new System.Drawing.Size(906, 365);
            this.Gc_Main.TabIndex = 0;
            this.Gc_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gc_master});
            // 
            // gc_master
            // 
            this.gc_master.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductCategoryCode,
            this.ProductCategoryName});
            this.gc_master.DetailHeight = 503;
            this.gc_master.FixedLineWidth = 3;
            this.gc_master.GridControl = this.Gc_Main;
            this.gc_master.Name = "gc_master";
            this.gc_master.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gc_master_MasterRowEmpty);
            this.gc_master.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gc_master_MasterRowGetChildList);
            this.gc_master.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gc_master_MasterRowGetRelationName);
            this.gc_master.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gc_master_MasterRowGetRelationCount);
            // 
            // ProductCategoryCode
            // 
            this.ProductCategoryCode.Caption = "Mã mục";
            this.ProductCategoryCode.FieldName = "ProductTypeCode";
            this.ProductCategoryCode.MinWidth = 43;
            this.ProductCategoryCode.Name = "ProductCategoryCode";
            this.ProductCategoryCode.Visible = true;
            this.ProductCategoryCode.VisibleIndex = 0;
            this.ProductCategoryCode.Width = 161;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.Caption = "Tên mục";
            this.ProductCategoryName.FieldName = "ProductTypeName";
            this.ProductCategoryName.MinWidth = 43;
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.Visible = true;
            this.ProductCategoryName.VisibleIndex = 1;
            this.ProductCategoryName.Width = 161;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_MaSP);
            this.groupBox1.Location = new System.Drawing.Point(5, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(919, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Location = new System.Drawing.Point(701, 50);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(161, 42);
            this.btn_timkiem.TabIndex = 1;
            this.btn_timkiem.Text = "Tìm kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.Location = new System.Drawing.Point(465, 50);
            this.btn_them.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(161, 42);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm ";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(50, 56);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(332, 22);
            this.txt_MaSP.TabIndex = 0;
            // 
            // ProductCategory
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProductCategory";
            this.Size = new System.Drawing.Size(933, 600);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_master)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl Gc_Main;
        private DevExpress.XtraGrid.Views.Grid.GridView gc_master;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCategoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCategoryName;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.TextEdit txt_MaSP;
    }
}

namespace StockManagement.Form.Product
{
    partial class ProductsList
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_timkiem = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).BeginInit();
            this.btn_timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.btn_timkiem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(890, 591);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(9, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(873, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControl1.Location = new System.Drawing.Point(5, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_Edit,
            this.btn_Delete});
            this.gridControl1.Size = new System.Drawing.Size(863, 354);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductCode,
            this.ProductName,
            this.Price,
            this.gridColumn1,
            this.gridColumn5,
            this.btn_Xoa,
            this.btn_Sua});
            this.gridView1.DetailHeight = 503;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ProductCode
            // 
            this.ProductCode.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCode.AppearanceHeader.Options.UseFont = true;
            this.ProductCode.Caption = "Mã sản phẩm";
            this.ProductCode.FieldName = "ProductCode";
            this.ProductCode.MinWidth = 43;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.OptionsColumn.AllowEdit = false;
            this.ProductCode.Visible = true;
            this.ProductCode.VisibleIndex = 0;
            this.ProductCode.Width = 127;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.Caption = "Tên sản phẩm";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 43;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 178;
            // 
            // Price
            // 
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.Caption = "Giá bán";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 43;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 149;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Đơn vị";
            this.gridColumn1.FieldName = "ProductUnitName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 185;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Danh mục";
            this.gridColumn5.FieldName = "ProductTypeName";
            this.gridColumn5.MinWidth = 43;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 115;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.btn_Xoa.AppearanceHeader.Options.UseFont = true;
            this.btn_Xoa.Caption = "delete";
            this.btn_Xoa.ColumnEdit = this.btn_Delete;
            this.btn_Xoa.MinWidth = 43;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Visible = true;
            this.btn_Xoa.VisibleIndex = 6;
            this.btn_Xoa.Width = 43;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btn_Delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_Sua
            // 
            this.btn_Sua.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.btn_Sua.AppearanceHeader.Options.UseFont = true;
            this.btn_Sua.Caption = "edit";
            this.btn_Sua.ColumnEdit = this.btn_Edit;
            this.btn_Sua.MinWidth = 43;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Visible = true;
            this.btn_Sua.VisibleIndex = 5;
            this.btn_Sua.Width = 43;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.btn_Edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Controls.Add(this.simpleButton2);
            this.btn_timkiem.Controls.Add(this.btn_them);
            this.btn_timkiem.Controls.Add(this.textEdit1);
            this.btn_timkiem.Location = new System.Drawing.Point(9, 45);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_timkiem.Size = new System.Drawing.Size(873, 152);
            this.btn_timkiem.TabIndex = 0;
            this.btn_timkiem.TabStop = false;
            this.btn_timkiem.Text = "Tìm kiếm";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(643, 66);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(161, 42);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Tìm kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.Location = new System.Drawing.Point(405, 62);
            this.btn_them.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(161, 42);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm ";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(26, 62);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(313, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // ProductsList
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProductsList";
            this.Size = new System.Drawing.Size(890, 591);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).EndInit();
            this.btn_timkiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCode;
        private new DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn btn_Xoa;
        private System.Windows.Forms.GroupBox btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Edit;
    }
}

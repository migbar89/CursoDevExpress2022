namespace filtroDevExpress
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpProducto = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductScale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProductLine = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbProductLine = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ctMenor = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctMenor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpProducto;
            this.gridControl1.Location = new System.Drawing.Point(12, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1755, 682);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpProducto
            // 
            this.xpProducto.ObjectType = typeof(filtroDevExpress.classicmodels.Products);
            this.xpProducto.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductCode,
            this.colProductName,
            this.colProductScale,
            this.colProductVendor,
            this.colProductDescription,
            this.colQuantityInStock,
            this.colBuyPrice,
            this.colMSRP,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colProductCode
            // 
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.MinWidth = 25;
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            this.colProductCode.Width = 94;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 94;
            // 
            // colProductScale
            // 
            this.colProductScale.FieldName = "ProductScale";
            this.colProductScale.MinWidth = 25;
            this.colProductScale.Name = "colProductScale";
            this.colProductScale.Visible = true;
            this.colProductScale.VisibleIndex = 2;
            this.colProductScale.Width = 94;
            // 
            // colProductVendor
            // 
            this.colProductVendor.FieldName = "ProductVendor";
            this.colProductVendor.MinWidth = 25;
            this.colProductVendor.Name = "colProductVendor";
            this.colProductVendor.Visible = true;
            this.colProductVendor.VisibleIndex = 3;
            this.colProductVendor.Width = 94;
            // 
            // colProductDescription
            // 
            this.colProductDescription.FieldName = "ProductDescription";
            this.colProductDescription.MinWidth = 25;
            this.colProductDescription.Name = "colProductDescription";
            this.colProductDescription.Visible = true;
            this.colProductDescription.VisibleIndex = 4;
            this.colProductDescription.Width = 94;
            // 
            // colQuantityInStock
            // 
            this.colQuantityInStock.FieldName = "QuantityInStock";
            this.colQuantityInStock.MinWidth = 25;
            this.colQuantityInStock.Name = "colQuantityInStock";
            this.colQuantityInStock.Visible = true;
            this.colQuantityInStock.VisibleIndex = 5;
            this.colQuantityInStock.Width = 94;
            // 
            // colBuyPrice
            // 
            this.colBuyPrice.FieldName = "BuyPrice";
            this.colBuyPrice.MinWidth = 25;
            this.colBuyPrice.Name = "colBuyPrice";
            this.colBuyPrice.Visible = true;
            this.colBuyPrice.VisibleIndex = 6;
            this.colBuyPrice.Width = 94;
            // 
            // colMSRP
            // 
            this.colMSRP.FieldName = "MSRP";
            this.colMSRP.MinWidth = 25;
            this.colMSRP.Name = "colMSRP";
            this.colMSRP.Visible = true;
            this.colMSRP.VisibleIndex = 7;
            this.colMSRP.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Product Line";
            this.gridColumn1.FieldName = "ProductLine.ProductLine";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 94;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ctMenor);
            this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl1.Controls.Add(this.cbProductLine);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1779, 736);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(1248, 12);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.xpProductLine;
            this.searchLookUpEdit1.Properties.DisplayMember = "ProductLine";
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "ProductLine";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(299, 22);
            this.searchLookUpEdit1.StyleController = this.layoutControl1;
            this.searchLookUpEdit1.TabIndex = 5;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // xpProductLine
            // 
            this.xpProductLine.ObjectType = typeof(filtroDevExpress.classicmodels.Productlines);
            this.xpProductLine.Session = this.unitOfWork1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbProductLine
            // 
            this.cbProductLine.FormattingEnabled = true;
            this.cbProductLine.Location = new System.Drawing.Point(568, 12);
            this.cbProductLine.Name = "cbProductLine";
            this.cbProductLine.Size = new System.Drawing.Size(319, 24);
            this.cbProductLine.TabIndex = 4;
            this.cbProductLine.SelectedIndexChanged += new System.EventHandler(this.cbProductLine_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1779, 736);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1759, 686);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbProductLine;
            this.layoutControlItem2.Location = new System.Drawing.Point(439, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(440, 30);
            this.layoutControlItem2.Text = "Product Line";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(114, 16);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(879, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(240, 30);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(219, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(220, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchLookUpEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(1119, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(420, 30);
            this.layoutControlItem3.Text = "Search Product Line";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(114, 16);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1539, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(220, 30);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ctMenor
            // 
            this.ctMenor.Location = new System.Drawing.Point(129, 12);
            this.ctMenor.Name = "ctMenor";
            this.ctMenor.Size = new System.Drawing.Size(98, 22);
            this.ctMenor.StyleController = this.layoutControl1;
            this.ctMenor.TabIndex = 6;
            this.ctMenor.EditValueChanged += new System.EventHandler(this.ctMenor_EditValueChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ctMenor;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(219, 30);
            this.layoutControlItem4.Text = "Menor que";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(114, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 736);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctMenor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPCollection xpProducto;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductScale;
        private DevExpress.XtraGrid.Columns.GridColumn colProductVendor;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMSRP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ComboBox cbProductLine;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.XPCollection xpProductLine;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.TextEdit ctMenor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}


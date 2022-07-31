namespace Respaldo_Restauracion_Exportar_Excell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xpProducto = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btRespaldo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btExportar = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btRestauracion = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // xpProducto
            // 
            this.xpProducto.ObjectType = typeof(Respaldo_Restauracion_Exportar_Excell.Database.Employees);
            this.xpProducto.Session = this.unitOfWork1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btRestauracion);
            this.layoutControl1.Controls.Add(this.btRespaldo);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btExportar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1437, 454);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btRespaldo
            // 
            this.btRespaldo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btRespaldo.ImageOptions.Image")));
            this.btRespaldo.Location = new System.Drawing.Point(1227, 12);
            this.btRespaldo.Name = "btRespaldo";
            this.btRespaldo.Size = new System.Drawing.Size(94, 36);
            this.btRespaldo.StyleController = this.layoutControl1;
            this.btRespaldo.TabIndex = 7;
            this.btRespaldo.Text = "Respaldo";
            this.btRespaldo.Click += new System.EventHandler(this.btRespaldo_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpProducto;
            this.gridControl1.Location = new System.Drawing.Point(12, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1413, 390);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeNumber,
            this.colLastName,
            this.colFirstName,
            this.colExtension,
            this.colEmail,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colJobTitle});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.FieldName = "EmployeeNumber";
            this.colEmployeeNumber.MinWidth = 25;
            this.colEmployeeNumber.Name = "colEmployeeNumber";
            this.colEmployeeNumber.Visible = true;
            this.colEmployeeNumber.VisibleIndex = 0;
            this.colEmployeeNumber.Width = 94;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.MinWidth = 25;
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 94;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.MinWidth = 25;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            this.colFirstName.Width = 94;
            // 
            // colExtension
            // 
            this.colExtension.FieldName = "Extension";
            this.colExtension.MinWidth = 25;
            this.colExtension.Name = "colExtension";
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 3;
            this.colExtension.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "OfficeCode!";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "OfficeCode!Key";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "ReportsTo!";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "ReportsTo!Key";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 94;
            // 
            // colJobTitle
            // 
            this.colJobTitle.FieldName = "JobTitle";
            this.colJobTitle.MinWidth = 25;
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.Visible = true;
            this.colJobTitle.VisibleIndex = 9;
            this.colJobTitle.Width = 94;
            // 
            // btExportar
            // 
            this.btExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btExportar.ImageOptions.Image")));
            this.btExportar.Location = new System.Drawing.Point(1335, 12);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(90, 36);
            this.btExportar.StyleController = this.layoutControl1;
            this.btExportar.TabIndex = 5;
            this.btExportar.Text = "Exportar";
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1437, 454);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1417, 394);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btExportar;
            this.layoutControlItem2.Location = new System.Drawing.Point(1323, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(94, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1037, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btRespaldo;
            this.layoutControlItem3.Location = new System.Drawing.Point(1215, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(98, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(1313, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btRestauracion
            // 
            this.btRestauracion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btRestauracion.ImageOptions.Image")));
            this.btRestauracion.Location = new System.Drawing.Point(1049, 12);
            this.btRestauracion.Name = "btRestauracion";
            this.btRestauracion.Size = new System.Drawing.Size(164, 36);
            this.btRestauracion.StyleController = this.layoutControl1;
            this.btRestauracion.TabIndex = 8;
            this.btRestauracion.Text = "Restauracion";
            this.btRestauracion.Click += new System.EventHandler(this.btRestauracion_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btRestauracion;
            this.layoutControlItem4.Location = new System.Drawing.Point(1037, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(168, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1205, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 454);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpProducto;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btExportar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btRespaldo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btRestauracion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}


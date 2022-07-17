namespace Reportes
{
    partial class frmFractura2
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
            this.components = new System.ComponentModel.Container();
            this.btgenerarReporte = new System.Windows.Forms.Button();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            this.SuspendLayout();
            // 
            // btgenerarReporte
            // 
            this.btgenerarReporte.Location = new System.Drawing.Point(185, 51);
            this.btgenerarReporte.Name = "btgenerarReporte";
            this.btgenerarReporte.Size = new System.Drawing.Size(247, 75);
            this.btgenerarReporte.TabIndex = 1;
            this.btgenerarReporte.Text = "Generar Reporte";
            this.btgenerarReporte.UseVisualStyleBackColor = true;
            this.btgenerarReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFractura2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btgenerarReporte);
            this.Name = "frmFractura2";
            this.Text = "frmFractura2";
            this.Load += new System.EventHandler(this.frmFractura2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btgenerarReporte;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
    }
}
using Reportes.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            ReportFactura reportFactura = new ReportFactura();
            //reportFactura.Parameters["idorder"].Value = 10100;
            //this.documentViewer1.DocumentSource = typeof(Reportes.Report.ReportFactura);
            this.documentViewer1.DocumentSource = reportFactura;

        }

        private void btMostrarReporte_Click(object sender, EventArgs e)
        {
            //ReportFactura reportFactura = new ReportFactura();
            //reportFactura.Parameters["idorder"].Value = 10100;
            ////this.documentViewer1.DocumentSource = typeof(Reportes.Report.ReportFactura);
            //this.documentViewer1.DocumentSource = reportFactura;
        }
    }
}

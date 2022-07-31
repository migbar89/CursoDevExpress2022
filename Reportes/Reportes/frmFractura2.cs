using DevExpress.XtraReports.UI;
using Reportes.Database;
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
    public partial class frmFractura2 : Form
    {

        public frmFractura2()
        {
            InitializeComponent();
        }

        private void frmFractura2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReportFactura reportFactura = new ReportFactura();

            reportFactura.Parameters["idorder"].Value = 14789;
            reportFactura.Parameters["idorder"].Visible = false;

            ReportPrintTool printTool = new ReportPrintTool(reportFactura);
            printTool.ShowPreview();
        }
    }
}

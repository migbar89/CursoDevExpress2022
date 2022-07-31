using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Respaldo_Restauracion_Exportar_Excell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            csimprimirgridview exportar = new csimprimirgridview();

            exportar.imprimirGridView("Reporte de Productos", DateTime.Today.ToShortDateString(), gridView1);
        }

        private void btRespaldo_Click(object sender, EventArgs e)
        {
            Backup.Respaldo();
        }

        private void btRestauracion_Click(object sender, EventArgs e)
        {
            Backup.Restauracion();
        }
    }
}

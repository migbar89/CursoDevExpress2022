using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.devexpress;

namespace WindowsFormsApp1
{
    public partial class frmNuevoEstudiante : Form
    {
        ErrorProvider error;
        public frmNuevoEstudiante()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (ctedad.Text.Length == 0 || Convert.ToInt32(ctedad.Text.Trim()) <= 0)
            {
                error.SetError(ctedad, "Debe Ingresar su edad");
                return;
            }
            Estudiante est = new Estudiante(unitOfWork1);
            est.Nombre = ctnombre.Text;
            est.Apellido = ctapellido.Text;
            est.Edad = Convert.ToInt32(ctedad.Text);

            est.Save();

            unitOfWork1.CommitChanges();
            MessageBox.Show("Estudiante Guardado Correctamente");
            this.Close();
        }

        private void frmNuevoEstudiante_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
        }

        private void ctedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
        }
    }
}

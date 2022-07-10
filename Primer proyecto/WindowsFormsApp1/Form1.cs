using DevExpress.Xpo;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btguardar_Click(object sender, EventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoEstudiante formEstudiante = new frmNuevoEstudiante();
            formEstudiante.ShowDialog();


            xpEstudiante.Reload();



        }

        private void btguardarCambios_Click(object sender, EventArgs e)
        {
            unitOfWork1.CommitChanges();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            //obtener el objeto seleccionado
            Estudiante est = (Estudiante)gridViewEstudiante.GetFocusedRow();

            //Confirmar el eliminar
            DialogResult d = MessageBox.Show("Esta seguro que desea eliminar este estudiante?",
                "Eliminando Estudiante",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );

            if (d == DialogResult.Cancel) return;

            //Eliminar el Objeto Seleccionado
            unitOfWork1.Delete(est);

            //Guardando Cambios en la base de datos
            unitOfWork1.CommitChanges();

            //Actualizar Tabla
            xpEstudiante.Reload();


        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //Obtener el Objeto
            Estudiante est = (Estudiante)gridViewEstudiante.GetFocusedRow();


            frmEditarEstudiante formEstudiante = new frmEditarEstudiante();
            formEstudiante.estudiante = est;
            formEstudiante.ShowDialog();


            xpEstudiante.Reload();
        }
    }
}

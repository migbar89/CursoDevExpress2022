using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Respaldo_Restauracion_Exportar_Excell.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Respaldo_Restauracion_Exportar_Excell
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
     ConnectionHelper.ConnectionString, AutoCreateOption.DatabaseAndSchema);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

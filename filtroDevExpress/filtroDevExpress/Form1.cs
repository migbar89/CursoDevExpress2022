using DevExpress.Data.Filtering;
using filtroDevExpress.classicmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filtroDevExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProductLine();
        }

        void LoadProductLine()
        {
            cbProductLine.Items.Add("Ninguno");
            for (int i = 0; i < xpProductLine.Count; i++)
            {
                Productlines line = (Productlines)xpProductLine[i];
                cbProductLine.Items.Add(line.ProductLine);
            }
        }

        private void cbProductLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbProductLine.SelectedIndex.ToString());
            filter();

        }


        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Productlines line = (Productlines)searchLookUpEdit1View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("ProductLine.ProductLine", line.ProductLine, BinaryOperatorType.Equal));


            xpProducto.Criteria = criterion;

        }
        public void filter()
        {
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };
            if (cbProductLine.SelectedIndex > 0)
            {
                criterion.Operands.Add(
                new BinaryOperator("ProductLine.ProductLine", cbProductLine.Text, BinaryOperatorType.Equal));
            }
            if (ctMenor.Text.Trim().Length > 0)
            {
                criterion.Operands.Add(
               new BinaryOperator("QuantityInStock", ctMenor.Text, BinaryOperatorType.Less));

            }
            xpProducto.Criteria = criterion;
        }
        private void ctMenor_EditValueChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}

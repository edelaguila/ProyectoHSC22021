using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaContabilidad
{
    public partial class frmIngresoTipoCuenta : Form
    {

        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmIngresoTipoCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idCuenta = txtTipoCuenta.Text;
            string nombre = txtDescripcion.Text;


            bool resultado = nuevoCn.ingresotipoCuenta(idCuenta, nombre);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtTipoCuenta.Text = "";
            txtDescripcion.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

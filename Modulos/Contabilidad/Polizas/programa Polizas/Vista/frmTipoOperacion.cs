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
    public partial class frmTipoOperacion : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmTipoOperacion()
        {
            InitializeComponent();
        }

        private void btnIngresarTipoOperacion_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idTipoOperacion = txtTipoOperacion.Text;
            string nombre = txtNombre.Text;
           
            


            bool resultado = nuevoCn.ingresoTipoOperacion(idTipoOperacion, nombre);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtTipoOperacion.Text = "";
            txtNombre.Text = "";
           
        }
    }
}

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
    public partial class frmTipoPoliza : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();

        public frmTipoPoliza()
        {
            InitializeComponent();
        }

        private void btntTpoPoliza_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idTipoCuenta = txtIdPoliza.Text;
            string descripcion = txtDescripcion.Text;


            bool resultado = nuevoCn.ingresoTipoPoliza(idTipoCuenta, descripcion);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtIdPoliza.Text = "";
            txtDescripcion.Text = "";
        }

        private void frmTipoPoliza_Load(object sender, EventArgs e)
        {

        }
    }
}

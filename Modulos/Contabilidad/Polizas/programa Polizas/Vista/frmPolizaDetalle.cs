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
    public partial class frmPolizaDetalle : Form

    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmPolizaDetalle()
        {
            InitializeComponent();
        }

        private void btnIngresoDetalle_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idTipoEncabezado = txtEncabezado.Text;
            string fecha = txtFecha.Text;
            string cuenta = txtCuenta.Text;
            string saldo = txtSaldo.Text;
            string operacion = txtOperacion.Text;
            string concepto = txtConcepto.Text;



            bool resultado = nuevoCn.ingresoPolizaDetalle(idTipoEncabezado, fecha, cuenta, saldo, operacion, concepto);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtEncabezado.Text = "";
            txtFecha.Text = "";
            txtCuenta.Text = "";
            txtSaldo.Text = "";
            txtOperacion.Text = "";
            txtConcepto.Text = "";
        }
    }
}

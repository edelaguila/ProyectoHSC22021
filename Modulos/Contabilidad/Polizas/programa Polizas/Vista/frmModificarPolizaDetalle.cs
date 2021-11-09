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
    public partial class frmModificarPolizaDetalle : Form
    {
        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgPolizaDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgPolizaDetalle.DataSource = dt;

        }

        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmModificarPolizaDetalle()
        {
            InitializeComponent();
            actualizardatagriew("polizaDetalle");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idPolizaEncabezado = txtIdPolizaDetalle.Text;
            string fechaPoliza = txtFechaPoliza.Text;
            string idCuenta = txtIdCuenta.Text;
            string saldo = txtSaldo.Text;
            string idTipoOperacion = txtIdTipoOperacion.Text;
            string concepto = txtConcepto.Text;



            if (txtIdPolizaDetalle.Text == "" || txtFechaPoliza.Text == "" || txtIdCuenta.Text == "" || txtSaldo.Text == "" || txtIdTipoOperacion.Text == "" || txtConcepto.Text == "")
            {
                MessageBox.Show("Debe rellenar sus campos");
                txtIdPolizaDetalle.Text = "";
                txtFechaPoliza.Text = "";
                txtIdCuenta.Text = "";
                txtSaldo.Text = "";
                txtIdTipoOperacion.Text = "";
                txtConcepto.Text = "";
                return;
            }

            bool resultado = nuevoCn.modificarPolizaDetalle(idPolizaEncabezado, fechaPoliza, idCuenta, saldo, idTipoOperacion, concepto);

            if (resultado)
            {
                MessageBox.Show("Actualización correcta");
                actualizardatagriew("polizaDetalle");
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }

            txtIdPolizaDetalle.Text = "";
            txtFechaPoliza.Text = "";
            txtIdCuenta.Text = "";
            txtSaldo.Text = "";
            txtIdTipoOperacion.Text = "";
            txtConcepto.Text = "";
            
        }
    }
}

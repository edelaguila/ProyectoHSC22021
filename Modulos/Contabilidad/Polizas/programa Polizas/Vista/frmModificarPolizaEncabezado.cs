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
    public partial class frmModificarPolizaEncabezado : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmModificarPolizaEncabezado()
        {
            InitializeComponent();
            actualizardatagriew("polizaEncabezado");
        }


        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgPolizaEncabezado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgPolizaEncabezado.DataSource = dt;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idPolizaEncabezado = txtEncabezado.Text;
            string fechaPoliza = txtFechaPoliza.Text;
            string idTipoPoliza = txtTipoPoliza.Text;

            if (txtEncabezado.Text == "" || txtFechaPoliza.Text == "" || txtTipoPoliza.Text == "")
            {
                MessageBox.Show("Debe rellenar sus campos");
                txtEncabezado.Text = "";
                txtFechaPoliza.Text = "";
                txtTipoPoliza.Text = "";
                return;
            } 

            bool resultado = nuevoCn.modificarPolizaEncabezado(idPolizaEncabezado, fechaPoliza, idTipoPoliza);

            if (resultado)
            {
                MessageBox.Show("Actualización correcta");
                actualizardatagriew("polizaEncabezado");
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }

            txtEncabezado.Text = "";
            txtFechaPoliza.Text = "";
            txtTipoPoliza.Text = "";
        }

        private void txtTipoPóliza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmModifcarCuenta : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmModifcarCuenta()
        {
            InitializeComponent();
            actualizardatagriew("cuenta");
        }


        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgCuenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCuenta.DataSource = dt;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idCuenta = txtIdCuenta.Text;
            string nombre = txtNombre.Text;
            string idTipoCuenta = txtIdTipoCuenta.Text;
            string cargo = txtCargo.Text;
            string abono = txtAbono.Text;
            string saldo = txtSaldo.Text;
            string estado = txtEstado.Text;
            string cuentaPadre = txtCuentaPadre.Text;

            if (txtIdCuenta.Text == "" || txtNombre.Text == "" || txtIdTipoCuenta.Text == "" || txtCargo.Text == "" || txtAbono.Text == "" || txtSaldo.Text == "" || txtEstado.Text == "" || txtCuentaPadre.Text == "")
            {
                MessageBox.Show("Debe rellenar sus campos");
                txtIdCuenta.Text = "";
                txtNombre.Text = "";
                txtIdTipoCuenta.Text = "";
                txtCargo.Text = "";
                txtAbono.Text = "";
                txtSaldo.Text = "";
                txtEstado.Text = "";
                txtCuentaPadre.Text = "";
                return;
            }



            bool resultado = nuevoCn.modificarCuenta(idCuenta, nombre, idTipoCuenta,cargo, abono,saldo,estado ,cuentaPadre);

            if (resultado)
            {
                MessageBox.Show("Actualización correcta");
                actualizardatagriew("cuenta");
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }

            txtIdCuenta.Text = "";
            txtNombre.Text = "";
            txtIdTipoCuenta.Text = "";
            txtCargo.Text = "";
            txtAbono.Text = "";
            txtSaldo.Text = "";
            txtEstado.Text = "";
            txtCuentaPadre.Text = "";
        }
    }
}

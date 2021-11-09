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
    public partial class frmPolizaEncabezado : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmPolizaEncabezado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //boton de ingreso para Encabezado
        {
            //aca pido los datos
            string idEncabezado = txtTipoEncabezado.Text;
            string fecha = txtFecha.Text;
            string poliza = txtPoliza.Text;
           ;


            bool resultado = nuevoCn.ingresoPolizaEncabezado(idEncabezado,fecha, poliza);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtTipoEncabezado.Text = "";
            txtFecha.Text = "";
            txtPoliza.Text = "";
           
        }
    }
}

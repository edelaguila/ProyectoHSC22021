using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaControladorMBancos;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class frmDisponibilidad : Form
    {
        public frmDisponibilidad()
        {
            InitializeComponent();
            desactivarTexBox();
            actualizardatagriew();
            txtTotal.Text = ConsultaD();
        }
        Controlador sn = new Controlador();
        String tabla = "cuenta";
        public void desactivarTexBox() 
        {
            txtTotal.Enabled = false;
        }
        public void actualizardatagriew()
        {
            DataTable dt = sn.llenarTb2(tabla);
            dataGridView1.DataSource = dt;
        }
        public string ConsultaD()
        {
            return sn.consultaGeneral1();
        }



    }
}

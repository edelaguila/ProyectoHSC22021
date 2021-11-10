using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using CapaControladorMBancos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class frmNominaGeneral : Form
    {
        public frmNominaGeneral()
        {
            InitializeComponent();
            actualizardatagriew();
            lblTotal.Text = ConsultaG();
        }
        Controlador cn = new Controlador();
        String tabla = "chequesprov";

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarT(tabla);
            dataGridView1.DataSource = dt;

        }

        public string ConsultaG()
        {
            return cn.consultaGeneral();
        }
    }
}

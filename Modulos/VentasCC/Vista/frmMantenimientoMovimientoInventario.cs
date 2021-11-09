using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorMVentasCC;

namespace CapaVista
{
	public partial class frmMantenimientoMovimientoInventario : Form
	{
		Controlador cn = new Controlador();
		public frmMantenimientoMovimientoInventario()
		{
			InitializeComponent();
			INVMostarMovimientos();
		}
		public void INVMostarMovimientos()
		{
			DataTable dt = cn.INVMostarMovimientos();
			dtgMovimiento.DataSource = dt;
		}

		private void btnIngresar_Click(object sender, EventArgs e)
        {
			INVMostarMovimientos();
		}
    }
}

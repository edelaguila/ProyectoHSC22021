using CapaVistaSeguridadHSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDIRRHH : Form
    {
        public MDIRRHH()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuesto form3 = new frmPuesto();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

       
        private void asignacionDeAplicacionesAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmPuesto form3 = new frmPuesto();
            form3.MdiParent = this.MdiParent;

            form3.Show();
        }

        private void cambioContraseñaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            frmCambioContraseña form3 = new frmCambioContraseña();
            form3.MdiParent = this.MdiParent;

            form3.Show();
        }

        private void tsmEmpleados_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado form3 = new frmAgregarEmpleado();
            form3.MdiParent = this.MdiParent;

            form3.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            frmLoginHSC form = new frmLoginHSC();

            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                string user = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MantenimientosContaJNLD;
using CapaVistaSeguridadHSC;

namespace EjecutablePruebaCrudConta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mantenimientoCuentas frm1 = new mantenimientoCuentas();
            frm1.MdiParent = this;
            frm1.Show();
            frm1.funActualizarUsuario(txtUsuario.Text);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mantenimientoTipoCuenta frm2 = new mantenimientoTipoCuenta();
            frm2.MdiParent = this;
            frm2.Show();
            frm2.funActualizarUsuario(txtUsuario.Text);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            mantenimientoTipoOperacion frm3 = new mantenimientoTipoOperacion();
            frm3.MdiParent = this;
            frm3.Show();
            frm3.funActualizarUsuario(txtUsuario.Text);
        }

        private void impuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoImpuestos frm4 = new mantenimientoImpuestos();
            frm4.MdiParent = this;
            frm4.Show();
            frm4.funActualizarUsuario(txtUsuario.Text);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerraSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void jaimeNoelLópezDaniel090118735ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MDI Creado para efecto de prueba de los mantenimientos de Contabilidad, de forma independiente del MDI de módulo\n06/11/2021-0901-18-735-09:00PM");
        }
    }
}

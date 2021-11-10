using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaVistaSeguridadHSC;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class MDIBancos : Form
    {
        public MDIBancos()
        {
            InitializeComponent();
            desactivarTexBox();
        }
        // Luis Reyes 0901-15-3121
        private void MDIBancos_Load(object sender, EventArgs e)
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

        private void consultasInteligentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CapaVista.ConsultasInteligentes frm = new CapaVista.ConsultasInteligentes();
            frm.Show();
        }

        private void menuConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista.menuconsultas frm = new CapaVista.menuconsultas();
            frm.Show();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaSeguridadHSC.frmMIDSeguridad frm = new CapaVistaSeguridadHSC.frmMIDSeguridad();
            frm.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usu;
            usu = Convert.ToString(txtUsuario.Text);
            if(usu == "admin")
            {
                CapaVistaReporte.ReporteadorAdmin frm = new CapaVistaReporte.ReporteadorAdmin();
                frm.Show();
            }
            else 
            {
                CapaVistaReporte.ReporteadorUsuario frm = new CapaVistaReporte.ReporteadorUsuario();
                frm.Show();
            }
            
        }

        private void consultarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitudCuenta frm = new frmSolicitudCuenta();
            frm.Show();
        }

        private void transferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTranferecia frm = new frmTranferecia();
            frm.Show();
        }

        private void disponibilidadBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisponibilidad frm = new frmDisponibilidad();
            frm.Show();
        }

        private void divisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipodeCambio frm = new frmTipodeCambio();
            frm.Show();
        }
        public void desactivarTexBox()
        {
            txtUsuario.Enabled = false;
        }

        private void chequesGeneradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNominaGeneral frm = new frmNominaGeneral();
            frm.Show();
        }

        private void chequesEmitidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheques frm = new frmCheques();
            frm.Show();
        }
    }
}

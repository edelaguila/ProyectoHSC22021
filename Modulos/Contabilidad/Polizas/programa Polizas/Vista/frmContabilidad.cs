using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using VistaReporteador;
//using CapaVistaSeguridadHSC;

namespace Vista
{
    public partial class frmContabilidad : Form
    {
        public frmContabilidad()
        {
            InitializeComponent();
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*VistaReporteador.Reporteador formulario = new VistaReporteador.Reporteador();
            formulario.Show();
            */
        }

        private void consultasInteligentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            CapaVista.ConsultasInteligentes formulario = new CapaVista.ConsultasInteligentes();
            formulario.Show();
            */
        }

        private void menúConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            CapaVista.menuconsultas formulario = new CapaVista.menuconsultas();
            formulario.Show();
            */
        }

        private void frmContabilidad_Load(object sender, EventArgs e)
        {
            /*frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
            */
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            /*this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close(); }
            */
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            CapaVistaSeguridadHSC.frmMIDSeguridad formulario = new CapaVistaSeguridadHSC.frmMIDSeguridad();
            formulario.Show();
            */
        }

        private void ayudaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresoTipoPólizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmTipoPoliza formulario1 = new VistaContabilidad.frmTipoPoliza();
            formulario1.Show();
        }

        private void ingresoTipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            VistaContabilidad.frmIngresoTipoCuenta formulario1 = new VistaContabilidad.frmIngresoTipoCuenta();
            formulario1.Show();
        }

        private void ingresoEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmPolizaEncabezado formulario1 = new VistaContabilidad.frmPolizaEncabezado();
            formulario1.Show();
        }

        private void ingresoTipoOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmTipoOperacion formulario1 = new VistaContabilidad.frmTipoOperacion();
            formulario1.Show();
        }

        private void detalleDePólizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmPolizaDetalle formulario1 = new VistaContabilidad.frmPolizaDetalle();
            formulario1.Show();
        }

        private void ingresoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmCuenta formulario1 = new VistaContabilidad.frmCuenta();
            formulario1.Show();
        }

        private void modificarPólizaDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmModificarPolizaDetalle formulario1 = new VistaContabilidad.frmModificarPolizaDetalle();
            formulario1.Show();
        }

        private void modificarEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmModificarPolizaEncabezado formulario1 = new VistaContabilidad.frmModificarPolizaEncabezado();
            formulario1.Show();
        }

        private void modificarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaContabilidad.frmModifcarCuenta formulario1 = new VistaContabilidad.frmModifcarCuenta();
            formulario1.Show();
        }

        private void ayudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudas.chm", "Manual-de-usuario.html");

        }

    }
}

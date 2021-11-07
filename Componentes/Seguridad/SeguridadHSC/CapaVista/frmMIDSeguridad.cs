using System;
using System.Windows.Forms;
using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using static datosUsuario;
//Forma Creada por Roberto Lopez 0901-18-4982
namespace CapaVistaSeguridadHSC
{
    public partial class frmMIDSeguridad : Form
    {
        private ObtenerPermisos global = new ObtenerPermisos();
        //Variables para habilitar aplicacion Ashly Barrios 9959-18-649
        //5-11-2021
        RecorrerAplicacion recorrer = new RecorrerAplicacion();
        public string modulo = "1";
        public string id;
        public int valor;

        public frmMIDSeguridad()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }
        //Kevin Flores 9959-18-17632
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0001", "Cerrar sesión");
                txtUsuario.Text = form.usuario();
            }
            else { this.Close(); }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //nombreform form3 = new nombreform();
            //form3.MdiParent = this.MdiParent;

            //form3.Show();
        }
        //Kevin Flores 9959-18-17632
        private void btnAplicacion_Click(object sender, EventArgs e)
        {
            id = "0003";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmMantenimientoAplicacion form3 = new frmMantenimientoAplicacion();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Entrada a la Vista");

                form3.Show();
            }
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
        }
        //Kevin Flores 9959-18-17632
        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            id = "0007";
            int validar = 0;
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmMantenimientoPerfil form3 = new frmMantenimientoPerfil();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
                form3.Show();
            }
        }
        //Kevin Flores 9959-18-17632
        private void btnAsignacionDeAplicacionAUsuarios_Click(object sender, EventArgs e)
        {
            id = "0006";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmAplicaciones form3 = new frmAplicaciones();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0006", "Entrada a la Vista");
                form3.Show();
            }
        }
        //Kevin Flores 9959-18-17632
        private void btnAsignacionDeAplicacionesAPerfiles_Click(object sender, EventArgs e)
        {
            id = "0005";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmAplicacionesPerfiles form3 = new frmAplicacionesPerfiles();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Entrada a la Vista");
                form3.Show();
            }
        }
        //Kevin Flores 9959-18-17632
        private void btnCambioContraseña_Click(object sender, EventArgs e)
        {
            id = "0010";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmCambioContraseña form3 = new frmCambioContraseña();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0010", "Entrada a la Vista");
                form3.Show();
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
        }
        //Kevin Flores 9959-18-17632
        private void btnAsiginaciónDePerfilesAUsuarios_Click(object sender, EventArgs e)
        {
            id = "0007";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmPerfiles form3 = new frmPerfiles();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0007", "Asignación de Perfiles a Usuarios");
                form3.Show();
            }
        }
        //Kevin Flores 9959-18-17632
        private void bitácoraDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = "0011";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmBitacora form3 = new frmBitacora();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0011", "Entrada a la Vista");
                form3.Show();
            }
        }
        //Kevin Flores 9959-18-17632
        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = "0002";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmRegistrarUsuario form3 = new frmRegistrarUsuario();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
        }
        //Kevin Flores 9959-18-17632
        private void btnPermisos_Click(object sender, EventArgs e)
        {
            id = "0008";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmPermisos form3 = new frmPermisos();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0008", "Entrada a la Vista");
                form3.Show();
            }
        }
        //Kevin Flores 9959-18-17632
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Kevin Flores 9959-18-17632
        private void frmLoginHSC_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                global.usuarioglobal = txtUsuario.Text;
            }
            else
            {
                this.Close();
            }
        }
        //Kevin Flores 9959-18-17632
        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = "0012";
            int validar = 0;
            //Llamar funcion para bloquear aplicacion Ashly Barrios 9959-18-649
            //5-11-2021
            valor = recorrer.comprobar(modulo, IdUsuario, id, validar);
            if (valor != 0)
            {
                MessageBox.Show("No tiene permisos");
            }
            else
            {
                this.Enabled = true;
                frmMantenimientoModulo form3 = new frmMantenimientoModulo();
                form3.MdiParent = this;
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Entrada a la Vista");
                form3.Show();
            }
        }
    }
}
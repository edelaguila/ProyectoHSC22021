using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CapaControladorMBancos;
using System.Data.Odbc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class frmSolicitudCuenta : Form
    {
        public frmSolicitudCuenta()
        {
            InitializeComponent();
          
            llearcbxidCuenta();
            
        }
        Controlador sn = new Controlador();
        private void frmSolicitudCuenta_Load(object sender, EventArgs e)
        {
            
        }
        public void llearcbxidCuenta() 
        {
            try
            {
                cbxCuenta.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxAplic();
                while (datareader.Read())
                {
                    cbxCuenta.Items.Add(datareader[0].ToString());
                }
                cbxCuenta.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        private void cbxCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void consultar()
        {
            DataTable db = sn.llenarTb1(cbxCuenta.Text);
            dataGridView1.DataSource = db;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }
    }
}

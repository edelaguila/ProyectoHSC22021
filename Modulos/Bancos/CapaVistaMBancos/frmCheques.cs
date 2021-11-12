using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using CapaControladorMBancos;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class frmCheques : Form
    {
        public frmCheques()
        {
            InitializeComponent();
            datagriewChequesProv();
            llenarcbxProv();
            Consult();
        }

        Controlador cn = new Controlador();



        public void datagriewChequesProv()
        {
            string tabla = Convert.ToString(cbxIdProveedor.Text);
            DataTable dt = cn.llenarTbl(tabla);
            dataGridView1.DataSource = dt;
        }


        //Angel Chacón 9959-18-5201 
        //funcion para mostrar id en el combobox de las apliaciones existentes
        public void llenarcbxIdProv()
        {
            try
            {
                cbxIdProveedor.Items.Clear();
                OdbcDataReader datareader = cn.IdProv(cbxProveedor.Text);
                while (datareader.Read())
                {
                    cbxIdProveedor.Items.Add(datareader[0].ToString());
                }
                cbxIdProveedor.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        //Angel Chacón 9959-18-5201 
        //funcion para mostrar los nombres en el combobox de las apliaciones existentes
        public void llenarcbxProv()
        {
            try
            {
                cbxProveedor.Items.Clear();
                OdbcDataReader datareader = cn.llenarcbxProv();
                while (datareader.Read())
                {
                    cbxProveedor.Items.Add(datareader[0].ToString());
                }
                cbxProveedor.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcbxIdProv();
            txtIdprov.Text = cbxIdProveedor.Text;
            txttotal.Text = Consult();
        }

        private void txtIdprov_TextChanged(object sender, EventArgs e)
        {
            datagriewChequesProv();
        }

        private void txttotal_Click(object sender, EventArgs e)
        {
            Consult();
        }
        public string Consult()
        {
            string var = Convert.ToString(cbxIdProveedor.Text);
            return cn.consu(var);
        }
    }
}


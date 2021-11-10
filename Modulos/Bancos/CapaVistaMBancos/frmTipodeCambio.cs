using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorMBancos;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class frmTipodeCambio : Form
    {
        public frmTipodeCambio()
        {
            InitializeComponent();
            llearcbxidmone();

        }
        Controlador sn = new Controlador();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double quet, euro, resul;
            quet = 8.94;
            euro = double.Parse(txtcantidad.Text);
            resul = quet * euro;
            label3.Visible = true;
            txtresultado.Visible = true;
            txtresultado.Text = resul.ToString();
        }
        public void conversiondemoneda()
        {
            double quet, dolar, resul;
            quet = Convert.ToDouble(cbxCambio.Text);
            dolar = double.Parse(txtcantidad.Text);
            resul = quet * dolar;
            label3.Visible = true;
            txtresultado.Visible = true;
            txtresultado.Text = resul.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
                        
            //txtcantidad.Clear();
            //txtresultado.Visible = false;
            //label3.Visible = false;
            //txtcantidad.Focus();
            conversiondemoneda();
        }
        public void llearcbxidmone()
        {
            try
            {
                cbxMoneda.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxmoned();
                while (datareader.Read())
                {
                    cbxMoneda.Items.Add(datareader[0].ToString());
                }
                cbxMoneda.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        public void llenarcbxIdMoneda()
        {
            try
            {
                cbxIdMoneda.Items.Clear();
                OdbcDataReader datareader = sn.IdMoned(cbxMoneda.Text);
                while (datareader.Read())
                {
                    cbxIdMoneda.Items.Add(datareader[0].ToString());
                }
                cbxIdMoneda.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxcambio()
        {
            
            try
            {
                cbxCambio.Items.Clear();
                OdbcDataReader datareader = sn.cambioM(cbxIdMoneda.Text);
                while (datareader.Read())
                {
                    cbxCambio.Items.Add(datareader[0].ToString());
                }
                cbxCambio.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            
        

    }


        private void cbxMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcbxIdMoneda();
            llenarcbxcambio();
          
        }

        private void cbxCambio_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxCambio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cbxIdMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

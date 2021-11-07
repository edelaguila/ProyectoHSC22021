
namespace MantenimientosContaJNLD
{
    partial class mantenimientoCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new DLL.nav.navegador();
            this.dvgCuentas = new System.Windows.Forms.DataGridView();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.txtSaldoAcum = new System.Windows.Forms.TextBox();
            this.txtCuentaPadre = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCuentaPadre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // dvgCuentas
            // 
            this.dvgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCuentas.Location = new System.Drawing.Point(511, 89);
            this.dvgCuentas.Name = "dvgCuentas";
            this.dvgCuentas.ReadOnly = true;
            this.dvgCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCuentas.Size = new System.Drawing.Size(676, 425);
            this.dvgCuentas.TabIndex = 1;
            this.dvgCuentas.SelectionChanged += new System.EventHandler(this.dvgCuentas_SelectionChanged);
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(104, 119);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdCuenta.TabIndex = 2;
            this.txtIdCuenta.Tag = "idCuenta";
            this.txtIdCuenta.TextChanged += new System.EventHandler(this.txtIdCuenta_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tag = "nombre";
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.Location = new System.Drawing.Point(309, 203);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Size = new System.Drawing.Size(28, 20);
            this.txtTipoCuenta.TabIndex = 4;
            this.txtTipoCuenta.Tag = "idTipoCuenta";
            this.txtTipoCuenta.Visible = false;
            this.txtTipoCuenta.TextChanged += new System.EventHandler(this.txtTipoCuenta_TextChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(104, 244);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 5;
            this.txtCargo.Tag = "cargo";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(104, 286);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 6;
            this.txtAbono.Tag = "abono";
            // 
            // txtSaldoAcum
            // 
            this.txtSaldoAcum.Location = new System.Drawing.Point(104, 330);
            this.txtSaldoAcum.Name = "txtSaldoAcum";
            this.txtSaldoAcum.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoAcum.TabIndex = 7;
            this.txtSaldoAcum.Tag = "saldoAcumulado";
            // 
            // txtCuentaPadre
            // 
            this.txtCuentaPadre.Location = new System.Drawing.Point(382, 374);
            this.txtCuentaPadre.Name = "txtCuentaPadre";
            this.txtCuentaPadre.Size = new System.Drawing.Size(27, 20);
            this.txtCuentaPadre.TabIndex = 8;
            this.txtCuentaPadre.Tag = "idCuentaPadre";
            this.txtCuentaPadre.Visible = false;
            this.txtCuentaPadre.TextChanged += new System.EventHandler(this.txtCuentaPadre_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(310, 441);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(27, 20);
            this.txtEstado.TabIndex = 9;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(104, 203);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(199, 21);
            this.cmbTipoCuenta.TabIndex = 12;
            this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID Tipo Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Abono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Saldo Acumulado";
            // 
            // cmbCuentaPadre
            // 
            this.cmbCuentaPadre.FormattingEnabled = true;
            this.cmbCuentaPadre.Location = new System.Drawing.Point(104, 373);
            this.cmbCuentaPadre.Name = "cmbCuentaPadre";
            this.cmbCuentaPadre.Size = new System.Drawing.Size(272, 21);
            this.cmbCuentaPadre.TabIndex = 17;
            this.cmbCuentaPadre.SelectedIndexChanged += new System.EventHandler(this.cmbCuentaPadre_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cuenta Padre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Location = new System.Drawing.Point(104, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(29, 57);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivo.TabIndex = 1;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(29, 20);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 0;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado";
            // 
            // mantenimientoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MantenimientosContaJNLD.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1187, 515);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCuentaPadre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCuentaPadre);
            this.Controls.Add(this.txtSaldoAcum);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtTipoCuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.dvgCuentas);
            this.Controls.Add(this.navegador1);
            this.Name = "mantenimientoCuentas";
            this.Text = "7701 - Mantenimiento Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.DataGridView dvgCuentas;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipoCuenta;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.TextBox txtSaldoAcum;
        private System.Windows.Forms.TextBox txtCuentaPadre;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCuentaPadre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.Label label8;
    }
}
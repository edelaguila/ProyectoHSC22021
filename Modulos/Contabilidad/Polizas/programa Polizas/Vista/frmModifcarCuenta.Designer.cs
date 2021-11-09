
namespace VistaContabilidad
{
    partial class frmModifcarCuenta
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
            this.txtCuentaPadre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdTipoCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dvgCuenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCuentaPadre
            // 
            this.txtCuentaPadre.Location = new System.Drawing.Point(473, 146);
            this.txtCuentaPadre.Name = "txtCuentaPadre";
            this.txtCuentaPadre.Size = new System.Drawing.Size(156, 20);
            this.txtCuentaPadre.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "ID Cuenta Padre:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(473, 63);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(156, 20);
            this.txtSaldo.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Saldo Acumulado:";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(473, 24);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(156, 20);
            this.txtAbono.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Abono:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(170, 148);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(156, 20);
            this.txtCargo.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cargo:";
            // 
            // txtIdTipoCuenta
            // 
            this.txtIdTipoCuenta.Location = new System.Drawing.Point(172, 109);
            this.txtIdTipoCuenta.Name = "txtIdTipoCuenta";
            this.txtIdTipoCuenta.Size = new System.Drawing.Size(156, 20);
            this.txtIdTipoCuenta.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "ID Tipo Cuenta:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(728, 65);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 44);
            this.btnActualizar.TabIndex = 52;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 51;
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(172, 31);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(156, 20);
            this.txtIdCuenta.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID Cuenta:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(473, 109);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(156, 20);
            this.txtEstado.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Estado:";
            // 
            // dvgCuenta
            // 
            this.dvgCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCuenta.Location = new System.Drawing.Point(41, 223);
            this.dvgCuenta.Name = "dvgCuenta";
            this.dvgCuenta.Size = new System.Drawing.Size(943, 150);
            this.dvgCuenta.TabIndex = 65;
            // 
            // frmModifcarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VistaContabilidad.Properties.Resources._3df38d07_8b18_4ed4_a423_5c4f23c7f07a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 408);
            this.Controls.Add(this.dvgCuenta);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCuentaPadre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdTipoCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModifcarCuenta";
            this.Text = "frmModifcarCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuentaPadre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdTipoCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dvgCuenta;
    }
}

namespace VistaContabilidad
{
    partial class frmPolizaDetalle
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
            this.btnIngresoDetalle = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtEncabezado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresoDetalle
            // 
            this.btnIngresoDetalle.Location = new System.Drawing.Point(156, 308);
            this.btnIngresoDetalle.Name = "btnIngresoDetalle";
            this.btnIngresoDetalle.Size = new System.Drawing.Size(150, 44);
            this.btnIngresoDetalle.TabIndex = 22;
            this.btnIngresoDetalle.Text = "Ingresar";
            this.btnIngresoDetalle.UseVisualStyleBackColor = true;
            this.btnIngresoDetalle.Click += new System.EventHandler(this.btnIngresoDetalle_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(190, 69);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(156, 20);
            this.txtFecha.TabIndex = 21;
            // 
            // txtEncabezado
            // 
            this.txtEncabezado.Location = new System.Drawing.Point(190, 24);
            this.txtEncabezado.Name = "txtEncabezado";
            this.txtEncabezado.Size = new System.Drawing.Size(156, 20);
            this.txtEncabezado.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Póliza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Póliza Encabezado:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(190, 110);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(156, 20);
            this.txtCuenta.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID Cuenta:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(190, 156);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(156, 20);
            this.txtSaldo.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Saldo:";
            // 
            // txtOperacion
            // 
            this.txtOperacion.Location = new System.Drawing.Point(190, 200);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(156, 20);
            this.txtOperacion.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID Tipo Operación:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(190, 243);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(156, 20);
            this.txtConcepto.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Concepto:";
            // 
            // frmPolizaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VistaContabilidad.Properties.Resources._3df38d07_8b18_4ed4_a423_5c4f23c7f07a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 412);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOperacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIngresoDetalle);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtEncabezado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPolizaDetalle";
            this.Text = "frmPolizaDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoDetalle;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtEncabezado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label6;
    }
}
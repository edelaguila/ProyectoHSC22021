
namespace VistaContabilidad
{
    partial class frmModificarPolizaEncabezado
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTipoPoliza = new System.Windows.Forms.TextBox();
            this.txtFechaPoliza = new System.Windows.Forms.TextBox();
            this.txtEncabezado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgPolizaEncabezado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPolizaEncabezado)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTipoPoliza
            // 
            this.txtTipoPoliza.Location = new System.Drawing.Point(258, 108);
            this.txtTipoPoliza.Name = "txtTipoPoliza";
            this.txtTipoPoliza.Size = new System.Drawing.Size(172, 20);
            this.txtTipoPoliza.TabIndex = 23;
            this.txtTipoPoliza.TextChanged += new System.EventHandler(this.txtTipoPóliza_TextChanged);
            // 
            // txtFechaPoliza
            // 
            this.txtFechaPoliza.Location = new System.Drawing.Point(253, 74);
            this.txtFechaPoliza.Name = "txtFechaPoliza";
            this.txtFechaPoliza.Size = new System.Drawing.Size(177, 20);
            this.txtFechaPoliza.TabIndex = 20;
            // 
            // txtEncabezado
            // 
            this.txtEncabezado.Location = new System.Drawing.Point(253, 42);
            this.txtEncabezado.Name = "txtEncabezado";
            this.txtEncabezado.Size = new System.Drawing.Size(177, 20);
            this.txtEncabezado.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID Tipo Póliza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha Póliza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Póliza Encabezado:";
            // 
            // dvgPolizaEncabezado
            // 
            this.dvgPolizaEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPolizaEncabezado.Location = new System.Drawing.Point(22, 192);
            this.dvgPolizaEncabezado.Name = "dvgPolizaEncabezado";
            this.dvgPolizaEncabezado.Size = new System.Drawing.Size(784, 189);
            this.dvgPolizaEncabezado.TabIndex = 26;
            // 
            // frmModificarPolizaEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VistaContabilidad.Properties.Resources._3df38d07_8b18_4ed4_a423_5c4f23c7f07a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 425);
            this.Controls.Add(this.dvgPolizaEncabezado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTipoPoliza);
            this.Controls.Add(this.txtFechaPoliza);
            this.Controls.Add(this.txtEncabezado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModificarPolizaEncabezado";
            this.Text = "frmModificarPolizaEncabezado";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPolizaEncabezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTipoPoliza;
        private System.Windows.Forms.TextBox txtFechaPoliza;
        private System.Windows.Forms.TextBox txtEncabezado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgPolizaEncabezado;
    }
}

namespace VistaContabilidad
{
    partial class frmTipoOperacion
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
            this.btnIngresarTipoOperacion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipoOperacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresarTipoOperacion
            // 
            this.btnIngresarTipoOperacion.Location = new System.Drawing.Point(147, 137);
            this.btnIngresarTipoOperacion.Name = "btnIngresarTipoOperacion";
            this.btnIngresarTipoOperacion.Size = new System.Drawing.Size(150, 44);
            this.btnIngresarTipoOperacion.TabIndex = 17;
            this.btnIngresarTipoOperacion.Text = "Ingresar";
            this.btnIngresarTipoOperacion.UseVisualStyleBackColor = true;
            this.btnIngresarTipoOperacion.Click += new System.EventHandler(this.btnIngresarTipoOperacion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtTipoOperacion
            // 
            this.txtTipoOperacion.Location = new System.Drawing.Point(166, 28);
            this.txtTipoOperacion.Name = "txtTipoOperacion";
            this.txtTipoOperacion.Size = new System.Drawing.Size(156, 20);
            this.txtTipoOperacion.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // frmTipoOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VistaContabilidad.Properties.Resources._3df38d07_8b18_4ed4_a423_5c4f23c7f07a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 234);
            this.Controls.Add(this.btnIngresarTipoOperacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTipoOperacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoOperacion";
            this.Text = "frmTipoOperacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIngresarTipoOperacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipoOperacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
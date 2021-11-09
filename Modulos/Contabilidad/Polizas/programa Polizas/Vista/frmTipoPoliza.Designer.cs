
namespace VistaContabilidad
{
    partial class frmTipoPoliza
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
            this.btntTpoPoliza = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPoliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntTpoPoliza
            // 
            this.btntTpoPoliza.Location = new System.Drawing.Point(176, 128);
            this.btntTpoPoliza.Name = "btntTpoPoliza";
            this.btntTpoPoliza.Size = new System.Drawing.Size(134, 37);
            this.btntTpoPoliza.TabIndex = 14;
            this.btntTpoPoliza.Text = "Ingresar";
            this.btntTpoPoliza.UseVisualStyleBackColor = true;
            this.btntTpoPoliza.Click += new System.EventHandler(this.btntTpoPoliza_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(162, 74);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(176, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripción:";
            // 
            // txtIdPoliza
            // 
            this.txtIdPoliza.Location = new System.Drawing.Point(162, 30);
            this.txtIdPoliza.Name = "txtIdPoliza";
            this.txtIdPoliza.Size = new System.Drawing.Size(176, 20);
            this.txtIdPoliza.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Tipo Póliza:";
            // 
            // frmTipoPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VistaContabilidad.Properties.Resources._3df38d07_8b18_4ed4_a423_5c4f23c7f07a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 251);
            this.Controls.Add(this.btntTpoPoliza);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPoliza);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoPoliza";
            this.Text = "frmTipoPoliza";
            this.Load += new System.EventHandler(this.frmTipoPoliza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntTpoPoliza;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPoliza;
        private System.Windows.Forms.Label label1;
    }
}
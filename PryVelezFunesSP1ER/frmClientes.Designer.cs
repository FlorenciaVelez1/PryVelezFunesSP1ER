namespace PryVelezFunesSP1ER
{
    partial class frmClientes
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdRegistroClientes = new System.Windows.Forms.Button();
            this.txtNombreClientes = new System.Windows.Forms.TextBox();
            this.mskIdentificacionClientes = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(20, 67);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 17;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalirVendedores_Click);
            // 
            // cmdRegistroClientes
            // 
            this.cmdRegistroClientes.Location = new System.Drawing.Point(122, 67);
            this.cmdRegistroClientes.Name = "cmdRegistroClientes";
            this.cmdRegistroClientes.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistroClientes.TabIndex = 16;
            this.cmdRegistroClientes.Text = "Registrar";
            this.cmdRegistroClientes.UseVisualStyleBackColor = true;
            this.cmdRegistroClientes.Click += new System.EventHandler(this.cmdRegistroClientes_Click);
            // 
            // txtNombreClientes
            // 
            this.txtNombreClientes.Location = new System.Drawing.Point(97, 41);
            this.txtNombreClientes.Name = "txtNombreClientes";
            this.txtNombreClientes.Size = new System.Drawing.Size(100, 20);
            this.txtNombreClientes.TabIndex = 15;
            // 
            // mskIdentificacionClientes
            // 
            this.mskIdentificacionClientes.Location = new System.Drawing.Point(97, 12);
            this.mskIdentificacionClientes.Mask = "99999";
            this.mskIdentificacionClientes.Name = "mskIdentificacionClientes";
            this.mskIdentificacionClientes.Size = new System.Drawing.Size(100, 20);
            this.mskIdentificacionClientes.TabIndex = 14;
            this.mskIdentificacionClientes.ValidatingType = typeof(int);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(17, 16);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.lblIdentificacion.TabIndex = 12;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 103);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdRegistroClientes);
            this.Controls.Add(this.txtNombreClientes);
            this.Controls.Add(this.mskIdentificacionClientes);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdentificacion);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdRegistroClientes;
        private System.Windows.Forms.TextBox txtNombreClientes;
        private System.Windows.Forms.MaskedTextBox mskIdentificacionClientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
    }
}
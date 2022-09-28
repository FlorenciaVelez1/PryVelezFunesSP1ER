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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
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
            this.cmdSalir.Location = new System.Drawing.Point(27, 82);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(100, 28);
            this.cmdSalir.TabIndex = 4;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalirVendedores_Click);
            // 
            // cmdRegistroClientes
            // 
            this.cmdRegistroClientes.Location = new System.Drawing.Point(163, 82);
            this.cmdRegistroClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRegistroClientes.Name = "cmdRegistroClientes";
            this.cmdRegistroClientes.Size = new System.Drawing.Size(100, 28);
            this.cmdRegistroClientes.TabIndex = 3;
            this.cmdRegistroClientes.Text = "Registrar";
            this.cmdRegistroClientes.UseVisualStyleBackColor = true;
            this.cmdRegistroClientes.Click += new System.EventHandler(this.cmdRegistroClientes_Click);
            // 
            // txtNombreClientes
            // 
            this.txtNombreClientes.Location = new System.Drawing.Point(129, 50);
            this.txtNombreClientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreClientes.Name = "txtNombreClientes";
            this.txtNombreClientes.Size = new System.Drawing.Size(132, 22);
            this.txtNombreClientes.TabIndex = 2;
            this.txtNombreClientes.TextChanged += new System.EventHandler(this.txtNombreClientes_TextChanged);
            // 
            // mskIdentificacionClientes
            // 
            this.mskIdentificacionClientes.Location = new System.Drawing.Point(129, 15);
            this.mskIdentificacionClientes.Margin = new System.Windows.Forms.Padding(4);
            this.mskIdentificacionClientes.Mask = "99999";
            this.mskIdentificacionClientes.Name = "mskIdentificacionClientes";
            this.mskIdentificacionClientes.Size = new System.Drawing.Size(132, 22);
            this.mskIdentificacionClientes.TabIndex = 1;
            this.mskIdentificacionClientes.ValidatingType = typeof(int);
            this.mskIdentificacionClientes.TextChanged += new System.EventHandler(this.mskIdentificacionClientes_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(23, 20);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(88, 16);
            this.lblIdentificacion.TabIndex = 12;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 127);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdRegistroClientes);
            this.Controls.Add(this.txtNombreClientes);
            this.Controls.Add(this.mskIdentificacionClientes);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdentificacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
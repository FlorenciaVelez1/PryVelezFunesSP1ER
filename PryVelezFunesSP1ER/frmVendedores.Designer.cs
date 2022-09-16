namespace PryVelezFunesSP1ER
{
    partial class frmVendedores
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
            this.cmdRegistroVendedores = new System.Windows.Forms.Button();
            this.txtNombreVendedores = new System.Windows.Forms.TextBox();
            this.mskIdentificacionVendedores = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.nudActivo = new System.Windows.Forms.NumericUpDown();
            this.nudComision = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComision)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(20, 167);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(100, 28);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdRegistroVendedores
            // 
            this.cmdRegistroVendedores.Location = new System.Drawing.Point(156, 167);
            this.cmdRegistroVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRegistroVendedores.Name = "cmdRegistroVendedores";
            this.cmdRegistroVendedores.Size = new System.Drawing.Size(100, 28);
            this.cmdRegistroVendedores.TabIndex = 5;
            this.cmdRegistroVendedores.Text = "Registrar";
            this.cmdRegistroVendedores.UseVisualStyleBackColor = true;
            this.cmdRegistroVendedores.Click += new System.EventHandler(this.cmdRegistroVendedores_Click);
            // 
            // txtNombreVendedores
            // 
            this.txtNombreVendedores.Location = new System.Drawing.Point(124, 50);
            this.txtNombreVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreVendedores.Name = "txtNombreVendedores";
            this.txtNombreVendedores.Size = new System.Drawing.Size(132, 22);
            this.txtNombreVendedores.TabIndex = 2;
            this.txtNombreVendedores.TextChanged += new System.EventHandler(this.txtNombreVendedores_TextChanged);
            // 
            // mskIdentificacionVendedores
            // 
            this.mskIdentificacionVendedores.Location = new System.Drawing.Point(124, 15);
            this.mskIdentificacionVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskIdentificacionVendedores.Mask = "99999";
            this.mskIdentificacionVendedores.Name = "mskIdentificacionVendedores";
            this.mskIdentificacionVendedores.Size = new System.Drawing.Size(132, 22);
            this.mskIdentificacionVendedores.TabIndex = 1;
            this.mskIdentificacionVendedores.ValidatingType = typeof(int);
            this.mskIdentificacionVendedores.TextChanged += new System.EventHandler(this.mskIdentificacionVendedores_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 57);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(17, 20);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(88, 16);
            this.lblIdentificacion.TabIndex = 12;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(17, 128);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(63, 16);
            this.lblComision.TabIndex = 18;
            this.lblComision.Text = "Comisión";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(17, 92);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(44, 16);
            this.lblActivo.TabIndex = 19;
            this.lblActivo.Text = "Activo";
            // 
            // nudActivo
            // 
            this.nudActivo.Location = new System.Drawing.Point(124, 90);
            this.nudActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudActivo.Name = "nudActivo";
            this.nudActivo.Size = new System.Drawing.Size(40, 22);
            this.nudActivo.TabIndex = 3;
            // 
            // nudComision
            // 
            this.nudComision.Location = new System.Drawing.Point(124, 122);
            this.nudComision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudComision.Name = "nudComision";
            this.nudComision.Size = new System.Drawing.Size(40, 22);
            this.nudComision.TabIndex = 4;
            this.nudComision.ValueChanged += new System.EventHandler(this.nudComision_ValueChanged);
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 210);
            this.Controls.Add(this.nudComision);
            this.Controls.Add(this.nudActivo);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdRegistroVendedores);
            this.Controls.Add(this.txtNombreVendedores);
            this.Controls.Add(this.mskIdentificacionVendedores);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdentificacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            ((System.ComponentModel.ISupportInitialize)(this.nudActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdRegistroVendedores;
        private System.Windows.Forms.TextBox txtNombreVendedores;
        private System.Windows.Forms.MaskedTextBox mskIdentificacionVendedores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.NumericUpDown nudActivo;
        private System.Windows.Forms.NumericUpDown nudComision;
    }
}
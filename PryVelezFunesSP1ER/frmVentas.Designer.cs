namespace PryVelezFunesSP1ER
{
    partial class frmVentas
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
            this.btnSalirVentas = new System.Windows.Forms.Button();
            this.btnRegistroVentas = new System.Windows.Forms.Button();
            this.mtbMontoVentas = new System.Windows.Forms.MaskedTextBox();
            this.mtbFechasVentas = new System.Windows.Forms.MaskedTextBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ComboBox();
            this.lstVendedores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalirVentas
            // 
            this.btnSalirVentas.Location = new System.Drawing.Point(12, 123);
            this.btnSalirVentas.Name = "btnSalirVentas";
            this.btnSalirVentas.Size = new System.Drawing.Size(67, 23);
            this.btnSalirVentas.TabIndex = 20;
            this.btnSalirVentas.Text = "Salir";
            this.btnSalirVentas.UseVisualStyleBackColor = true;
            // 
            // btnRegistroVentas
            // 
            this.btnRegistroVentas.Location = new System.Drawing.Point(97, 123);
            this.btnRegistroVentas.Name = "btnRegistroVentas";
            this.btnRegistroVentas.Size = new System.Drawing.Size(67, 23);
            this.btnRegistroVentas.TabIndex = 19;
            this.btnRegistroVentas.Text = "Registrar";
            this.btnRegistroVentas.UseVisualStyleBackColor = true;
            this.btnRegistroVentas.Click += new System.EventHandler(this.btnRegistroVentas_Click);
            // 
            // mtbMontoVentas
            // 
            this.mtbMontoVentas.Location = new System.Drawing.Point(72, 36);
            this.mtbMontoVentas.Mask = "999999999";
            this.mtbMontoVentas.Name = "mtbMontoVentas";
            this.mtbMontoVentas.Size = new System.Drawing.Size(92, 20);
            this.mtbMontoVentas.TabIndex = 16;
            this.mtbMontoVentas.ValidatingType = typeof(int);
            // 
            // mtbFechasVentas
            // 
            this.mtbFechasVentas.Location = new System.Drawing.Point(72, 9);
            this.mtbFechasVentas.Mask = "00/00/0000";
            this.mtbFechasVentas.Name = "mtbFechasVentas";
            this.mtbFechasVentas.Size = new System.Drawing.Size(68, 20);
            this.mtbFechasVentas.TabIndex = 15;
            this.mtbFechasVentas.ValidatingType = typeof(System.DateTime);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(12, 93);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(56, 13);
            this.lblVendedorID.TabIndex = 14;
            this.lblVendedorID.Text = "Vendedor:";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(12, 66);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(42, 13);
            this.lblClienteID.TabIndex = 13;
            this.lblClienteID.Text = "Cliente:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 39);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            // 
            // lstClientes
            // 
            this.lstClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(72, 62);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(92, 21);
            this.lstClientes.TabIndex = 21;
            // 
            // lstVendedores
            // 
            this.lstVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedores.FormattingEnabled = true;
            this.lstVendedores.Location = new System.Drawing.Point(74, 89);
            this.lstVendedores.Name = "lstVendedores";
            this.lstVendedores.Size = new System.Drawing.Size(90, 21);
            this.lstVendedores.TabIndex = 22;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 158);
            this.Controls.Add(this.lstVendedores);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnSalirVentas);
            this.Controls.Add(this.btnRegistroVentas);
            this.Controls.Add(this.mtbMontoVentas);
            this.Controls.Add(this.mtbFechasVentas);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirVentas;
        private System.Windows.Forms.Button btnRegistroVentas;
        private System.Windows.Forms.MaskedTextBox mtbMontoVentas;
        private System.Windows.Forms.MaskedTextBox mtbFechasVentas;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox lstClientes;
        private System.Windows.Forms.ComboBox lstVendedores;
    }
}
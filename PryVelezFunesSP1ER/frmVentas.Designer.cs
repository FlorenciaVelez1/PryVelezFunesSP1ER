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
            this.cmdSalirVentas = new System.Windows.Forms.Button();
            this.cmdRegistroVentas = new System.Windows.Forms.Button();
            this.mskMontoVentas = new System.Windows.Forms.MaskedTextBox();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lstClientesID = new System.Windows.Forms.ComboBox();
            this.lstVendedoresID = new System.Windows.Forms.ComboBox();
            this.lblTipoDeFactura = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lstTipoDeFactura = new System.Windows.Forms.ComboBox();
            this.mskNumeroFactura = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmdSalirVentas
            // 
            this.cmdSalirVentas.Location = new System.Drawing.Point(16, 176);
            this.cmdSalirVentas.Name = "cmdSalirVentas";
            this.cmdSalirVentas.Size = new System.Drawing.Size(67, 23);
            this.cmdSalirVentas.TabIndex = 20;
            this.cmdSalirVentas.Text = "Salir";
            this.cmdSalirVentas.UseVisualStyleBackColor = true;
            this.cmdSalirVentas.Click += new System.EventHandler(this.cmdSalirVentas_Click);
            // 
            // cmdRegistroVentas
            // 
            this.cmdRegistroVentas.Location = new System.Drawing.Point(101, 176);
            this.cmdRegistroVentas.Name = "cmdRegistroVentas";
            this.cmdRegistroVentas.Size = new System.Drawing.Size(67, 23);
            this.cmdRegistroVentas.TabIndex = 19;
            this.cmdRegistroVentas.Text = "Registrar";
            this.cmdRegistroVentas.UseVisualStyleBackColor = true;
            this.cmdRegistroVentas.Click += new System.EventHandler(this.cmdRegistroVentas_Click);
            // 
            // mskMontoVentas
            // 
            this.mskMontoVentas.Location = new System.Drawing.Point(76, 61);
            this.mskMontoVentas.Mask = "999999999";
            this.mskMontoVentas.Name = "mskMontoVentas";
            this.mskMontoVentas.Size = new System.Drawing.Size(92, 20);
            this.mskMontoVentas.TabIndex = 16;
            this.mskMontoVentas.ValidatingType = typeof(int);
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(100, 141);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(68, 20);
            this.mskFecha.TabIndex = 15;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(14, 39);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(56, 13);
            this.lblVendedorID.TabIndex = 14;
            this.lblVendedorID.Text = "Vendedor:";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(14, 13);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(42, 13);
            this.lblClienteID.TabIndex = 13;
            this.lblClienteID.Text = "Cliente:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(14, 66);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 145);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            // 
            // lstClientesID
            // 
            this.lstClientesID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstClientesID.FormattingEnabled = true;
            this.lstClientesID.Location = new System.Drawing.Point(74, 7);
            this.lstClientesID.Name = "lstClientesID";
            this.lstClientesID.Size = new System.Drawing.Size(92, 21);
            this.lstClientesID.TabIndex = 21;
            // 
            // lstVendedoresID
            // 
            this.lstVendedoresID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedoresID.FormattingEnabled = true;
            this.lstVendedoresID.Location = new System.Drawing.Point(76, 35);
            this.lstVendedoresID.Name = "lstVendedoresID";
            this.lstVendedoresID.Size = new System.Drawing.Size(90, 21);
            this.lstVendedoresID.TabIndex = 22;
            // 
            // lblTipoDeFactura
            // 
            this.lblTipoDeFactura.AutoSize = true;
            this.lblTipoDeFactura.Location = new System.Drawing.Point(14, 118);
            this.lblTipoDeFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDeFactura.Name = "lblTipoDeFactura";
            this.lblTipoDeFactura.Size = new System.Drawing.Size(82, 13);
            this.lblTipoDeFactura.TabIndex = 23;
            this.lblTipoDeFactura.Text = "Tipo de Factura";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(14, 92);
            this.lblNumeroFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(58, 13);
            this.lblNumeroFactura.TabIndex = 24;
            this.lblNumeroFactura.Text = "N° Factura";
            // 
            // lstTipoDeFactura
            // 
            this.lstTipoDeFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipoDeFactura.FormattingEnabled = true;
            this.lstTipoDeFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoDeFactura.Location = new System.Drawing.Point(100, 115);
            this.lstTipoDeFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTipoDeFactura.Name = "lstTipoDeFactura";
            this.lstTipoDeFactura.Size = new System.Drawing.Size(67, 21);
            this.lstTipoDeFactura.TabIndex = 25;
            // 
            // mskNumeroFactura
            // 
            this.mskNumeroFactura.Location = new System.Drawing.Point(100, 89);
            this.mskNumeroFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskNumeroFactura.Name = "mskNumeroFactura";
            this.mskNumeroFactura.Size = new System.Drawing.Size(68, 20);
            this.mskNumeroFactura.TabIndex = 26;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 214);
            this.Controls.Add(this.mskNumeroFactura);
            this.Controls.Add(this.lstTipoDeFactura);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblTipoDeFactura);
            this.Controls.Add(this.lstVendedoresID);
            this.Controls.Add(this.lstClientesID);
            this.Controls.Add(this.cmdSalirVentas);
            this.Controls.Add(this.cmdRegistroVentas);
            this.Controls.Add(this.mskMontoVentas);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalirVentas;
        private System.Windows.Forms.Button cmdRegistroVentas;
        private System.Windows.Forms.MaskedTextBox mskMontoVentas;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox lstClientesID;
        private System.Windows.Forms.ComboBox lstVendedoresID;
        private System.Windows.Forms.Label lblTipoDeFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.ComboBox lstTipoDeFactura;
        private System.Windows.Forms.MaskedTextBox mskNumeroFactura;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PryVelezFunesSP1ER
{
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdRegistroVendedores_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (File.Exists("./Vendedores.txt"))
            {
                StreamReader srControlVendedores = new StreamReader("./Vendedores.txt");
                while (!srControlVendedores.EndOfStream)
                {
                    string auxClientes = srControlVendedores.ReadLine();
                    string[] Clientes = auxClientes.Split(',');
                    if (mskIdentificacionVendedores.Text == Clientes[0])
                    {
                        MessageBox.Show("El ID del vendedor se ha repetido, intentelo nuevamente");
                        mskIdentificacionVendedores.Text = "";
                        mskIdentificacionVendedores.Focus();
                        bandera = true;
                    }
                }
                srControlVendedores.Close();
            }
            if (bandera == false)
            {
                StreamWriter swCargaVentas = new StreamWriter("./Vendedores.txt", true);
                swCargaVentas.WriteLine(mskIdentificacionVendedores.Text + "," + txtNombreVendedores.Text + "," + nudActivo.Text + "," + nudComision.Text);
                MessageBox.Show("Datos del vendedor cargado correctamente");
                swCargaVentas.Close();
                nudComision.Value = 0;
                nudActivo.Value = 0;
                mskIdentificacionVendedores.Text = "";
                txtNombreVendedores.Text = "";
            }
        }
        private void mskIdentificacionVendedores_TextChanged(object sender, EventArgs e)
        {
            if (mskIdentificacionVendedores.Text != "" & txtNombreVendedores.Text != "")
            {
                cmdRegistroVendedores.Enabled = true;
            }
            else
            {
                cmdRegistroVendedores.Enabled = false;
            }
        }
        private void txtNombreVendedores_TextChanged(object sender, EventArgs e)
        {
            if (mskIdentificacionVendedores.Text != "" & txtNombreVendedores.Text != "")
            {
                cmdRegistroVendedores.Enabled = true;
            }
            else
            {
                cmdRegistroVendedores.Enabled = false;
            }
        }
        private void nudComision_ValueChanged(object sender, EventArgs e)
        {
            nudComision.Maximum = 0;
            nudComision.Minimum = -1;
        }
    }
}

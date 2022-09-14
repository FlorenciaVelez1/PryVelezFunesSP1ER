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
            StreamReader ControlVendedores = new StreamReader("./Vendedores.txt");
            bool bandera = false;
            while (!ControlVendedores.EndOfStream)
            {
                string auxVendedores = ControlVendedores.ReadLine();
                string[] vecVendedores = auxVendedores.Split(',');
                if (vecVendedores[0] == auxVendedores)
                {
                    MessageBox.Show("Numero del cliente repetido");
                    mskIdentificacionVendedores.Text = "";
                    bandera = true;
                }
            }
            ControlVendedores.Close();
            if (bandera == false)
            {
                StreamWriter CargaVentas = new StreamWriter("./Vendedores.txt", true);
                CargaVentas.WriteLine(mskIdentificacionVendedores.Text + "," + txtNombreVendedores.Text);//mskActivo.Text + "," + mskComision.Text + "," + );
                MessageBox.Show("Venta cargada correctamente");
                CargaVentas.Close();
               // mskActivo.Text = "";
               // mskComision.Text = "";
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
    }
}

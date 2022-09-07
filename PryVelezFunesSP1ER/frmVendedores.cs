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
            bool VerificacionCodigo = false;
            StreamReader IDVendedores = new StreamReader("./Vendedores.txt");
            while (!IDVendedores.EndOfStream)
            {
                if(mskIdentificacionVendedores.Text == IDVendedores.ReadLine())
                {
                    MessageBox.Show("El identificador de cliente se repite, revise nuevamente");
                    VerificacionCodigo = true;
                }
            }
            IDVendedores.Close();
            if(VerificacionCodigo == false)
            {
                StreamWriter Vendedores = new StreamWriter("./Vendedores.txt", true);
                Vendedores.WriteLine(mskIdentificacionVendedores.Text + ";" + txtNombreVendedores.Text);
                MessageBox.Show("Datos guardados correctamente");
                Vendedores.Close();
                mskIdentificacionVendedores.Text = "";
                txtNombreVendedores.Text = "";
            }
        }
    }
}

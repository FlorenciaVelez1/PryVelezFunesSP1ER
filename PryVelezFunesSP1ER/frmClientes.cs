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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void cmdSalirVendedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdRegistroClientes_Click(object sender, EventArgs e)
        {
            StreamReader ControlClientes = new StreamReader("./Clientes.txt");
            bool bandera = false;
            while (!ControlClientes.EndOfStream)
            {
                string auxClientes = ControlClientes.ReadLine();
                string[] Clientes = auxClientes.Split(',');
                if (mskIdentificacionClientes.Text == Clientes[0])
                {
                    MessageBox.Show("Numero del cliente se ha repetido, intentelo nuevamente");
                    mskIdentificacionClientes.Text = "";
                    bandera = true;
                }
            }
            ControlClientes.Close();
            if (bandera == false)
            {
                StreamWriter srCargaClientes = new StreamWriter("./Clientes.txt", true);
                srCargaClientes.WriteLine(mskIdentificacionClientes.Text + "," + txtNombreClientes.Text);
                MessageBox.Show("Cliente cargado correctamente");
                srCargaClientes.Close();
                txtNombreClientes.Text = "";
                mskIdentificacionClientes.Text = "";
            }
        }
        private void mskIdentificacionClientes_TextChanged(object sender, EventArgs e)
        {
            if(mskIdentificacionClientes.Text != "" & txtNombreClientes.Text != "")
            {
                cmdRegistroClientes.Enabled = true;
            }
            else
            {
                cmdRegistroClientes.Enabled = false;    
            }
        }
        private void txtNombreClientes_TextChanged(object sender, EventArgs e)
        {
            if (mskIdentificacionClientes.Text != "" & txtNombreClientes.Text != "")
            {
                cmdRegistroClientes.Enabled = true;
            }
            else
            {
                cmdRegistroClientes.Enabled = false;
            }
        }
    }
}

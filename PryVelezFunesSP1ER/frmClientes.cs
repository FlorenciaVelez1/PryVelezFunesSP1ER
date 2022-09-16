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
            bool bandera = false;
            if (File.Exists("./Clientes.txt"))
            {
                StreamReader srControlClientes = new StreamReader("./Clientes.txt");
                
                while (!srControlClientes.EndOfStream)
                {
                    string auxClientes = srControlClientes.ReadLine();
                    string[] Clientes = auxClientes.Split(',');
                    if (mskIdentificacionClientes.Text == Clientes[0])
                    {
                        MessageBox.Show("El número del cliente se ha repetido, intentelo nuevamente");
                        mskIdentificacionClientes.Text = "";
                        mskIdentificacionClientes.Focus();
                        bandera = true;
                    }
                }
                srControlClientes.Close();
            }
            if (bandera == false)
            {
                StreamWriter swCargaClientes = new StreamWriter("./Clientes.txt", true);
                swCargaClientes.WriteLine(mskIdentificacionClientes.Text + "," + txtNombreClientes.Text);
                MessageBox.Show("Cliente cargado correctamente");
                swCargaClientes.Close();
                txtNombreClientes.Text = "";
                mskIdentificacionClientes.Text = "";
                mskIdentificacionClientes.Focus();
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

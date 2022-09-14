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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }
        private void cmdSalirVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamReader LeerIDVendedor = new StreamReader("./Vendedores.txt");

            while (!LeerIDVendedor.EndOfStream)
            {
                string varLeerIDVendedor = LeerIDVendedor.ReadLine();
                string[] vecLeerIDVendedor = varLeerIDVendedor.Split(',');
                lstVendedoresID.Items.Add(vecLeerIDVendedor[0]);
            }
            LeerIDVendedor.Close();
            StreamReader LeerIDCliente = new StreamReader("./Clientes.txt");
            while (!LeerIDCliente.EndOfStream)
            {
                string varLeerIDCliente = LeerIDCliente.ReadLine();
                string[] vecLeerIDCliente = varLeerIDCliente.Split(',');
                lstClientesID.Items.Add(vecLeerIDCliente[0]);
            }
            LeerIDCliente.Close();
        }
        private void cmdRegistroVentas_Click(object sender, EventArgs e)
        {
            StreamWriter CargarVentas = new StreamWriter("./Ventas.txt", true);
            CargarVentas.WriteLine(lstClientesID.Text + "," + lstVendedoresID.Text + "," + mskNumeroFactura.Text + "," + lstTipoDeFactura.SelectedItem + "," + mskFecha.Text + "," + mskMontoVentas.Text);
            MessageBox.Show("Venta Cargada");
            CargarVentas.Close();
            lstClientesID.SelectedIndex = -1;
            lstVendedoresID.SelectedIndex = -1;
            mskMontoVentas.Text = "";
            mskNumeroFactura.Text = "";
            lstTipoDeFactura.SelectedIndex = -1;
            mskFecha.Text = "";
        }
    }
}

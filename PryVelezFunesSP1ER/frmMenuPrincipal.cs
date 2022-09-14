using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryVelezFunesSP1ER
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes Clientes = new frmClientes();
            Clientes.ShowDialog();  
        }
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedores Vendedores = new  frmVendedores();
            Vendedores.ShowDialog();
        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas Ventas = new frmVentas();
            Ventas.ShowDialog();
        }
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClientes ConsultaClientes = new frmConsultaClientes();
            ConsultaClientes.ShowDialog();
        }
    }
}

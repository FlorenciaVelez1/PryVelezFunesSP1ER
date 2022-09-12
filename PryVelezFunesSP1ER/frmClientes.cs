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

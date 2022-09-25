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
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            grillaClientes.Rows.Clear();
        }
        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader Clientes = new StreamReader("./Clientes.txt");
            while (!Clientes.EndOfStream)
            {
                string DatosClientes = Clientes.ReadLine();
                string[] vectorDatosClientes = DatosClientes.Split((','));
                grillaClientes.Rows.Add(vectorDatosClientes[0], vectorDatosClientes[1]);
            }
            Clientes.Close();
        }
    }
}

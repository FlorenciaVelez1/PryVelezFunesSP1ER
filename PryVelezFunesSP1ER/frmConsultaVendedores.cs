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
    public partial class frmConsultaVendedores : Form
    {
        public frmConsultaVendedores()
        {
            InitializeComponent();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            grillaVendedores.Rows.Clear();
        }
        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader Vendedores = new StreamReader("./Vendedores.txt");
            while (!Vendedores.EndOfStream)
            {
                string DatosVendedores = Vendedores.ReadLine();
                string[] vectorDatosVendedores = DatosVendedores.Split((','));
                grillaVendedores.Rows.Add(vectorDatosVendedores[0], vectorDatosVendedores[1], vectorDatosVendedores[2], vectorDatosVendedores[3]);
            }
            Vendedores.Close();
        }
    }
}

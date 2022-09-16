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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }
        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader Ventas = new StreamReader("./Ventas.txt");
            while (!Ventas.EndOfStream)
            {
                string DatosClientes = Ventas.ReadLine();
                string[] vectorDatosVentas = DatosClientes.Split((','));
                grillaVentas.Rows.Add(vectorDatosVentas[0], vectorDatosVentas[1], vectorDatosVentas[2], vectorDatosVentas[3], vectorDatosVentas[4], vectorDatosVentas[5]);
            }
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            grillaVentas.Rows.Clear();
        }
    }
}

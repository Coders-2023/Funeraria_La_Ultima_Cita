using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funeraria.clases;

namespace Funeraria
{
    public partial class tercerapantalla : Form
    {
        public tercerapantalla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fichasdepago = new cuartapantalla();
            fichasdepago.Show();
            this.Close();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form regresar = new segundapantalla();
            regresar.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //cboxplansugerido;
            //oCliente.plansugerido = CL_Plan;
        }
    }
}

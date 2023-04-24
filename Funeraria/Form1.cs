using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pboxeconomico_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            Form datoscliente = new segundapantalla();
            datoscliente.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pboxestandar_Click(object sender, EventArgs e)
        {

        }

        private void pboxoro_Click(object sender, EventArgs e)
        {

        }

        private void pboxdiamante_Click(object sender, EventArgs e)
        {

        }

        private void lblplanfunera_Click(object sender, EventArgs e)
        {

        }
    }
}

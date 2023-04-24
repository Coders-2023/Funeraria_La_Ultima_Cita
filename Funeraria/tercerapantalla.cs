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
    }
}

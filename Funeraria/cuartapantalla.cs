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
    public partial class cuartapantalla : Form
    {
        public cuartapantalla()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form menuprincipal = new Form1();
            menuprincipal.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form regresar = new tercerapantalla();
            regresar.Show();
        }
    }
}

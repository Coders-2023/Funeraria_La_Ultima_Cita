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
    public partial class segundapantalla : Form
    {
        public segundapantalla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form datosplanfunerario = new tercerapantalla();
            datosplanfunerario.Show();
            this.Close();
        }

        private void segundapantalla_Load(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form regresar = new Form1();
            regresar.Show();
        }
    }
}

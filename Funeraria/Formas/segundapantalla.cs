using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using Funeraria.clases;

namespace Funeraria
{
    public partial class segundapantalla : Form
    {
        clsCliente oCliente = new clsCliente();
        string Sconexion;
        char casado; // "Y" igual a casado
        public segundapantalla()
        {
            InitializeComponent();
            Sconexion = conexion.conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form datosplanfunerario = new tercerapantalla();
            //datosplanfunerario.Show();
            VeriyfyRADS();
           // this.Close();
        }

        public void VeriyfyRADS()
        { 
            if (rbtncasado.Checked) casado = 'Y';
            else casado = 'N';
        }
        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form regresar = new Form1();
            regresar.Show();
        }

        private void GuardarCliente()
        {
            //oCliente.idcliente = Convert.ToInt32(txtid.Text);
            oCliente.nombre = txtnombrecliente.Text;
            oCliente.domicilio = txtdomicilio.Text;
            oCliente.estadocivil = casado;
            oCliente.ingresoMen = Convert.ToInt32(txtingresomen.Text);
            oCliente.ingresoAcum = Convert.ToInt32(txtingresoacu.Text);
            //oCliente.plansugerido = cboxplansugerido.Text.Substring(0, 1);
            if (oCliente.GuardarCliente() == true)
            {
                MessageBox.Show("Datos guardados correctamente");
                //limpiar();
                //rellenar();
            }
            else
            {
                MessageBox.Show("Datos no guardados");
            }
           // limpiar();

        }

        private void rbtncasado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtncasado.Checked == false)
            {
                cboxhijos.Enabled = false;
                
            } else
            {
                cboxhijos.Enabled = true;
            }
        }
    }
}

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
using System.Collections;

namespace Funeraria
{
    public partial class segundapantalla : Form
    {
        SqlConnection con = new SqlConnection(conexion.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        clsCliente oCliente = new clsCliente();
        Limpiar l = new Limpiar();
        string Sconexion, query, CL_Nombre, CL_Id, CL_Domicilio, CL_Hijos, CL_inMensual, CL_inAcumulado, CL_Plan;
        bool band, casado;
        public segundapantalla()
        {
            InitializeComponent();
            Sconexion = conexion.conectar();
        }
        private void segundapantalla_Load(object sender, EventArgs e)
        {
            Actualizar_Data();
        }
        #region Botones
        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            Set_Data_Variables();
            if (Verify_Data())
            {
                MessageBox.Show("Verifique que los datos esten llenados","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                GuardarCliente();
            }
            Actualizar_Data();
        }
        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form regresar = new Form1();
            regresar.Show();
        }
        private void rbtncasado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtncasado.Checked == false)
            {
                cboxhijos.Enabled = false;
                casado = false;
            } 
            else
            {
                cboxhijos.Enabled = true;
                casado = true;
            }
        }
        #endregion
        #region Metodos
        public void Set_Data_Variables()
        {
            CL_Nombre = txtnombrecliente.Text;
            CL_Id = TXB_ID.Text;
            CL_Domicilio = txtdomicilio.Text;
            CL_inAcumulado = txtingresoacu.Text;
            CL_inMensual = txtingresomen.Text;
            CL_Hijos = cboxhijos.Text;
            CL_Plan = cboxplansugerido.Text;
        }
        public bool Verify_Data()
        {
            if (CL_Nombre == "" || CL_Id == "" || CL_inAcumulado == "" || CL_inMensual == "" || CL_Hijos == "")
                band = true;
            else band = false;
            return band;
        }
        private void GuardarCliente()
        {
            oCliente.idcliente = Convert.ToInt32(CL_Id);
            oCliente.nombre = CL_Nombre;
            oCliente.domicilio = CL_Domicilio;
            oCliente.estadocivil = casado;
            oCliente.hijos = Convert.ToInt32(CL_Hijos);
            oCliente.ingresoMen = (float)Convert.ToDouble(CL_inMensual);
            oCliente.ingresoAcum = (float)Convert.ToDouble(CL_inAcumulado);
            //oCliente.plansugerido = CL_Plan;
            if (oCliente.GuardarCliente())
            {
                MessageBox.Show("Datos guardados correctamente");
            }
            else
            {
                MessageBox.Show("Datos no guardados");
            }
            l.BorrarCampos(this);
        }
        public void Actualizar_Data()
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Funeraria.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dS_Funeraria.clientes);
            ConsecutivoID();
        }
        public void ConsecutivoID()
        {
            query = "SELECT ISNULL(MAX(idcliente),0) + 1 " +
                    "FROM clientes";
            con.Open();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TXB_ID.Text = Convert.ToString(dr.GetInt32(0));
                dr.Close();
            }
            con.Close();
        }
        #endregion
    }
}

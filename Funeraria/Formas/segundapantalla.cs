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
using static System.Net.Mime.MediaTypeNames;

namespace Funeraria
{
    public partial class segundapantalla : Form
    {
        SqlConnection con = new SqlConnection(conexion.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        clsCliente oCliente = new clsCliente();
        Limpiar l = new Limpiar();
        clsMetricas clmet = new clsMetricas();
        string Sconexion, query, CL_Nombre, CL_Id, CL_Domicilio, CL_Hijos, CL_inMensual, CL_inAcumulado, CL_Plan;
        bool band, casado;
        byte estadocivil;
        int hijos, paquete;
        double ingresos;
        double acumulables;
        public segundapantalla()
        {
            InitializeComponent();
            Sconexion = conexion.conectar();
        }

        private void DTG_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           CL_Id = DTG_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
           CL_Nombre = DTG_Clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
           CL_Domicilio = DTG_Clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
           if (DTG_Clientes.Rows[e.RowIndex].Cells[3].Value.ToString() == "0") rbtnsoltero.Checked = true;
           else rbtncasado.Checked = true;
           CL_Hijos = DTG_Clientes.Rows[e.RowIndex].Cells[4].Value.ToString();
           CL_inMensual = DTG_Clientes.Rows[e.RowIndex].Cells[5].Value.ToString();
           CL_inAcumulado = DTG_Clientes.Rows[e.RowIndex].Cells[6].Value.ToString();
           CL_Plan = DTG_Clientes.Rows[e.RowIndex].Cells[7].Value.ToString();

            TXB_ID.Text = CL_Id;
            txtnombrecliente.Text = CL_Nombre;
            txtdomicilio.Text = CL_Domicilio;
            txtingresoacu.Text = CL_inAcumulado;
            txtingresomen.Text = CL_inMensual;
            cboxhijos.Text = CL_Hijos;
            cboxplansugerido.Text = CL_Plan;
        }

        private void segundapantalla_Load(object sender, EventArgs e)
        {
            Actualizar_Data();
        }


        private void txtingresomen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Desicion_Rules();
                BTN_Guardar.Focus();

                txtingresoacu.Text = acumulables.ToString ("N2");
                Acumulable();

                //txtingresomen.Text = ingresos.ToString("N2"); ;
                //FormatoMoneda(txtingresomen);
            }


        }

        private void txtingresomen_TextChanged(object sender, EventArgs e)
        {
            //txtingresomen.Text = Form(lblingresosmensuales, "$ #0.00");

        }

        private void DTG_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region Botones
        public void BTN_Guardar_Click(object sender, EventArgs e)
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

        public void btncontinuar_Click(object sender, EventArgs e)
        {
            //Form pantalla = new tercerapantalla();
            //pantalla.Show();
            //this.Hide();


            
            tercerapantalla tercera = new tercerapantalla();
            tercera.cboxplansugerido2.Text = cboxplansugerido.Text;
            tercera.Show();
            //AddOwnedForm(FHPP);
            //cboxplansugerido.Text = this.txtplan();
            //FHPP.Show();
        }


        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        #endregion

        #region Metodos
        public void Eliminar()
        {
            Set_Data_Variables();
            oCliente.EliminarCliente();
            Actualizar_Data();
        }


        public void Set_Data_Variables()
        {
            CL_Nombre = txtnombrecliente.Text;
            CL_Id = TXB_ID.Text;
            CL_Domicilio = txtdomicilio.Text;
            CL_inAcumulado = txtingresoacu.Text;
            CL_inMensual = txtingresomen.Text;
            if(rbtnsoltero.Checked) CL_Hijos = "0";
            else CL_Hijos = cboxhijos.Text;
            CL_Plan = cboxplansugerido.Text;
        }
        public int Acumulable() //REGLAS DE DECISIÓN: (PARA EL PLAN SUGERIDO)
        {

            // acum sera la cantidad del ingreso acumulable
            if (acumulables <= 3000)
            {
                MessageBox.Show("Se sugiere usar el Plan Economico para este cliente.");
                paquete = 1;
            }
            if (acumulables >= 3001 && acumulables <= 8000)
            {
                MessageBox.Show("Se sugiere usar el Plan Estandar para este cliente.");
                paquete = 2;
            }
            if (acumulables >= 8001 && acumulables <= 15000)
            {
                MessageBox.Show("Se sugiere usar el Plan Oro para este cliente.");
                paquete = 3;
            }
            if (acumulables >= 15001)
            {
                MessageBox.Show("Se sugiere usar el Plan Diamante para este cliente.");
                paquete = 4;
            }
            return paquete;
        }
        public void Desicion_Rules() // En base al ingreso registrado, registrar el procentaje de su ingreso acumulable
        {
            Set_Data_Variables();
            if (rbtncasado.Checked) estadocivil = 1;
            else estadocivil = 0;
            hijos = Convert.ToInt32(CL_Hijos);
            ingresos = Convert.ToDouble(CL_inMensual);
            // soltero 0, casado 1
            try
            {
                if (estadocivil == 0 && hijos == 0) // soltero y sin hijos
                {
                    acumulables = ingresos * 0.80;
                }
                if (estadocivil == 1 && hijos == 0) // casado y sin hijos
                {
                    acumulables = ingresos * 0.60;
                }
                if (estadocivil == 1 && hijos == 1) // casado y con 1 hijo
                {
                    acumulables = ingresos * 0.50;
                }
                if (estadocivil == 1 && hijos == 2) // casado y con 2 hijos
                {
                    acumulables = ingresos * 0.45;
                }
                if (estadocivil == 1 && hijos >= 3) // casado y con 3 hijos o mas
                {
                    acumulables = ingresos * 0.40;
                }
                txtingresoacu.Text = acumulables.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Ha ocurrido la siguiente excepcion: " + ex);
            }
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
            oCliente.plansugerido = CL_Plan;
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
            // this.clientesTableAdapter.Fill(this.dS_Funeraria.clientes);
            // TODO: esta línea de código carga datos en la tabla 'dS_Clientes_Melisa.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dS_Clientes_Melisa.clientes);
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

        public void FormatoMoneda(TextBox xTBox)
        {
            if (xTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;

                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");
            }
        }


        private void txtingresomen_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtingresomen);
        }

        private void txtingresoacu_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtingresoacu);
        }
    }
}

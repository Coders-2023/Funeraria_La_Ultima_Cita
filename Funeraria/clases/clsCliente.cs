using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Funeraria.clases
{
    class clsCliente
    {
        SqlConnection con = new SqlConnection(conexion.conectar());
        SqlCommand cmd;
        bool respuesta;
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public string domicilio{ get; set; }
        public bool estadocivil { get; set; }
        public int hijos { get; set; }
        public float ingresoMen { get; set; }
        public float ingresoAcum { get; set; }
        public string plansugerido { get; set; }


        public void Set_Data()
        {
            cmd.Parameters.AddWithValue("@IDCLIENTE", idcliente);
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DOMICILIO", domicilio);
            cmd.Parameters.AddWithValue("@ESTADOCIVIL", estadocivil);
            cmd.Parameters.AddWithValue("@HIJOS", hijos);
            cmd.Parameters.AddWithValue("@INGRESOMEN", ingresoMen);
            cmd.Parameters.AddWithValue("@INGRESOACUM", ingresoAcum);
            cmd.Parameters.AddWithValue("@PLANSUGERIDO", plansugerido);
        }
        public bool GuardarCliente()
        {
            cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTE";
    
            cmd.Parameters.AddWithValue("@OP", 1);
            Set_Data();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex);
                respuesta = false;
            }
            con.Close();
    
            return respuesta;
        }
        public bool EliminarCliente()
        {
            cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTE";

            cmd.Parameters.AddWithValue("@OP", 2);
            Set_Data();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminación cumplida");
                respuesta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex);
                respuesta = false;
            }
            con.Close();

            return respuesta;
        }
   
    }
}

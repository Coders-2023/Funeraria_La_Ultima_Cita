using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Funeraria.clases
{
    class clsCliente
    {
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public string domicilio{ get; set; }
        public char estadocivil { get; set; }
        public bool hijos { get; set; }
        public int ingresoMen { get; set; }
        public int ingresoAcum { get; set; }
    
    public bool GuardarCliente()
    {

        SqlConnection con = new SqlConnection(conexion.conectar());
        SqlCommand cmd = new SqlCommand("", con);
        bool respuesta;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "SP_CLIENTE";

        cmd.Parameters.AddWithValue("@OP", 1);
        cmd.Parameters.AddWithValue("@IDCLIENTE", idcliente);
        cmd.Parameters.AddWithValue("@NOMBRE", nombre);
        cmd.Parameters.AddWithValue("@DOMICILIO", domicilio);
        cmd.Parameters.AddWithValue("@ESTADOCIVIL", estadocivil);
        cmd.Parameters.AddWithValue("@HIJOS", hijos);
        cmd.Parameters.AddWithValue("@INGRESOMEN", ingresoMen);
        cmd.Parameters.AddWithValue("@INGRESOACUM", ingresoAcum);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            respuesta = true;
        }
        catch (Exception ex)
        {
            respuesta = false;
        }
        con.Close();

        return respuesta;
     }
   }
}

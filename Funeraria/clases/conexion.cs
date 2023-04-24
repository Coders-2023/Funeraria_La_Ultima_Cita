using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria.clases
{
    class conexion
    {
       public static string conectar()
        {
            string servidor = "FALCON-DELL\\FALCONSQL";
            string conex = @"Data Source = "+servidor+"; Initial Catalog = funeraria; Integrated Security = True";
            return conex;
        }
    }
}

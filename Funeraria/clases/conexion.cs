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

            string conex = @"Data Source =LAPTOP-FV3BA69A; Initial Catalog = funeraria; Integrated Security = True";
            return conex;

        }
    }
}

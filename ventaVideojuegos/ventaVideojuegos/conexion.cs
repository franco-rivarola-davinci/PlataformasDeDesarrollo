using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ventaVideojuegos
{
    class Conexion
    {

        public static SqlConnection Conectar()
        {
           SqlConnection cn = new SqlConnection("Data Source=DESKTOP-Q0LUSNR;" + "Initial Catalog=bd_tiendaPdesarrollo;" + "Integrated Security=SSPI;");

            cn.Open();

          return cn;

        }

    }
}

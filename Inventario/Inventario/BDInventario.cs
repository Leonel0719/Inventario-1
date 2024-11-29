using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventario
{
    public class BDInventario
    {

        public static SqlConnection conexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDInventario;Data Source=LeonelPc");
            conexion.Open();

            return conexion;
        }

    }
}

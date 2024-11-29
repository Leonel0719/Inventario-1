using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

//Esta clase nos sirve para conectarnos hacia la base de datos.
//Se agrego el using System.Data.sqlClient que sirve para conectarse a SQLServer.

namespace Inventario
{
    public class BDInventario
    {
        public static SqlConnection conexion()
        {
            //Aqui utilizamos la cadena de conexion que nos da SQLServer y añadimos la base de datos a la que deseamos acceder.
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDInventario;Data Source=LeonelPc");
            conexion.Open();
            
            return conexion;
        }

    }
}

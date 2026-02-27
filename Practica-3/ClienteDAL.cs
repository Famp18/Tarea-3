using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class ClienteDAL
    {
        public static int AgregarCliente(Cliente cliente)
        {

            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "insert into cliente (nombre,apellido,direccion,sexo) values('" + cliente.Nombre + "', " + cliente.apellido + "'  )";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }
    }
}

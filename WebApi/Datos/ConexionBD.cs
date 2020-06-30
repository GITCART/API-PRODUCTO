using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Datos
{
    public class ConexionBD
    {
        public static string cadenaConexion = null;

        public SqlConnection GetConexionBD()
        {
            SqlConnection cn;

            if (string.IsNullOrWhiteSpace(cadenaConexion))
            {
                cn = new SqlConnection("Server = DESKTOP-ROFDLC2\\MSSQLSERVER01; Database = servicios; User Id = sa; Password = sqlserver");
            }
            else
            {
                cn = new SqlConnection(cadenaConexion);
            }

            return cn;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Reflection;
using WebApi.Datos;
using WebApi.Models;

namespace WebApi.Logica
{
    public class ProductoLN
    {

        public List<ProductoEN> ListarProductos(out string mensaje)
        {
            mensaje = "Error al obtener la cadena de conexión a la data.";

            try
            {
                ConexionBD objetoConexion = new ConexionBD();

                using (SqlConnection cn = objetoConexion.GetConexionBD())
                {
                    mensaje = "Error al abrir la conexión a la data.";

                    cn.Open();

                    mensaje = "Error al asignar la conexión a SqlCommand.";

                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = cn
                    };

                    ProductoDN productoDN = new ProductoDN();

                    return productoDN.ListarProductos(cn, cmd, out mensaje);
                }
            }
            catch (Exception ex)
            {
                mensaje += "\r\n\n" + ex.Message + "\r\n\n" + GetType() + " - " + MethodBase.GetCurrentMethod().Name;

                return null;
            }
        }

        public ProductoEN ObtenerProducto(out string mensaje, Int64 id)
        {
            mensaje = "Error al obtener la cadena de conexión a la data.";

            try
            {
                ConexionBD objCon = new ConexionBD();

                using (SqlConnection cn = objCon.GetConexionBD())
                {
                    mensaje = "Error al abrir la conexión a la data.";

                    cn.Open();

                    mensaje = "Error al asignar la conexión a SqlCommand.";

                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = cn
                    };

                    ProductoDN productoDN = new ProductoDN();

                    return productoDN.ObtenerProducto(cn, cmd, out mensaje, id);
                }
            }
            catch (Exception ex)
            {
                mensaje += "\r\n\n" + ex.Message + "\r\n\n" + GetType() + " - " + MethodBase.GetCurrentMethod().Name;

                return null;
            }
        }

    }

}

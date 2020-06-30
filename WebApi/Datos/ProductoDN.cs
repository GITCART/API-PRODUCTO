using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using WebApi.Models;

namespace WebApi.Datos
{
    public class ProductoDN
    {

        public List<ProductoEN> ListarProductos(SqlConnection cn, SqlCommand cmd, out string mensaje)
        {
            mensaje = "";

            try
            {
                List<ProductoEN> tabla = new List<ProductoEN>();

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "p_listar_productos";

                mensaje = "Error al ejecutar el procedimiento p_listar_productos.";

                SqlDataReader dr = cmd.ExecuteReader();


                Int32 contador = 0;

                mensaje = "Error al asignar datos obtenidos del procedimiento p_listar_productos a la entidad.";

                while (dr.Read())
                {
                    ProductoEN productoEN = new ProductoEN
                    {
                        Id = dr.GetInt64(dr.GetOrdinal("pro_id")),

                        Codigo = dr.GetString(dr.GetOrdinal("pro_codigo")),

                        Descripcion = dr.GetString(dr.GetOrdinal("pro_descripcion")),

                        Precio = dr.GetDecimal(dr.GetOrdinal("pro_precio"))
                    };

                    tabla.Add(productoEN);

                    contador++;
                }

                mensaje = "";

                if (contador == 0)
                {
                    return null;
                }
                else
                {
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                mensaje += "\r\n\n" + ex.Message + "\r\n\n" + GetType() + " - " + MethodBase.GetCurrentMethod().Name;

                return null;
            }
        }

        public ProductoEN ObtenerProducto(SqlConnection cn, SqlCommand cmd, out string mensaje, Int64 id)
        {
            mensaje = "";

            try
            {
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "p_obtner_productos";

                cmd.Parameters.Add("@pro_id", SqlDbType.BigInt).Value = id;

                mensaje = "Error al ejecutar el procedimiento p_obtner_productos.";

                SqlDataReader dr = cmd.ExecuteReader();

                ProductoEN productoEN = new ProductoEN();

                Int32 contador = 0;

                mensaje = "Error al asignar datos obtenidos del procedimiento p_obtner_productos a la entidad.";

                while (dr.Read())
                {
                    productoEN.Id = dr.GetInt64(dr.GetOrdinal("pro_id"));

                    productoEN.Codigo = dr.GetString(dr.GetOrdinal("pro_codigo"));

                    productoEN.Descripcion = dr.GetString(dr.GetOrdinal("pro_descripcion"));

                    productoEN.Precio = dr.GetDecimal(dr.GetOrdinal("pro_precio"));

                    contador++;
                }

                mensaje = "";

                if (contador == 0)
                {
                    return null;
                }
                else
                {
                    return productoEN;
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

using Modelo.Entity;
using Modelo.Entitys;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Modelo
{
    public class vendedorBD : ConexionMsql
    {
        // Obtiene todos los productos disponibles
        public List<ProductoEntity> TraerProductos()
        {
            List<ProductoEntity> productos = new List<ProductoEntity>();

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "ObtenerProductos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ProductoEntity productoActual = new ProductoEntity
                            {
                                Id = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
                                Descripcion = dr.GetString(2),
                                Precio = dr.GetDouble(3),
                                Cantidad = dr.GetInt32(4),
                                Imagen = !dr.IsDBNull(5) ? (byte[])dr.GetValue(5) : null
                            };

                            productos.Add(productoActual);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al traer productos: {ex.Message}");
            }

            return productos;
        }

        // Busca un producto por su nombre
        public ProductoEntity BuscarProducto(string nombre)
        {
            ProductoEntity producto = null;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "BuscarProductos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_nombre", nombre);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto = new ProductoEntity
                            {
                                Id = reader.GetInt32("id"),
                                Nombre = reader.GetString("nombre"),
                                Precio = reader.GetDouble("precio"),
                                Cantidad = reader.GetInt32("cantidad"),
                                Descripcion = reader.GetString("descripcion")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
            }

            return producto;
        }

        // Vende un producto (actualiza la cantidad)
        public int venderProducto(ProductoEntity producto)
        {
            int resultado = 0;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "VenderProducto";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_nombre_producto", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@p_id_usuario", producto.Id);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al vender el producto: {ex.Message}");
            }

            return resultado;
        }
    }
}


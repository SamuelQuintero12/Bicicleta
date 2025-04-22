using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entity;
using MySql.Data.MySqlClient;


namespace Modelo
{
    public class AdminBD : ConexionMsql
    {
        private readonly ConexionMsql conexion = new();

        // Guarda un producto en la base de datos usando procedimiento almacenado
        public int GuardarProducto(ProductoEntity producto)
        {
            int resultado = 0;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "GuardarProducto";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@p_precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@p_cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@pr_id", producto.Id_provedor);
                    cmd.Parameters.AddWithValue("@p_imagen", producto.Imagen ?? (object)DBNull.Value);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al guardar producto: " + ex.Message);
            }

            return resultado;
        }

        // Elimina un producto por su nombre utilizando SP
        public int EliminarUsuario(ProductoEntity producto)
        {
            int eliminado = 0;

            try
            {
                using (MySqlCommand comando = GetConnection().CreateCommand())
                {
                    comando.CommandText = "EliminarProductoPorId";
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@producto_name", producto.Nombre);

                    eliminado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar usuario: " + ex.Message);
            }

            return eliminado;
        }

        // Edita la información de un producto usando SP
        public int EditarProducto(ProductoEntity producto)
        {
            int editado = 0;

            try
            {
                using (MySqlCommand comando = GetConnection().CreateCommand())
                {
                    comando.CommandText = "EditarProducto";
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@p_descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@p_precio", producto.Precio);
                    comando.Parameters.AddWithValue("@p_cantidad", producto.Cantidad);

                    editado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar el producto: " + ex.Message);
            }

            return editado;
        }
    }
}
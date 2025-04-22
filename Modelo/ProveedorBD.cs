using Modelo.Entitys;
using MySql.Data.MySqlClient;
using System;

namespace Modelo
{
    public class ProveedorBD : ConexionMsql
    {
        public int GuardarProveedor(ProveedorEntity proveedor)
        {
            int resultado = 0;
            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "GuardarProveedor";  // Procedimiento almacenado
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetros para el procedimiento
                    cmd.Parameters.AddWithValue("@p_nombre", proveedor.Nombre);
                    cmd.Parameters.AddWithValue("@p_empresa", proveedor.Empresa);
                    cmd.Parameters.AddWithValue("@p_contacto", proveedor.Contacto);

                    // Ejecutar el procedimiento almacenado
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar proveedor: {ex.Message}");
            }
            return resultado;
        }
    }
}

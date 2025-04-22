using System;
using System.Data;
using Modelo.Entitys;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class UsuarioBD
    {
        private readonly ConexionMsql db = new();

        // Busca un usuario por su email
        public usuarioEntyti BuscarUsuarioPorEmail(string email)
        {
            usuarioEntyti usuario = null;
            MySqlConnection conn = db.GetConnection();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("BuscarUsuarioPorEmail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new usuarioEntyti
                            {
                                usuario_id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                Email = reader["email"].ToString(),
                                Rol = reader["rol"].ToString(),
                                Contraseña = reader["contraseña"].ToString()
                            };
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al buscar usuario: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion(); // ← importante para liberar recursos
            }

            return usuario;
        }

        // Guarda un nuevo usuario
        public int GuardarUsuario(usuarioEntyti usuario)
        {
            int resultado = 0;
            MySqlConnection conn = db.GetConnection();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("RegistrarUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@p_email", usuario.Email);
                    cmd.Parameters.AddWithValue("@p_contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@p_rol", usuario.Rol);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar usuario: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion();
            }

            return resultado;
        }
    }
}

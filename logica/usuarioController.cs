using System;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo.Entitys;

namespace Modelo
{
    public class UsuarioBD
    {
        private readonly string connectionString = "Server=localhost;Database=tienda_db;User ID=root; Pwd=";
        public int GuardarUsuario(usuarioEntyti usuario)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("RegistrarUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("p_email", usuario.Email);
                        cmd.Parameters.AddWithValue("p_contraseña", usuario.Contraseña);
                        cmd.Parameters.AddWithValue("p_rol", usuario.Rol);

                        return cmd.ExecuteNonQuery(); // Devuelve 1 si todo va bien
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el usuario: " + ex.Message);
                return 0;
            }
        }

        public usuarioEntyti BuscarUsuarioPorEmail(string email)
        {
            usuarioEntyti usuario = null;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("BuscarUsuarioPorEmail", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_email", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuario = new usuarioEntyti
                                {
                                    usuario_id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["nombre"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Contraseña = reader["contraseña"].ToString(),
                                    Rol = reader["rol"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar usuario: " + ex.Message);
            }

            return usuario;
        }
    }
}


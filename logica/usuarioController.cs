using System;
using Modelo;
using Modelo.Entitys;
using BCrypt.Net;

namespace logica
{
    public class UsuarioController
    {
        private readonly UsuarioBD db = new UsuarioBD();

        // Registra un nuevo usuario en la base de datos
        public string RegistrarUsuario(string nombre, string email, string contraseña, string rol)
        {
            try
            {
                string contraseñaHasheada = BCrypt.Net.BCrypt.HashPassword(contraseña);

                usuarioEntyti nuevoUsuario = new usuarioEntyti
                {
                    Nombre = nombre,
                    Email = email,
                    Contraseña = contraseñaHasheada,
                    Rol = rol
                };

                int resultado = db.GuardarUsuario(nuevoUsuario);
                return resultado > 0
                    ? "Usuario registrado exitosamente."
                    : "Error al registrar el usuario.";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        // Inicia sesión verificando email y contraseña
        public usuarioEntyti Login(string correo, string contraseña)
        {
            usuarioEntyti usuario = db.BuscarUsuarioPorEmail(correo);

            if (usuario != null)
            {
                bool contraseñaValida = BCrypt.Net.BCrypt.Verify(contraseña, usuario.Contraseña);

                if (contraseñaValida)
                {
                    return usuario;
                }
                else
                {
                    Console.WriteLine("La contraseña no coincide.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró el usuario.");
            }

            return null;
        }
    }
}
using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ConexionMsql
    {
        private readonly string cadenaConexion;
        private readonly MySqlConnection connection;

        public ConexionMsql()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MySqlConexion"].ConnectionString;
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                    throw;
                }
            }
            return connection;
        }

        public void CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

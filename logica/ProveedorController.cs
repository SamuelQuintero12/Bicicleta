using Modelo;  // Para acceder a la capa de datos (ProveedorBD)
using Modelo.Entitys;  // Para acceder a las entidades (ProveedorEntity)

namespace logica
{
    public class ProveedorController
    {
        private ProveedorBD db = new ProveedorBD();

        public string GuardarProveedor(string nombre, string empresa, string contacto)
        {
            try
            {
                ProveedorEntity proveedor = new ProveedorEntity
                {
                    Nombre = nombre,
                    Empresa = empresa,
                    Contacto = contacto
                };

                int resultado = db.GuardarProveedor(proveedor);

                return resultado > 0 ? "Proveedor guardado con éxito." : "Error al guardar proveedor.";
            }
            catch (Exception ex)
            {
                return $"Error inesperado: {ex.Message}";
            }
        }
    }
}

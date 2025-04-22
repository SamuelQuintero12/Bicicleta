using System;
using Modelo;
using Modelo.Entity;

namespace logica
{
    public class AdminController
    {
        private readonly AdminBD db = new AdminBD();


        // Guarda un nuevo producto en la base de datos
        public string GuardarProducto(string nombre, string descripcion, string precio, string cantidad, string imagen, string id_provedor)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = Convert.ToDouble(precio),
                    Cantidad = Convert.ToInt32(cantidad),
                    Imagen = string.IsNullOrEmpty(imagen) ? null : Convert.FromBase64String(imagen),
                    Id_provedor = Convert.ToInt32(id_provedor)
                };

                int resultado = db.GuardarProducto(producto);
                return resultado > 0
                    ? "Producto guardado con éxito."
                    : "Error al guardar el producto.";
            }
            catch (FormatException)
            {
                return "Error: Verifica que el precio, cantidad e ID del proveedor sean valores numéricos válidos.";
            }
            catch (Exception ex)
            {
                return $"Error inesperado al guardar el producto: {ex.Message}";
            }
        }

        // Elimina un producto por su nombre
        public string EliminarProducto(string nombre)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity { Nombre = nombre };
                int resultado = db.EliminarUsuario(producto);

                return resultado > 0
                    ? "Producto eliminado con éxito."
                    : "No se encontró el producto o no se pudo eliminar.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el producto: {ex.Message}";
            }
        }

        // Edita los datos de un producto
        public string EditarProducto(string nombre, string descripcion, string precio, string cantidad)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = Convert.ToDouble(precio),
                    Cantidad = Convert.ToInt32(cantidad),
                };

                int resultado = db.EditarProducto(producto);

                return resultado > 0
                    ? "Producto editado con éxito."
                    : "Error al editar el producto.";
            }
            catch (FormatException)
            {
                return "Error: Asegúrate de ingresar números válidos para precio y cantidad.";
            }
            catch (Exception ex)
            {
                return $"Error inesperado al editar el producto: {ex.Message}";
            }
        }
    }
}

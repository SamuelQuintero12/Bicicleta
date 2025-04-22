using Modelo.Entity;
using Modelo;
using Modelo.Entitys;
using System;
using System.Collections.Generic;

public class VendedorController
{
    private readonly vendedorBD db = new vendedorBD();

    // Retorna la lista de productos disponibles
    public List<ProductoEntity> VerProductos()
    {
        return db.TraerProductos();
    }

    // Busca un producto por su nombre
    public ProductoEntity BuscarProducto(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            return null;

        return db.BuscarProducto(nombre);
    }

    // Registra la venta de un producto
    public int VentaProducto(string nombre, string cantidad, int usuario)
    {
        try
        {
            ProductoEntity producto = new ProductoEntity
            {
                Id = usuario,
                Nombre = nombre,
                Cantidad = Convert.ToInt32(cantidad)
            };

            return db.venderProducto(producto);
        }
        catch (FormatException)
        {
            Console.WriteLine("Cantidad inválida. Asegúrate de ingresar un número válido.");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al procesar la venta: {ex.Message}");
            return 0;
        }
    }

    public void VentaProducto(string text1, string text2, usuarioEntyti idUser)
    {
        throw new NotImplementedException();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modelo.Entity
{
    public class ProductoEntity
    {
       public int Id { get; set; }
       public string Nombre {  get; set; }
       public string Descripcion {  get; set; } 
        public double Precio {  get; set; } 
        public int Cantidad {  get; set; }
        public byte[] Imagen { get; set; } 
        public DateTime Fecha_agregado { get; set; }
        public int Id_provedor { get; set; }
    }
}

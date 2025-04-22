using System;
using System.Drawing;
using System.Windows.Forms;
using logica;

namespace Principal
{
    public partial class AgregarP : Form
    {
        private AdminController controller = new AdminController();

        public AgregarP()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbDescripcion.Text) ||
                string.IsNullOrWhiteSpace(tbPrecio.Text) ||
                string.IsNullOrWhiteSpace(tbCantidad.Text) ||
                string.IsNullOrWhiteSpace(tbProovedor.Text))
            {
                MostrarResultado("Por favor complete todos los campos.", Color.Red);
                return;
            }

            // Validar formato de datos numéricos
            if (!double.TryParse(tbPrecio.Text, out _) || !int.TryParse(tbCantidad.Text, out _) || !int.TryParse(tbProovedor.Text, out _))
            {
                MostrarResultado("Precio, cantidad e ID del proveedor deben ser valores numéricos válidos.", Color.Red);
                return;
            }

            // Validar formato base64 si hay imagen
            if (!string.IsNullOrWhiteSpace(tbImagen.Text))
            {
                try
                {
                    Convert.FromBase64String(tbImagen.Text);
                }
                catch
                {
                    MostrarResultado("La imagen debe estar en formato base64.", Color.Red);
                    return;
                }
            }

            // Intentar guardar el producto
            string resultado = controller.GuardarProducto(
                tbNombre.Text,
                tbDescripcion.Text,
                tbPrecio.Text,
                tbCantidad.Text,
                tbImagen.Text,
                tbProovedor.Text
            );

            if (resultado == "Producto guardado con éxito.")
            {
                MostrarResultado(resultado, Color.Green);
                this.Close();
            }
            else
            {
                MostrarResultado(resultado, Color.Red);
            }
        }

        private void MostrarResultado(string mensaje, Color color)
        {
            tbResultado.Text = mensaje;
            tbResultado.ForeColor = color;
        }

        // Puedes eliminar estos métodos vacíos si no los necesitas
        private void label1_Click(object sender, EventArgs e) { }

        private void tbNombre_TextChanged(object sender, EventArgs e) { }

        private void tbPrecio_TextChanged(object sender, EventArgs e) { }
    }
}

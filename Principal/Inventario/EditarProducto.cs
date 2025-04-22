using System;
using System.Drawing;
using System.Windows.Forms;
using logica;

namespace Principal
{
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }

        private AdminController controller = new AdminController();

        private void btEditarP_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbDescripcion.Text) ||
                string.IsNullOrEmpty(tbPrecio.Text) || string.IsNullOrEmpty(tbCantidad.Text))
            {
                Resultado1.Text = "Por favor complete todos los campos.";
                Resultado1.ForeColor = Color.Red;
                return;
            }

            // Llamar al método del controlador para editar el producto
            string resultado = controller.EditarProducto(
                tbNombre.Text,
                tbDescripcion.Text,
                tbPrecio.Text,
                tbCantidad.Text
            );

            // Mostrar el resultado en el Label correspondiente
            Resultado1.Text = resultado;

            // Cambiar color según el resultado
            if (resultado == "Producto editado con éxito.")
            {
                Resultado1.ForeColor = Color.Green;
            }
            else
            {
                Resultado1.ForeColor = Color.Red;
            }
        }
    }
}

using Modelo.Entitys;

namespace Principal.Ventas
{
    public partial class venderProducto : Form
    {
        private usuarioEntyti idUser;
        public venderProducto(usuarioEntyti usuario)
        {
            InitializeComponent();
            idUser = usuario;
        }

        private VendedorController controller = new VendedorController();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                controller.VentaProducto(
                TbNombre_P.Text,
                TbCantidad_P.Text,
                idUser
                );
                MessageBox.Show("producto vendido");

                FormularioUtils.LimpiarControles(this);
            }
            catch (FormatException)
            {
                LbResult.Text = "error al buscar este producto";
            }
        }
    }
}

using Modelo;
using Modelo.Entitys;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Principal.Ventas;

namespace Principal
{
    public partial class Menu : Form
    {
        private usuarioEntyti usuarioActual;

        public Menu(usuarioEntyti usuario)
        {
            InitializeComponent();
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            InventarioP inventario = new InventarioP();
            inventario.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            Venta_p ventas = new Venta_p();
            ventas.Show();

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido: ";
            lblRol.Text = "Rol: ";

            // Ocultar o mostrar botones según el rol
            if (usuarioActual.Rol == "vendedor")
            {
                // Por ejemplo, ocultar botón de inventario
                inventario.Enabled = false;
            }
            else if (usuarioActual.Rol == "administrador")
            {
                // Mostrar todo si es administrador
                ventas.Enabled = false;
                inventario.Visible = true;
            }
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}

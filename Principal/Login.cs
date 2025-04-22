using logica;
using Modelo.Entitys;
using Principal.Usuario;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Principal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private UsuarioController controlador = new UsuarioController();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = tbUsuario.Text;
            string contraseña = tbContraseña.Text;



            usuarioEntyti usuario = controlador.Login(correo, contraseña);

            if (usuario != null)
            {
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


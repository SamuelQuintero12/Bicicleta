using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace Principal.Usuario
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController(); 

            try
            {
                string nombre = TbNombre.Text;
                string email = TbEmail.Text;
                string contraseña = TbPassword.Text;
                string rol =  TbRol.Text; // ComboBox de roles

                string resultado = controller.RegistrarUsuario(nombre, email, contraseña, rol);

                this.Hide();
                login login = new login();
                login.FormClosed += (s, args) => Application.Exit();
                login.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Editar el producto: " + ex.Message);
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using logica;

namespace Principal.Inventario
{
    public partial class AgregarProve : Form
    {
        private ProveedorController controller = new ProveedorController();

        // Controles del formulario
        private TextBox tbNombre;
        private TextBox tbEmpresa;
        private TextBox tbContacto;
        private Label lblResultado;
        private Button button1;

        public AgregarProve()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            tbEmpresa = new TextBox();
            tbContacto = new TextBox();
            lblResultado = new Label();
            button1 = new Button();

            SuspendLayout();

            // tbNombre
            tbNombre.Location = new Point(50, 40);
            tbNombre.Size = new Size(300, 25);
            tbNombre.PlaceholderText = "Nombre del Proveedor";

            // tbEmpresa
            tbEmpresa.Location = new Point(50, 80);
            tbEmpresa.Size = new Size(300, 25);
            tbEmpresa.PlaceholderText = "Empresa";

            // tbContacto
            tbContacto.Location = new Point(50, 120);
            tbContacto.Size = new Size(300, 25);
            tbContacto.PlaceholderText = "Contacto (teléfono o email)";

            // lblResultado
            lblResultado.Location = new Point(50, 160);
            lblResultado.Size = new Size(400, 25);
            lblResultado.ForeColor = Color.Red;
            lblResultado.TextAlign = ContentAlignment.MiddleLeft;

            // button1 (Agregar)
            button1.Location = new Point(200, 200);
            button1.Size = new Size(150, 40);
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // AgregarProve Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 280);
            Controls.Add(tbNombre);
            Controls.Add(tbEmpresa);
            Controls.Add(tbContacto);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Name = "AgregarProve";
            Text = "Agregar Proveedor";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbEmpresa.Text) ||
                string.IsNullOrWhiteSpace(tbContacto.Text))
            {
                MostrarMensaje("Por favor complete todos los campos.", Color.Red);
                return;
            }

            // Lógica para guardar el proveedor
            string resultado = controller.GuardarProveedor(
                tbNombre.Text.Trim(),
                tbEmpresa.Text.Trim(),
                tbContacto.Text.Trim()
            );

            // Resultado visual
            if (resultado == "Proveedor guardado con éxito.")
            {
                MostrarMensaje(resultado, Color.Green);
                this.Close(); // Cierra solo si tuvo éxito
            }
            else
            {
                MostrarMensaje(resultado, Color.Red);
            }
        }

        private void MostrarMensaje(string mensaje, Color color)
        {
            lblResultado.Text = mensaje;
            lblResultado.ForeColor = color;
        }
    }
}

using logica;
using Modelo;
using Modelo.Entity;
using Modelo.Entitys;
using Principal.Inventario;

namespace Principal
{
    public partial class InventarioP : Form
    {
        public InventarioP()
        {
            InitializeComponent();
        }
        private void BtAgregarProve_Click(object sender, EventArgs e)
        {
            AgregarProve agregarProve = new();
            agregarProve.ShowDialog();
        }

        private usuarioEntyti sesion = new usuarioEntyti();

        private void BtBusqueda_Click(object sender, EventArgs e)
        {
            vendedorBD db = new vendedorBD();
            VendedorController controller = new VendedorController();
            ProductoEntity producto = db.BuscarProducto(TbBusqueda.Text);

            if (producto != null)
            {
                lbResult.Text = $"producto Nombre: {producto.Nombre}, Precio: {producto.Precio}, cantidad: {producto.Cantidad}";
            }
            else
            {
                lbResult.Text = "No se encontró el producto.";
            }
        }

        private void BtAgregarP_Click(object sender, EventArgs e)
        {
            AgregarP agregarP = new();
            agregarP.ShowDialog();
        }

        private void BtEditarP_Click(object sender, EventArgs e)
        {
            EditarProducto editar = new();
            editar.ShowDialog();
        }

        private void BtEliminarP_Click(object sender, EventArgs e)
        {
            EliminarP eliminarP = new();
            eliminarP.ShowDialog();
        }

        private void BtTraerProducto_Click(object sender, EventArgs e)
        {
            VendedorController us = new();
            var productos = us.VerProductos();


            PanelContainer.Controls.Clear();

            int yOffset = 10;

            foreach (var producto in productos)
            {
                Label lblProducto = new();
                lblProducto.Text = $"{producto.Nombre}\n {producto.Descripcion}\n {producto.Cantidad}";
                lblProducto.AutoSize = true;
                lblProducto.Location = new Point(10, yOffset);

                PanelContainer.Controls.Add(lblProducto);

                yOffset += 50;
            }
        }

        

        private void TbBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

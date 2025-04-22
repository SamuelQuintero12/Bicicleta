namespace Principal
{
    partial class EditarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btEditarP = new Button();
            label1 = new Label();
            tbNombre = new TextBox();
            tbCantidad = new TextBox();
            tbPrecio = new TextBox();
            tbDescripcion = new TextBox();
            Resultado1 = new Label();
            SuspendLayout();
            // 
            // btEditarP
            // 
            btEditarP.Location = new Point(283, 251);
            btEditarP.Name = "btEditarP";
            btEditarP.Size = new Size(131, 61);
            btEditarP.TabIndex = 40;
            btEditarP.Text = "EDITAR PRODUCTO";
            btEditarP.UseVisualStyleBackColor = true;
            btEditarP.Click += btEditarP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 24);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 39;
            label1.Text = "EDITAR LOS PRODUCTOS";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(214, 83);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "NOMBRE";
            tbNombre.Size = new Size(278, 23);
            tbNombre.TabIndex = 38;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(214, 209);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.PlaceholderText = "CANTIDAD";
            tbCantidad.Size = new Size(278, 23);
            tbCantidad.TabIndex = 33;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(214, 168);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.PlaceholderText = "PRECIO";
            tbPrecio.Size = new Size(278, 23);
            tbPrecio.TabIndex = 32;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(214, 127);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "DESCRIPCION";
            tbDescripcion.Size = new Size(278, 23);
            tbDescripcion.TabIndex = 31;
            // 
            // Resultado1
            // 
            Resultado1.AutoSize = true;
            Resultado1.Location = new Point(395, 109);
            Resultado1.Name = "Resultado1";
            Resultado1.Size = new Size(0, 15);
            Resultado1.TabIndex = 41;
            // 
            // EditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 357);
            Controls.Add(Resultado1);
            Controls.Add(btEditarP);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Controls.Add(tbCantidad);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Name = "EditarProducto";
            Text = "EditarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditarP;
        private Label label1;
        private TextBox tbNombre;
        private TextBox tbCantidad;
        private TextBox tbPrecio;
        private TextBox tbDescripcion;
        private Label Resultado1;
    }
}
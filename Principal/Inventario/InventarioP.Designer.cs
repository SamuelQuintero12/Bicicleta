namespace Principal
{
    partial class InventarioP
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
        private void InitializeComponent()
        {
            BtTraerProducto = new Button();
            BtEditarP = new Button();
            TbBusqueda = new TextBox();
            BtBusqueda = new Button();
            BtAgregarProve = new Button();
            BtEliminarP = new Button();
            BtAgregarP = new Button();
            lbResult = new Label();
            PanelContainer = new Panel();
            SuspendLayout();
            // 
            // BtTraerProducto
            // 
            BtTraerProducto.Location = new Point(451, 46);
            BtTraerProducto.Name = "BtTraerProducto";
            BtTraerProducto.Size = new Size(131, 38);
            BtTraerProducto.TabIndex = 0;
            BtTraerProducto.Text = "INVENTARIO DE PRODUCTOS";
            BtTraerProducto.UseVisualStyleBackColor = true;
            BtTraerProducto.Click += BtTraerProducto_Click;
            // 
            // BtEditarP
            // 
            BtEditarP.Location = new Point(151, 40);
            BtEditarP.Name = "BtEditarP";
            BtEditarP.Size = new Size(107, 50);
            BtEditarP.TabIndex = 2;
            BtEditarP.Text = "EDITAR PRODUCTO";
            BtEditarP.UseVisualStyleBackColor = true;
            BtEditarP.Click += BtEditarP_Click;
            // 
            // TbBusqueda
            // 
            TbBusqueda.Location = new Point(567, 128);
            TbBusqueda.Name = "TbBusqueda";
            TbBusqueda.PlaceholderText = "BUSQUEDA DE LOS  PRODUCTOS";
            TbBusqueda.Size = new Size(221, 23);
            TbBusqueda.TabIndex = 4;
            TbBusqueda.TextChanged += TbBusqueda_TextChanged;
            // 
            // BtBusqueda
            // 
            BtBusqueda.Location = new Point(644, 178);
            BtBusqueda.Name = "BtBusqueda";
            BtBusqueda.Size = new Size(89, 36);
            BtBusqueda.TabIndex = 5;
            BtBusqueda.Text = "BUSCAR";
            BtBusqueda.UseVisualStyleBackColor = true;
            BtBusqueda.Click += BtBusqueda_Click;
            // 
            // BtAgregarProve
            // 
            BtAgregarProve.Location = new Point(21, 358);
            BtAgregarProve.Name = "BtAgregarProve";
            BtAgregarProve.Size = new Size(131, 35);
            BtAgregarProve.TabIndex = 7;
            BtAgregarProve.Text = "agregar proveedores";
            BtAgregarProve.UseVisualStyleBackColor = true;
            BtAgregarProve.Click += BtAgregarProve_Click;
            // 
            // BtEliminarP
            // 
            BtEliminarP.Location = new Point(283, 40);
            BtEliminarP.Name = "BtEliminarP";
            BtEliminarP.Size = new Size(131, 50);
            BtEliminarP.TabIndex = 8;
            BtEliminarP.Text = "ELIMINAR PRODUCTOS";
            BtEliminarP.UseVisualStyleBackColor = true;
            BtEliminarP.Click += BtEliminarP_Click;
            // 
            // BtAgregarP
            // 
            BtAgregarP.Location = new Point(21, 40);
            BtAgregarP.Name = "BtAgregarP";
            BtAgregarP.Size = new Size(105, 50);
            BtAgregarP.TabIndex = 9;
            BtAgregarP.Text = "AGREGAR PRODUCTO";
            BtAgregarP.UseVisualStyleBackColor = true;
            BtAgregarP.Click += BtAgregarP_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(39, 84);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(0, 15);
            lbResult.TabIndex = 1;
            // 
            // PanelContainer
            // 
            PanelContainer.AutoScroll = true;
            PanelContainer.BackColor = Color.White;
            PanelContainer.Location = new Point(21, 117);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(422, 217);
            PanelContainer.TabIndex = 6;
            // 
            // InventarioP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TbBusqueda);
            Controls.Add(BtAgregarP);
            Controls.Add(BtEliminarP);
            Controls.Add(BtAgregarProve);
            Controls.Add(BtBusqueda);
            Controls.Add(BtEditarP);
            Controls.Add(lbResult);
            Controls.Add(BtTraerProducto);
            Controls.Add(PanelContainer);
            Name = "InventarioP";
            Text = "Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtTraerProducto;
        private Button BtEditarP;
        private TextBox TbBusqueda;
        private Button BtBusqueda;
        private Button BtAgregarProve;
        private Button BtEliminarP;
        private Button BtAgregarP;
        private Label lbResult;
        private Panel PanelContainer;
    }
}
namespace Principal.Ventas
{
    partial class Venta_p
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
            BtVende_P = new Button();
            lbResult = new Label();
            PanelContainer = new Panel();
            BtTraerProducto = new Button();
            BtBusqueda = new Button();
            TbBusqueda = new TextBox();
            SuspendLayout();
            // 
            // BtVende_P
            // 
            BtVende_P.Location = new Point(33, 228);
            BtVende_P.Name = "BtVende_P";
            BtVende_P.Size = new Size(131, 38);
            BtVende_P.TabIndex = 17;
            BtVende_P.Text = "vender roducto";
            BtVende_P.UseVisualStyleBackColor = true;
            BtVende_P.Click += BtVende_P_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(56, 86);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(14, 15);
            lbResult.TabIndex = 16;
            lbResult.Text = "p";
            // 
            // PanelContainer
            // 
            PanelContainer.AutoScroll = true;
            PanelContainer.BackColor = Color.White;
            PanelContainer.Location = new Point(268, 133);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(499, 279);
            PanelContainer.TabIndex = 15;
            // 
            // BtTraerProducto
            // 
            BtTraerProducto.Location = new Point(33, 153);
            BtTraerProducto.Name = "BtTraerProducto";
            BtTraerProducto.Size = new Size(131, 38);
            BtTraerProducto.TabIndex = 14;
            BtTraerProducto.Text = "inventario de  productos ";
            BtTraerProducto.UseVisualStyleBackColor = true;
            BtTraerProducto.Click += BtTraerProducto_Click;
            // 
            // BtBusqueda
            // 
            BtBusqueda.Location = new Point(485, 39);
            BtBusqueda.Name = "BtBusqueda";
            BtBusqueda.Size = new Size(89, 36);
            BtBusqueda.TabIndex = 13;
            BtBusqueda.Text = "busqueda";
            BtBusqueda.UseVisualStyleBackColor = true;
            BtBusqueda.Click += BtBusqueda_Click;
            // 
            // TbBusqueda
            // 
            TbBusqueda.Location = new Point(59, 39);
            TbBusqueda.Name = "TbBusqueda";
            TbBusqueda.PlaceholderText = "Busqueda productos";
            TbBusqueda.Size = new Size(383, 23);
            TbBusqueda.TabIndex = 12;
            // 
            // Venta_p
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtVende_P);
            Controls.Add(lbResult);
            Controls.Add(PanelContainer);
            Controls.Add(BtTraerProducto);
            Controls.Add(BtBusqueda);
            Controls.Add(TbBusqueda);
            Name = "Venta_p";
            Text = "Venta_p";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtVende_P;
        private Label lbResult;
        private Panel PanelContainer;
        private Button BtTraerProducto;
        private Button BtBusqueda;
        private TextBox TbBusqueda;
    }
}
namespace Principal.Ventas
{
    partial class venderProducto
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
            button1 = new Button();
            TbNombre_P = new TextBox();
            TbCantidad_P = new TextBox();
            TbUsuario = new TextBox();
            LbResult = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(56, 295);
            button1.Name = "button1";
            button1.Size = new Size(118, 40);
            button1.TabIndex = 0;
            button1.Text = "vender producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TbNombre_P
            // 
            TbNombre_P.Location = new Point(56, 94);
            TbNombre_P.Name = "TbNombre_P";
            TbNombre_P.PlaceholderText = "nombre producto";
            TbNombre_P.Size = new Size(131, 23);
            TbNombre_P.TabIndex = 1;
            // 
            // TbCantidad_P
            // 
            TbCantidad_P.Location = new Point(56, 140);
            TbCantidad_P.Name = "TbCantidad_P";
            TbCantidad_P.PlaceholderText = "cantidad producto";
            TbCantidad_P.Size = new Size(131, 23);
            TbCantidad_P.TabIndex = 2;
            // 
            // TbUsuario
            // 
            TbUsuario.Location = new Point(56, 206);
            TbUsuario.Name = "TbUsuario";
            TbUsuario.PlaceholderText = "usuario";
            TbUsuario.Size = new Size(100, 23);
            TbUsuario.TabIndex = 3;
            // 
            // LbResult
            // 
            LbResult.AutoSize = true;
            LbResult.Location = new Point(460, 136);
            LbResult.Name = "LbResult";
            LbResult.Size = new Size(10, 15);
            LbResult.TabIndex = 4;
            LbResult.Text = "l";
            // 
            // venderProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LbResult);
            Controls.Add(TbUsuario);
            Controls.Add(TbCantidad_P);
            Controls.Add(TbNombre_P);
            Controls.Add(button1);
            Name = "venderProducto";
            Text = "venderProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TbNombre_P;
        private TextBox TbCantidad_P;
        private TextBox TbUsuario;
        private Label LbResult;
    }
}
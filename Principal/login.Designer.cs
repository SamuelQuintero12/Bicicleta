namespace Principal
{
    partial class login
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
            btnIniciarSesion = new Button();
            tbUsuario = new TextBox();
            tbContraseña = new TextBox();
            btRegistro = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(319, 221);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(159, 40);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "INGRESAR";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(255, 109);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PlaceholderText = "usuario";
            tbUsuario.Size = new Size(293, 23);
            tbUsuario.TabIndex = 1;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(255, 156);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "contraseña";
            tbContraseña.Size = new Size(293, 23);
            tbContraseña.TabIndex = 2;
            // 
            // btRegistro
            // 
            btRegistro.Location = new Point(319, 285);
            btRegistro.Name = "btRegistro";
            btRegistro.Size = new Size(159, 40);
            btRegistro.TabIndex = 3;
            btRegistro.Text = "REGISTRAR";
            btRegistro.UseVisualStyleBackColor = true;
            btRegistro.Click += btRegistro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 45);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 4;
            label1.Text = "Tienda de Bicicletas";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btRegistro);
            Controls.Add(tbContraseña);
            Controls.Add(tbUsuario);
            Controls.Add(btnIniciarSesion);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private TextBox tbUsuario;
        private TextBox tbContraseña;
        private Button btRegistro;
        private Label label1;
    }
}
namespace Principal.Usuario
{
    partial class Registro
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
            TbNombre = new TextBox();
            TbEmail = new TextBox();
            TbPassword = new TextBox();
            TbRol = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(31, 365);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(123, 42);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "inicar secion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(31, 152);
            TbNombre.Name = "TbNombre";
            TbNombre.PlaceholderText = "nombre";
            TbNombre.Size = new Size(248, 23);
            TbNombre.TabIndex = 2;
            // 
            // TbEmail
            // 
            TbEmail.Location = new Point(31, 203);
            TbEmail.Name = "TbEmail";
            TbEmail.PlaceholderText = "email";
            TbEmail.Size = new Size(248, 23);
            TbEmail.TabIndex = 3;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(31, 254);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = "contraseña";
            TbPassword.Size = new Size(248, 23);
            TbPassword.TabIndex = 4;
            // 
            // TbRol
            // 
            TbRol.Location = new Point(31, 296);
            TbRol.Name = "TbRol";
            TbRol.PlaceholderText = "Rol";
            TbRol.Size = new Size(248, 23);
            TbRol.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 71);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 6;
            label1.Text = "TiendaBc";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TbRol);
            Controls.Add(TbPassword);
            Controls.Add(TbEmail);
            Controls.Add(TbNombre);
            Controls.Add(btnIniciarSesion);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private TextBox TbNombre;
        private TextBox TbEmail;
        private TextBox TbPassword;
        private TextBox TbRol;
        private Label label1;
    }
}
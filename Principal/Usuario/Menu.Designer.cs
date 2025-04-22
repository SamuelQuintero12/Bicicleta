namespace Principal
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inventario = new Button();
            ventas = new Button();
            label1 = new Label();
            lbUsuario = new Label();
            btLogin = new Button();
            lblBienvenida = new Label();
            lblRol = new Label();
            SuspendLayout();
            // 
            // inventario
            // 
            inventario.Location = new Point(30, 225);
            inventario.Name = "inventario";
            inventario.Size = new Size(175, 52);
            inventario.TabIndex = 1;
            inventario.Text = "inventario";
            inventario.UseVisualStyleBackColor = true;
            inventario.Click += inventario_Click;
            // 
            // ventas
            // 
            ventas.Location = new Point(30, 304);
            ventas.Name = "ventas";
            ventas.Size = new Size(175, 52);
            ventas.TabIndex = 2;
            ventas.Text = "Ventas";
            ventas.UseVisualStyleBackColor = true;
            ventas.Click += ventas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 4;
            label1.Text = "Tienda";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(115, 87);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(0, 15);
            lbUsuario.TabIndex = 5;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(632, 164);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(75, 23);
            btLogin.TabIndex = 6;
            btLogin.Text = "button1";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(71, 82);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(38, 15);
            lblBienvenida.TabIndex = 7;
            lblBienvenida.Text = "label2";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(71, 121);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(38, 15);
            lblRol.TabIndex = 8;
            lblRol.Text = "label2";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRol);
            Controls.Add(lblBienvenida);
            Controls.Add(btLogin);
            Controls.Add(lbUsuario);
            Controls.Add(label1);
            Controls.Add(ventas);
            Controls.Add(inventario);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button inventario;
        private Button ventas;
        private Label label1;
        private Label lbUsuario;
        private Button btLogin;
        private Label lblBienvenida;
        private Label lblRol;
    }
}

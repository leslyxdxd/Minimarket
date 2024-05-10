namespace Minimarket_GUI
{
    partial class frmInsertarUsuario
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
            txtPassword = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnGrabar = new Button();
            label2 = new Label();
            otpGerenteTienda = new RadioButton();
            otpGerenteAlmacen = new RadioButton();
            panel1 = new Panel();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F);
            txtPassword.Location = new Point(130, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(118, 25);
            txtPassword.TabIndex = 9;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(38, 78);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 8;
            label4.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(130, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(115, 25);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(52, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.SeaShell;
            btnGrabar.Font = new Font("Segoe UI", 9.75F);
            btnGrabar.Location = new Point(38, 212);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(112, 31);
            btnGrabar.TabIndex = 22;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(25, 139);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 11;
            label2.Text = "Nivel de Usuario";
            // 
            // otpGerenteTienda
            // 
            otpGerenteTienda.AutoSize = true;
            otpGerenteTienda.Font = new Font("Segoe UI", 9.75F);
            otpGerenteTienda.Location = new Point(130, 156);
            otpGerenteTienda.Name = "otpGerenteTienda";
            otpGerenteTienda.Size = new Size(131, 21);
            otpGerenteTienda.TabIndex = 25;
            otpGerenteTienda.TabStop = true;
            otpGerenteTienda.Text = "Gerente de tienda";
            otpGerenteTienda.UseVisualStyleBackColor = true;
            // 
            // otpGerenteAlmacen
            // 
            otpGerenteAlmacen.AutoSize = true;
            otpGerenteAlmacen.Font = new Font("Segoe UI", 9.75F);
            otpGerenteAlmacen.Location = new Point(130, 120);
            otpGerenteAlmacen.Name = "otpGerenteAlmacen";
            otpGerenteAlmacen.Size = new Size(147, 21);
            otpGerenteAlmacen.TabIndex = 25;
            otpGerenteAlmacen.TabStop = true;
            otpGerenteAlmacen.Text = "Gerente de almacen ";
            otpGerenteAlmacen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.usuario;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(319, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 186);
            panel1.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLightLight;
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Location = new Point(171, 212);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 31);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmInsertarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 269);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(otpGerenteAlmacen);
            Controls.Add(otpGerenteTienda);
            Controls.Add(label2);
            Controls.Add(btnGrabar);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInsertarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertarUsuario";
            Load += frmInsertarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label4;
        private TextBox txtNombre;
        private Label label1;
        private Button btnGrabar;
        private Label label2;
        private RadioButton otpGerenteTienda;
        private RadioButton otpGerenteAlmacen;
        private Panel panel1;
        private Button btnCancelar;
    }
}
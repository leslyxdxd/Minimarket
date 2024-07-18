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
            label2 = new Label();
            otpGerenteTienda = new RadioButton();
            otpGerenteAlmacen = new RadioButton();
            panel1 = new Panel();
            button1 = new Button();
            btnInhabilitar = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F);
            txtPassword.Location = new Point(151, 75);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(152, 25);
            txtPassword.TabIndex = 9;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(59, 78);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 8;
            label4.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(151, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 25);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(80, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 6;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(28, 143);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 11;
            label2.Text = "Nivel de Usuario:";
            // 
            // otpGerenteTienda
            // 
            otpGerenteTienda.AutoSize = true;
            otpGerenteTienda.Font = new Font("Segoe UI", 9.75F);
            otpGerenteTienda.Location = new Point(151, 163);
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
            otpGerenteAlmacen.Location = new Point(151, 121);
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
            panel1.Location = new Point(325, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 168);
            panel1.TabIndex = 26;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(38, 210);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(123, 37);
            button1.TabIndex = 62;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInhabilitar.BackColor = Color.Firebrick;
            btnInhabilitar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Location = new Point(176, 210);
            btnInhabilitar.Margin = new Padding(4, 3, 4, 3);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(127, 37);
            btnInhabilitar.TabIndex = 63;
            btnInhabilitar.Text = "Cancelar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // frmInsertarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 269);
            Controls.Add(btnInhabilitar);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(otpGerenteAlmacen);
            Controls.Add(otpGerenteTienda);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInsertarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Nuevo Usuario";
            Load += frmInsertarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label4;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private RadioButton otpGerenteTienda;
        private RadioButton otpGerenteAlmacen;
        private Panel panel1;
        private Button button1;
        private Button btnInhabilitar;
    }
}
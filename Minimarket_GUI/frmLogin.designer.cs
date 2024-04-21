namespace GesUni_GUI
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label1 = new Label();
            txtLogin = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(86, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 182);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 271);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 0;
            label1.Text = "USUARIO:";
            // 
            // txtLogin
            // 
            txtLogin.CharacterCasing = CharacterCasing.Upper;
            txtLogin.Location = new Point(117, 269);
            txtLogin.Margin = new Padding(4, 3, 4, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(116, 22);
            txtLogin.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 328);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 0;
            label2.Text = "CONTRASEÑA:";
            // 
            // txtPassword
            // 
            txtPassword.CharacterCasing = CharacterCasing.Upper;
            txtPassword.Location = new Point(117, 323);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(116, 22);
            txtPassword.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.White;
            btnAceptar.Location = new Point(255, 265);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 30);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(255, 319);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(112, 223);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 11;
            label3.Text = "BIENVENIDO ";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(366, 377);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Font = new Font("Arial", 9.75F);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingrese su usuario y contraseña";
            FormClosed += frmLogin_FormClosed;
            KeyDown += frmLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private Label label2;
        private TextBox txtPassword;
        private Button btnAceptar;
        private Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label3;
    }
}
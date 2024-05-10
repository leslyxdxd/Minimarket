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
            txtNivel = new TextBox();
            label2 = new Label();
            btnGrabar = new Button();
            label3 = new Label();
            txtEstado = new TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(118, 23);
            txtPassword.TabIndex = 9;
            txtPassword.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 100);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(115, 23);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 60);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(127, 141);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(118, 23);
            txtNivel.TabIndex = 10;
            txtNivel.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 11;
            label2.Text = "Nivel de Usuario";
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = SystemColors.ControlLightLight;
            btnGrabar.Location = new Point(101, 241);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 22;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 199);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 23;
            label3.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(127, 191);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(118, 23);
            txtEstado.TabIndex = 24;
            txtEstado.TextAlign = HorizontalAlignment.Right;
            // 
            // frmInsertarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 297);
            Controls.Add(txtEstado);
            Controls.Add(label3);
            Controls.Add(btnGrabar);
            Controls.Add(label2);
            Controls.Add(txtNivel);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInsertarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label4;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtNivel;
        private Label label2;
        private Button btnGrabar;
        private Label label3;
        private TextBox txtEstado;
    }
}
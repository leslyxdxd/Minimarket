
namespace ProyVentas_GUI
{
    partial class frmListaUsuario
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
            dtgUsuario = new DataGridView();
            Login_Usuario = new DataGridViewTextBoxColumn();
            Pass_usuario = new DataGridViewTextBoxColumn();
            Niv_Usuario = new DataGridViewTextBoxColumn();
            Credenciales = new DataGridViewTextBoxColumn();
            Est_Usuario = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fec_Registro = new DataGridViewTextBoxColumn();
            Usu_Registro = new DataGridViewTextBoxColumn();
            Fec_Ult_Mod = new DataGridViewTextBoxColumn();
            Usu_Ult_Mod = new DataGridViewTextBoxColumn();
            lblRegistros = new Label();
            label2 = new Label();
            btnSalir = new Button();
            txtFiltro = new TextBox();
            label1 = new Label();
            btnInhabilitar = new Button();
            button1 = new Button();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgUsuario).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuario
            // 
            dtgUsuario.AllowUserToAddRows = false;
            dtgUsuario.AllowUserToDeleteRows = false;
            dtgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuario.Columns.AddRange(new DataGridViewColumn[] { Login_Usuario, Pass_usuario, Niv_Usuario, Credenciales, Est_Usuario, Estado, Fec_Registro, Usu_Registro, Fec_Ult_Mod, Usu_Ult_Mod });
            dtgUsuario.Location = new Point(14, 74);
            dtgUsuario.Margin = new Padding(4, 3, 4, 3);
            dtgUsuario.Name = "dtgUsuario";
            dtgUsuario.ReadOnly = true;
            dtgUsuario.RowHeadersVisible = false;
            dtgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuario.Size = new Size(702, 306);
            dtgUsuario.TabIndex = 0;
            dtgUsuario.DoubleClick += dtgCategoria_DoubleClick;
            // 
            // Login_Usuario
            // 
            Login_Usuario.DataPropertyName = "Login_Usuario";
            Login_Usuario.HeaderText = "Usuario";
            Login_Usuario.Name = "Login_Usuario";
            Login_Usuario.ReadOnly = true;
            // 
            // Pass_usuario
            // 
            Pass_usuario.DataPropertyName = "Pass_usuario";
            Pass_usuario.HeaderText = "Password";
            Pass_usuario.Name = "Pass_usuario";
            Pass_usuario.ReadOnly = true;
            Pass_usuario.Visible = false;
            // 
            // Niv_Usuario
            // 
            Niv_Usuario.DataPropertyName = "Niv_Usuario";
            Niv_Usuario.HeaderText = "Niv_Usuario";
            Niv_Usuario.Name = "Niv_Usuario";
            Niv_Usuario.ReadOnly = true;
            Niv_Usuario.Visible = false;
            // 
            // Credenciales
            // 
            Credenciales.DataPropertyName = "Credenciales";
            Credenciales.HeaderText = "Credenciales";
            Credenciales.Name = "Credenciales";
            Credenciales.ReadOnly = true;
            // 
            // Est_Usuario
            // 
            Est_Usuario.DataPropertyName = "Est_Usuario";
            Est_Usuario.HeaderText = "Est_Usuario";
            Est_Usuario.Name = "Est_Usuario";
            Est_Usuario.ReadOnly = true;
            Est_Usuario.Visible = false;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Fec_Registro
            // 
            Fec_Registro.DataPropertyName = "Fec_Registro";
            Fec_Registro.HeaderText = "Fecha de registro";
            Fec_Registro.Name = "Fec_Registro";
            Fec_Registro.ReadOnly = true;
            // 
            // Usu_Registro
            // 
            Usu_Registro.DataPropertyName = "Usu_Registro";
            Usu_Registro.HeaderText = "Auditoria registro";
            Usu_Registro.Name = "Usu_Registro";
            Usu_Registro.ReadOnly = true;
            Usu_Registro.Visible = false;
            // 
            // Fec_Ult_Mod
            // 
            Fec_Ult_Mod.DataPropertyName = "Fec_Ult_Mod";
            Fec_Ult_Mod.HeaderText = "Fecha de modificación";
            Fec_Ult_Mod.Name = "Fec_Ult_Mod";
            Fec_Ult_Mod.ReadOnly = true;
            Fec_Ult_Mod.Visible = false;
            // 
            // Usu_Ult_Mod
            // 
            Usu_Ult_Mod.DataPropertyName = "Usu_Ult_Mod";
            Usu_Ult_Mod.HeaderText = "Ultima modificacion";
            Usu_Ult_Mod.Name = "Usu_Ult_Mod";
            Usu_Ult_Mod.ReadOnly = true;
            Usu_Ult_Mod.Visible = false;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Segoe UI", 9.75F);
            lblRegistros.Location = new Point(90, 419);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(92, 25);
            lblRegistros.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(16, 420);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 12;
            label2.Text = "Registros:";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Font = new Font("Segoe UI", 9.75F);
            btnSalir.Location = new Point(614, 409);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 38);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Font = new Font("Segoe UI", 9.75F);
            txtFiltro.Location = new Point(122, 28);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(196, 25);
            txtFiltro.TabIndex = 14;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(14, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 13;
            label1.Text = "Ingrese Usuario";
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInhabilitar.Font = new Font("Segoe UI", 9.75F);
            btnInhabilitar.Location = new Point(480, 406);
            btnInhabilitar.Margin = new Padding(4, 3, 4, 3);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(102, 38);
            btnInhabilitar.TabIndex = 15;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = true;
            btnInhabilitar.Click += btnInhabilitar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(358, 406);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(102, 38);
            button1.TabIndex = 16;
            button1.Text = "Habilitar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.Font = new Font("Segoe UI", 9.75F);
            btnInsertar.Location = new Point(572, 21);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(134, 32);
            btnInsertar.TabIndex = 17;
            btnInsertar.Text = "Registrar Usuario";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmListaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 469);
            Controls.Add(btnInsertar);
            Controls.Add(button1);
            Controls.Add(btnInhabilitar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(dtgUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += CategoriaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn Login_Usuario;
        private DataGridViewTextBoxColumn Pass_usuario;
        private DataGridViewTextBoxColumn Niv_Usuario;
        private DataGridViewTextBoxColumn Credenciales;
        private DataGridViewTextBoxColumn Est_Usuario;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fec_Registro;
        private DataGridViewTextBoxColumn Usu_Registro;
        private DataGridViewTextBoxColumn Fec_Ult_Mod;
        private DataGridViewTextBoxColumn Usu_Ult_Mod;
        private Button btnInhabilitar;
        private Button button1;
        private Button btnInsertar;
    }
}
namespace ProyVentas_GUI
{
    partial class frmActualizarProveedor
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
            grpDatos = new GroupBox();
            chkEstado = new CheckBox();
            mskRuc = new MaskedTextBox();
            cboDepartamento = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            btnGrabar = new Button();
            lblCod = new Label();
            label9 = new Label();
            Label1 = new Label();
            txtRS = new TextBox();
            txtDir = new TextBox();
            txtRepVen = new TextBox();
            txtTel = new TextBox();
            Label2 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtRepVentas = new Label();
            label7 = new Label();
            label5 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            btnCancelar = new Button();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkEstado);
            grpDatos.Controls.Add(mskRuc);
            grpDatos.Controls.Add(cboDepartamento);
            grpDatos.Controls.Add(cboProvincia);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(lblCod);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(Label1);
            grpDatos.Controls.Add(txtRS);
            grpDatos.Controls.Add(txtDir);
            grpDatos.Controls.Add(txtRepVen);
            grpDatos.Controls.Add(txtTel);
            grpDatos.Controls.Add(Label2);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(txtRepVentas);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(Label3);
            grpDatos.Controls.Add(Label4);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Location = new Point(14, 14);
            grpDatos.Margin = new Padding(4, 3, 4, 3);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 3, 4, 3);
            grpDatos.Size = new Size(463, 434);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(111, 369);
            chkEstado.Margin = new Padding(4, 3, 4, 3);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 8;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // mskRuc
            // 
            mskRuc.Location = new Point(110, 179);
            mskRuc.Margin = new Padding(4, 3, 4, 3);
            mskRuc.Mask = "99999999999";
            mskRuc.Name = "mskRuc";
            mskRuc.Size = new Size(116, 23);
            mskRuc.TabIndex = 7;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(110, 220);
            cboDepartamento.Margin = new Padding(4, 3, 4, 3);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(326, 23);
            cboDepartamento.TabIndex = 3;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(110, 257);
            cboProvincia.Margin = new Padding(4, 3, 4, 3);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(326, 23);
            cboProvincia.TabIndex = 3;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(110, 294);
            cboDistrito.Margin = new Padding(4, 3, 4, 3);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(326, 23);
            cboDistrito.TabIndex = 3;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(372, 343);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(84, 28);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblCod
            // 
            lblCod.BorderStyle = BorderStyle.FixedSingle;
            lblCod.Location = new Point(108, 37);
            lblCod.Margin = new Padding(4, 0, 4, 0);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(74, 23);
            lblCod.TabIndex = 3;
            // 
            // label9
            // 
            label9.Location = new Point(9, 37);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 18);
            label9.TabIndex = 3;
            label9.Text = "Codigo:";
            // 
            // Label1
            // 
            Label1.Location = new Point(9, 77);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(75, 18);
            Label1.TabIndex = 3;
            Label1.Text = "R.Social:";
            // 
            // txtRS
            // 
            txtRS.Location = new Point(110, 77);
            txtRS.Margin = new Padding(4, 3, 4, 3);
            txtRS.Name = "txtRS";
            txtRS.Size = new Size(247, 23);
            txtRS.TabIndex = 0;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(110, 113);
            txtDir.Margin = new Padding(4, 3, 4, 3);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(326, 23);
            txtDir.TabIndex = 1;
            // 
            // txtRepVen
            // 
            txtRepVen.Location = new Point(110, 331);
            txtRepVen.Margin = new Padding(4, 3, 4, 3);
            txtRepVen.Name = "txtRepVen";
            txtRepVen.Size = new Size(223, 23);
            txtRepVen.TabIndex = 4;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(110, 149);
            txtTel.Margin = new Padding(4, 3, 4, 3);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(96, 23);
            txtTel.TabIndex = 2;
            // 
            // Label2
            // 
            Label2.Location = new Point(9, 111);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(75, 18);
            Label2.TabIndex = 3;
            Label2.Text = "Direccion";
            // 
            // label6
            // 
            label6.Location = new Point(9, 220);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 3;
            label6.Text = "Departamento:";
            // 
            // label8
            // 
            label8.Location = new Point(9, 369);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 3;
            label8.Text = "Estado:";
            // 
            // txtRepVentas
            // 
            txtRepVentas.Location = new Point(9, 335);
            txtRepVentas.Margin = new Padding(4, 0, 4, 0);
            txtRepVentas.Name = "txtRepVentas";
            txtRepVentas.Size = new Size(93, 21);
            txtRepVentas.TabIndex = 3;
            txtRepVentas.Text = "Rep. Ventas:";
            // 
            // label7
            // 
            label7.Location = new Point(9, 185);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 18);
            label7.TabIndex = 3;
            label7.Text = "RUC:";
            // 
            // label5
            // 
            label5.Location = new Point(9, 257);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 3;
            label5.Text = "Provincia:";
            // 
            // Label3
            // 
            Label3.Location = new Point(9, 149);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(75, 18);
            Label3.TabIndex = 3;
            Label3.Text = "Telefono:";
            // 
            // Label4
            // 
            Label4.Location = new Point(9, 294);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(75, 18);
            Label4.TabIndex = 3;
            Label4.Text = "Distrito:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(372, 380);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // frmActualizarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 487);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmActualizarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Proveedor";
            Load += ProveedorMan03_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox grpDatos;
        private CheckBox chkEstado;
        private MaskedTextBox mskRuc;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        internal Button btnGrabar;
        internal Label lblCod;
        internal Label label9;
        internal Label Label1;
        internal TextBox txtRS;
        internal TextBox txtDir;
        internal TextBox txtRepVen;
        internal TextBox txtTel;
        internal Label Label2;
        internal Label label6;
        internal Label label8;
        internal Label txtRepVentas;
        internal Label label7;
        internal Label label5;
        internal Label Label3;
        internal Label Label4;
        internal Button btnCancelar;
    }
}
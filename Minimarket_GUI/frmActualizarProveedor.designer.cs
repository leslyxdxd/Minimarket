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
            txtTelefono = new MaskedTextBox();
            btnGrabar = new Button();
            lblRuc = new Label();
            lblProveedor = new Label();
            lblCod = new Label();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            txtCorreo = new TextBox();
            txtDir = new TextBox();
            label1 = new Label();
            Label2 = new Label();
            label8 = new Label();
            Label3 = new Label();
            btnCancelar = new Button();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkEstado);
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(lblRuc);
            grpDatos.Controls.Add(lblProveedor);
            grpDatos.Controls.Add(lblCod);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(txtCorreo);
            grpDatos.Controls.Add(txtDir);
            grpDatos.Controls.Add(label1);
            grpDatos.Controls.Add(Label2);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(Label3);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Location = new Point(28, 22);
            grpDatos.Margin = new Padding(4, 3, 4, 3);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 3, 4, 3);
            grpDatos.Size = new Size(463, 401);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "DATOS DEL PROVEEDOR";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(108, 291);
            chkEstado.Margin = new Padding(4, 3, 4, 3);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 8;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(108, 195);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Mask = "999999999";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 7;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.Teal;
            btnGrabar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrabar.ForeColor = Color.White;
            btnGrabar.Location = new Point(97, 338);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(117, 35);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.Location = new Point(108, 73);
            lblRuc.Margin = new Padding(4, 0, 4, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(236, 23);
            lblRuc.TabIndex = 3;
            // 
            // lblProveedor
            // 
            lblProveedor.BorderStyle = BorderStyle.FixedSingle;
            lblProveedor.Location = new Point(108, 110);
            lblProveedor.Margin = new Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(236, 23);
            lblProveedor.TabIndex = 3;
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
            // label4
            // 
            label4.Location = new Point(8, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 3;
            label4.Text = "Proveedor:";
            // 
            // label6
            // 
            label6.Location = new Point(9, 78);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 3;
            label6.Text = "RUC";
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
            // txtCorreo
            // 
            txtCorreo.Location = new Point(108, 238);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(326, 23);
            txtCorreo.TabIndex = 1;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(108, 157);
            txtDir.Margin = new Padding(4, 3, 4, 3);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(326, 23);
            txtDir.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(9, 243);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 3;
            label1.Text = "Correo:";
            // 
            // Label2
            // 
            Label2.Location = new Point(10, 160);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(75, 18);
            Label2.TabIndex = 3;
            Label2.Text = "Direccion";
            // 
            // label8
            // 
            label8.Location = new Point(10, 292);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 3;
            label8.Text = "Estado:";
            // 
            // Label3
            // 
            Label3.Location = new Point(9, 198);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(75, 18);
            Label3.TabIndex = 3;
            Label3.Text = "Telefono:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(242, 338);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // frmActualizarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 445);
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
        internal Button btnGrabar;
        internal Label lblCod;
        internal Label label9;
        internal TextBox txtDir;
        internal Label Label2;
        internal Label label8;
        internal Label Label3;
        internal Button btnCancelar;
        private MaskedTextBox txtTelefono;
        internal Label lblProveedor;
        internal Label label4;
        internal TextBox txtCorreo;
        internal Label label1;
        internal Label lblRuc;
        internal Label label6;
    }
}
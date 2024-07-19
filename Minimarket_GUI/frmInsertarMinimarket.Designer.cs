namespace Minimarket_GUI
{
    partial class frmInsertarMinimarket
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
            txtRuc = new MaskedTextBox();
            btnInhabilitar = new Button();
            button1 = new Button();
            txtTelefono = new MaskedTextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtRuc);
            grpDatos.Controls.Add(btnInhabilitar);
            grpDatos.Controls.Add(button1);
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(txtDireccion);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(label1);
            grpDatos.Controls.Add(Label2);
            grpDatos.Controls.Add(Label3);
            grpDatos.Location = new Point(23, 21);
            grpDatos.Margin = new Padding(4, 3, 4, 3);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 3, 4, 3);
            grpDatos.Size = new Size(467, 291);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "DATOS DEL MINIMARKET";
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(111, 175);
            txtRuc.Margin = new Padding(4, 3, 4, 3);
            txtRuc.Mask = "99999999999";
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(150, 23);
            txtRuc.TabIndex = 66;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInhabilitar.BackColor = Color.Firebrick;
            btnInhabilitar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Location = new Point(234, 235);
            btnInhabilitar.Margin = new Padding(4, 3, 4, 3);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(118, 37);
            btnInhabilitar.TabIndex = 65;
            btnInhabilitar.Text = "Cancelar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            btnInhabilitar.Click += btnCancelar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(89, 235);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 64;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGrabar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(111, 88);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Mask = "999999999";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label6
            // 
            label6.Location = new Point(12, 175);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 3;
            label6.Text = "RUC";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(111, 134);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(326, 23);
            txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 43);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(326, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(11, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 3;
            label1.Text = "Correo:";
            // 
            // Label2
            // 
            Label2.Location = new Point(11, 48);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(75, 18);
            Label2.TabIndex = 3;
            Label2.Text = "nombre:";
            // 
            // Label3
            // 
            Label3.Location = new Point(11, 93);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(75, 18);
            Label3.TabIndex = 3;
            Label3.Text = "Telefono:";
            // 
            // frmInsertarMinimarket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 336);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInsertarMinimarket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Minimarket";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox grpDatos;
        private MaskedTextBox txtTelefono;
        internal Label label6;
        internal TextBox txtDireccion;
        internal TextBox txtNombre;
        internal Label label1;
        internal Label Label2;
        internal Label Label3;
        private Button btnInhabilitar;
        private Button button1;
        private MaskedTextBox txtRuc;
    }
}
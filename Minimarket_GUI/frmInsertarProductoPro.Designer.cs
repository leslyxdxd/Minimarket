namespace Minimarket_GUI
{
    partial class frmInsertarProductoPro
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
            lblNombre = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtPrecio = new TextBox();
            cboUnidad = new ComboBox();
            txtMarca = new TextBox();
            txtProducto = new TextBox();
            label9 = new Label();
            label16 = new Label();
            label3 = new Label();
            label22 = new Label();
            cboCategoria = new ComboBox();
            label2 = new Label();
            lblCodigo = new Label();
            label23 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            lblRuc = new Label();
            btnInsertar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(346, 39);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(213, 26);
            lblNombre.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 14;
            label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(cboUnidad);
            groupBox2.Controls.Add(txtMarca);
            groupBox2.Controls.Add(txtProducto);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(cboCategoria);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9.75F);
            groupBox2.Location = new Point(27, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(827, 170);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "INSERTAR NUEVO PRODUCTO";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(404, 100);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(131, 25);
            txtPrecio.TabIndex = 66;
            // 
            // cboUnidad
            // 
            cboUnidad.BackColor = SystemColors.ControlLight;
            cboUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidad.Font = new Font("Century Gothic", 9F);
            cboUnidad.ForeColor = SystemColors.InactiveCaptionText;
            cboUnidad.FormattingEnabled = true;
            cboUnidad.Location = new Point(653, 38);
            cboUnidad.Name = "cboUnidad";
            cboUnidad.Size = new Size(129, 25);
            cboUnidad.TabIndex = 60;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(95, 100);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(129, 25);
            txtMarca.TabIndex = 64;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(95, 43);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(129, 25);
            txtProducto.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 44);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 59;
            label9.Text = "U.Medida";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(282, 103);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(94, 17);
            label16.TabIndex = 57;
            label16.Text = "Precio Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 55;
            label3.Text = "Categoria";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(22, 103);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(48, 17);
            label22.TabIndex = 52;
            label22.Text = "Marca:";
            // 
            // cboCategoria
            // 
            cboCategoria.BackColor = SystemColors.ControlLight;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Century Gothic", 9F);
            cboCategoria.ForeColor = SystemColors.InactiveCaptionText;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(384, 38);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(129, 25);
            cboCategoria.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 30;
            label2.Text = "Producto";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(95, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(113, 23);
            lblCodigo.TabIndex = 13;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(64, 64, 64);
            label23.Location = new Point(27, 18);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(458, 32);
            label23.TabIndex = 61;
            label23.Text = "AÑADIR PRODUCTO / PROVEEDOR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblRuc);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Font = new Font("Segoe UI", 9.75F);
            groupBox1.Location = new Point(27, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(827, 101);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACION DEL PROVEEDOR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 44);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 56;
            label6.Text = "RUC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 44);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 54;
            label5.Text = "Razon social:";
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.Location = new Point(653, 39);
            lblRuc.Margin = new Padding(4, 0, 4, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(116, 26);
            lblRuc.TabIndex = 53;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.Teal;
            btnInsertar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(643, 419);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(211, 55);
            btnInsertar.TabIndex = 63;
            btnInsertar.Text = "Guardar Producto";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmInsertarProductoPro
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(891, 525);
            Controls.Add(btnInsertar);
            Controls.Add(groupBox1);
            Controls.Add(label23);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 900);
            MinimizeBox = false;
            MinimumSize = new Size(907, 548);
            Name = "frmInsertarProductoPro";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Proveedor";
            Load += frmInsertarProductoPro_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEstados;
        private Label label1;
        private GroupBox groupBox2;
        private Label label22;
        private ComboBox cboCategoria;
        private Label label2;
        private NumericUpDown UpdownCantidad;
        private Label lblCodigo;
        private Label label23;
        private GroupBox groupBox1;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label lblRuc;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private ComboBox cboUnidad;
        private Button btnInsertar;
        private TextBox txtPrecio;
        private TextBox txtMarca;
        private TextBox txtProducto;
    }
}
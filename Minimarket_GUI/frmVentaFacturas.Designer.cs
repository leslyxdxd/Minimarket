namespace Minimarket_GUI
{
    partial class frmVentaFacturas
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
            lblRegistros = new Label();
            label10 = new Label();
            dtgProducto = new DataGridView();
            Cod_Producto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            IGV = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label16 = new Label();
            label12 = new Label();
            label15 = new Label();
            label1 = new Label();
            txtRuc = new RichTextBox();
            lblEstado = new Label();
            lblDireccion = new Label();
            lblRazonSocial = new Label();
            groupBox1 = new GroupBox();
            txtCantidad2 = new RichTextBox();
            label7 = new Label();
            label11 = new Label();
            lblStock = new Label();
            lblUM = new Label();
            label9 = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblCodigo = new Label();
            button3 = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            lblTotal = new Label();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            groupBox3 = new GroupBox();
            rbtnTarjeta = new RadioButton();
            rbtnEfectivo = new RadioButton();
            label5 = new Label();
            label8 = new Label();
            lblDevolucion = new Label();
            rtxtEfectivo = new RichTextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProducto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(130, 674);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 58;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 678);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 57;
            label10.Text = "REGISTROS";
            // 
            // dtgProducto
            // 
            dtgProducto.AllowUserToAddRows = false;
            dtgProducto.AllowUserToDeleteRows = false;
            dtgProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProducto.BackgroundColor = SystemColors.ControlLight;
            dtgProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProducto.Columns.AddRange(new DataGridViewColumn[] { Cod_Producto, Producto, Precio, Cantidad, IGV, SubTotal });
            dtgProducto.Location = new Point(26, 300);
            dtgProducto.Margin = new Padding(4, 3, 4, 3);
            dtgProducto.Name = "dtgProducto";
            dtgProducto.ReadOnly = true;
            dtgProducto.RowHeadersVisible = false;
            dtgProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProducto.Size = new Size(962, 357);
            dtgProducto.TabIndex = 55;
            // 
            // Cod_Producto
            // 
            Cod_Producto.DataPropertyName = "Cod_Producto";
            Cod_Producto.HeaderText = "Cod.Producto";
            Cod_Producto.Name = "Cod_Producto";
            Cod_Producto.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.DataPropertyName = "Nom_Producto";
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio_Unitario";
            Precio.HeaderText = "Precio(S/.)";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // IGV
            // 
            IGV.DataPropertyName = "IGV";
            IGV.HeaderText = "IGV";
            IGV.Name = "IGV";
            IGV.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            SubTotal.HeaderText = "SubTotal(S/.)";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtRuc);
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(lblDireccion);
            groupBox2.Controls.Add(lblRazonSocial);
            groupBox2.Location = new Point(26, 48);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(962, 111);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMACIÓN DEL COMPRADOR";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.BackgroundImage = Properties.Resources.lupa;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(206, 29);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(33, 33);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(766, 37);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 1;
            label16.Text = "ESTADO";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(346, 73);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 1;
            label12.Text = "DIRECCIÓN";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(264, 37);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(150, 15);
            label15.TabIndex = 1;
            label15.Text = "NOMBRE / RAZÓN SOCIAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "RUC";
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(52, 35);
            txtRuc.Margin = new Padding(4, 3, 4, 3);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(148, 22);
            txtRuc.TabIndex = 0;
            txtRuc.Text = "";
            // 
            // lblEstado
            // 
            lblEstado.BorderStyle = BorderStyle.FixedSingle;
            lblEstado.Location = new Point(839, 32);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(108, 25);
            lblEstado.TabIndex = 17;
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.Location = new Point(456, 75);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(491, 25);
            lblDireccion.TabIndex = 17;
            lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.BorderStyle = BorderStyle.FixedSingle;
            lblRazonSocial.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRazonSocial.Location = new Point(458, 32);
            lblRazonSocial.Margin = new Padding(4, 0, 4, 0);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(302, 25);
            lblRazonSocial.TabIndex = 17;
            lblRazonSocial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCantidad2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(lblUM);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(26, 166);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(962, 128);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLE DE PRODUCTO";
            // 
            // txtCantidad2
            // 
            txtCantidad2.Location = new Point(856, 77);
            txtCantidad2.Margin = new Padding(4, 3, 4, 3);
            txtCantidad2.Name = "txtCantidad2";
            txtCantidad2.Size = new Size(92, 35);
            txtCantidad2.TabIndex = 23;
            txtCantidad2.Text = "";
            txtCantidad2.TextChanged += txtCantidad2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(856, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 21;
            label7.Text = "CANTIDAD";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(607, 50);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 20;
            label11.Text = "UNIDAD M.";
            // 
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.FixedSingle;
            lblStock.Location = new Point(743, 78);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(90, 35);
            lblStock.TabIndex = 19;
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUM
            // 
            lblUM.BorderStyle = BorderStyle.FixedSingle;
            lblUM.Location = new Point(607, 81);
            lblUM.Margin = new Padding(4, 0, 4, 0);
            lblUM.Name = "lblUM";
            lblUM.Size = new Size(98, 35);
            lblUM.TabIndex = 19;
            lblUM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(743, 50);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 18;
            label9.Text = "STOCK";
            // 
            // lblPrecio
            // 
            lblPrecio.BorderStyle = BorderStyle.FixedSingle;
            lblPrecio.Location = new Point(467, 81);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(120, 35);
            lblPrecio.TabIndex = 14;
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(192, 81);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(267, 35);
            lblNombre.TabIndex = 13;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 9;
            label6.Text = "PRECIO (S/.)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 50);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Codigo P.";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(6, 76);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(81, 37);
            lblCodigo.TabIndex = 8;
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(104, 77);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(69, 39);
            button3.TabIndex = 7;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.ForeColor = SystemColors.ControlText;
            btnAgregar.Location = new Point(1003, 177);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 55);
            btnAgregar.TabIndex = 52;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1003, 318);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 51;
            label2.Text = "Total a pagar";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(1004, 353);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(140, 35);
            lblTotal.TabIndex = 50;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1003, 595);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(144, 61);
            btnRegistrar.TabIndex = 49;
            btnRegistrar.Text = "Registrar comprobante";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.Location = new Point(1003, 242);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 52);
            btnEliminar.TabIndex = 59;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtnTarjeta);
            groupBox3.Controls.Add(rbtnEfectivo);
            groupBox3.Location = new Point(1003, 48);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(142, 111);
            groupBox3.TabIndex = 60;
            groupBox3.TabStop = false;
            groupBox3.Text = "Metodo de pago";
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(19, 72);
            rbtnTarjeta.Margin = new Padding(4, 3, 4, 3);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(68, 19);
            rbtnTarjeta.TabIndex = 1;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.Text = "TARJETA";
            rbtnTarjeta.UseVisualStyleBackColor = true;
            rbtnTarjeta.CheckedChanged += rbtnTarjeta_CheckedChanged;
            // 
            // rbtnEfectivo
            // 
            rbtnEfectivo.AutoSize = true;
            rbtnEfectivo.Location = new Point(19, 33);
            rbtnEfectivo.Margin = new Padding(4, 3, 4, 3);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(76, 19);
            rbtnEfectivo.TabIndex = 0;
            rbtnEfectivo.TabStop = true;
            rbtnEfectivo.Text = "EFECTIVO";
            rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1004, 509);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 64;
            label5.Text = "DEVOLUCIÓN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1003, 411);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 63;
            label8.Text = "EFECTIVO:";
            // 
            // lblDevolucion
            // 
            lblDevolucion.BorderStyle = BorderStyle.FixedSingle;
            lblDevolucion.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevolucion.ForeColor = Color.Red;
            lblDevolucion.Location = new Point(1003, 539);
            lblDevolucion.Margin = new Padding(4, 0, 4, 0);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(141, 35);
            lblDevolucion.TabIndex = 62;
            lblDevolucion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rtxtEfectivo
            // 
            rtxtEfectivo.Location = new Point(1003, 435);
            rtxtEfectivo.Margin = new Padding(4, 3, 4, 3);
            rtxtEfectivo.Name = "rtxtEfectivo";
            rtxtEfectivo.Size = new Size(140, 37);
            rtxtEfectivo.TabIndex = 61;
            rtxtEfectivo.Text = "";
            rtxtEfectivo.TextChanged += rtxtEfectivo_TextChanged;
            rtxtEfectivo.KeyPress += rtxtEfectivo_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(26, 0);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(321, 32);
            label13.TabIndex = 65;
            label13.Text = "FACTURA ELECTRONICA";
            // 
            // frmVentaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1157, 717);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(lblDevolucion);
            Controls.Add(rtxtEfectivo);
            Controls.Add(groupBox3);
            Controls.Add(btnEliminar);
            Controls.Add(lblRegistros);
            Controls.Add(label10);
            Controls.Add(dtgProducto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVentaFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de compras";
            FormClosing += frmVentaFacturas_FormClosing;
            Load += frmVentaFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProducto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros;
        private Label label10;
        private DataGridView dtgProducto;
        private GroupBox groupBox2;
        private Label label16;
        private Label label15;
        private Label label1;
        private RichTextBox txtRuc;
        private Label lblEstado;
        private Label lblRazonSocial;
        private GroupBox groupBox1;
        private Label label11;
        private Label lblStock;
        private Label lblUM;
        private Label label9;
        private Label lblPrecio;
        private Label lblNombre;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label lblCodigo;
        private Button button3;
        private Button btnAgregar;
        private Label label2;
        private Label lblTotal;
        private Button btnRegistrar;
        private Label label12;
        private Label lblDireccion;
        private TextBox textBox1;
        private Label label7;
        private Button btnEliminar;
        private Button button4;
        private RichTextBox txtCantidad2;
        private GroupBox groupBox3;
        private RadioButton rbtnTarjeta;
        private RadioButton rbtnEfectivo;
        private Label label5;
        private Label label8;
        private Label lblDevolucion;
        private RichTextBox rtxtEfectivo;
        private Button button1;
        private DataGridViewTextBoxColumn Cod_Producto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn IGV;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label13;
    }
}
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
            label21 = new Label();
            dtgProducto = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
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
            button2 = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProducto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(96, 784);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 58;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 787);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 57;
            label10.Text = "Registros:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(26, 9);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(303, 37);
            label21.TabIndex = 56;
            label21.Text = "FACTURA ELECTRONICA";
            // 
            // dtgProducto
            // 
            dtgProducto.AllowUserToAddRows = false;
            dtgProducto.AllowUserToDeleteRows = false;
            dtgProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProducto.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, SubTotal });
            dtgProducto.Location = new Point(32, 312);
            dtgProducto.Margin = new Padding(4, 3, 4, 3);
            dtgProducto.Name = "dtgProducto";
            dtgProducto.ReadOnly = true;
            dtgProducto.RowHeadersVisible = false;
            dtgProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProducto.Size = new Size(778, 461);
            dtgProducto.TabIndex = 55;
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
            Precio.HeaderText = "Precio";
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
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            SubTotal.HeaderText = "SubTotal";
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
            groupBox2.Location = new Point(32, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(994, 111);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información del comprador";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.BackgroundImage = Properties.Resources.lupa;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(206, 29);
            button4.Name = "button4";
            button4.Size = new Size(33, 33);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(775, 37);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 1;
            label16.Text = "Estado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(361, 75);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 1;
            label12.Text = "Dirección";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(290, 37);
            label15.Name = "label15";
            label15.Size = new Size(128, 15);
            label15.TabIndex = 1;
            label15.Text = "Nombre / Razón Social";
            label15.Click += label15_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "RUC";
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(52, 35);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(148, 23);
            txtRuc.TabIndex = 0;
            txtRuc.Text = "";
            // 
            // lblEstado
            // 
            lblEstado.BorderStyle = BorderStyle.FixedSingle;
            lblEstado.Location = new Point(824, 33);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(108, 25);
            lblEstado.TabIndex = 17;
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.Location = new Point(436, 70);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(381, 25);
            lblDireccion.TabIndex = 17;
            lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.BorderStyle = BorderStyle.FixedSingle;
            lblRazonSocial.Location = new Point(438, 32);
            lblRazonSocial.Margin = new Padding(4, 0, 4, 0);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(310, 25);
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
            groupBox1.Location = new Point(32, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(994, 128);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Producto ";
            // 
            // txtCantidad2
            // 
            txtCantidad2.Location = new Point(833, 71);
            txtCantidad2.Name = "txtCantidad2";
            txtCantidad2.Size = new Size(84, 35);
            txtCantidad2.TabIndex = 23;
            txtCantidad2.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(833, 45);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 21;
            label7.Text = "Cantidad ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(612, 45);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 20;
            label11.Text = "U.M.";
            // 
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.FixedSingle;
            lblStock.Location = new Point(708, 71);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(90, 35);
            lblStock.TabIndex = 19;
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUM
            // 
            lblUM.BorderStyle = BorderStyle.FixedSingle;
            lblUM.Location = new Point(591, 69);
            lblUM.Margin = new Padding(4, 0, 4, 0);
            lblUM.Name = "lblUM";
            lblUM.Size = new Size(90, 35);
            lblUM.TabIndex = 19;
            lblUM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(733, 45);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 18;
            label9.Text = "Stock ";
            // 
            // lblPrecio
            // 
            lblPrecio.BorderStyle = BorderStyle.FixedSingle;
            lblPrecio.Location = new Point(436, 71);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(120, 35);
            lblPrecio.TabIndex = 14;
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(198, 71);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(206, 35);
            lblNombre.TabIndex = 13;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 42);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 9;
            label6.Text = "Precio ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 42);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 42);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 9;
            label3.Text = "Cod.Producto";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(16, 67);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(81, 37);
            lblCodigo.TabIndex = 8;
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(112, 67);
            button3.Name = "button3";
            button3.Size = new Size(69, 39);
            button3.TabIndex = 7;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(879, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(147, 71);
            btnAgregar.TabIndex = 52;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(879, 617);
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
            lblTotal.Location = new Point(879, 659);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(147, 35);
            lblTotal.TabIndex = 50;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Location = new Point(879, 725);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 49;
            button2.Text = "Registrar comprobante";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(879, 456);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 71);
            btnEliminar.TabIndex = 59;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmVentaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 818);
            Controls.Add(btnEliminar);
            Controls.Add(lblRegistros);
            Controls.Add(label10);
            Controls.Add(label21);
            Controls.Add(dtgProducto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(button2);
            Name = "frmVentaFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de compras";
            Load += frmVentaFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProducto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros;
        private Label label10;
        private Label label21;
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
        private Button button2;
        private Label label12;
        private Label lblDireccion;
        private TextBox textBox1;
        private Label label7;
        private RichTextBox txtCantidad2;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Button button4;
    }
}
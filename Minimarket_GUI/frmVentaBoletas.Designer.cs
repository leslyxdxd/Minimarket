namespace Minimarket_GUI
{
    partial class frmVentaBoletas
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
            button2 = new Button();
            lblTotalPagar = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            txtCantidad = new TextBox();
            label11 = new Label();
            lblStock = new Label();
            lblUM = new Label();
            label9 = new Label();
            label7 = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblCodigo = new Label();
            dtgListaProductos = new DataGridView();
            Cod_Producto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtDNI = new TextBox();
            btnBuscarClienteDNI = new Button();
            label16 = new Label();
            label15 = new Label();
            label1 = new Label();
            lblApellidos = new Label();
            lblNombres = new Label();
            label21 = new Label();
            lblRegistros = new Label();
            label10 = new Label();
            btnEliminarProducto = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaProductos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(897, 691);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 3;
            button2.Text = "Registrar comprobante";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.BorderStyle = BorderStyle.FixedSingle;
            lblTotalPagar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPagar.ForeColor = Color.Red;
            lblTotalPagar.Location = new Point(897, 637);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(147, 35);
            lblTotalPagar.TabIndex = 4;
            lblTotalPagar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(897, 612);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 5;
            label2.Text = "Total a pagar";
            // 
            // button1
            // 
            button1.Location = new Point(891, 311);
            button1.Name = "button1";
            button1.Size = new Size(147, 71);
            button1.TabIndex = 6;
            button1.Text = "Agregar producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(lblUM);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(28, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1025, 122);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Producto ";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(831, 75);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 21;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(831, 45);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 15;
            label7.Text = "Cantidad ";
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
            // dtgListaProductos
            // 
            dtgListaProductos.AllowUserToAddRows = false;
            dtgListaProductos.AllowUserToDeleteRows = false;
            dtgListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaProductos.Columns.AddRange(new DataGridViewColumn[] { Cod_Producto, Producto, Precio, Cantidad, SubTotal });
            dtgListaProductos.Location = new Point(28, 311);
            dtgListaProductos.Margin = new Padding(4, 3, 4, 3);
            dtgListaProductos.Name = "dtgListaProductos";
            dtgListaProductos.ReadOnly = true;
            dtgListaProductos.RowHeadersVisible = false;
            dtgListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListaProductos.Size = new Size(833, 439);
            dtgListaProductos.TabIndex = 9;
            // 
            // Cod_Producto
            // 
            Cod_Producto.DataPropertyName = "Cod_Producto";
            Cod_Producto.HeaderText = "Cod.Producto";
            Cod_Producto.Name = "Cod_Producto";
            Cod_Producto.ReadOnly = true;
            Cod_Producto.Resizable = DataGridViewTriState.False;
            // 
            // Producto
            // 
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Precio";
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
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(btnBuscarClienteDNI);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblApellidos);
            groupBox2.Controls.Add(lblNombres);
            groupBox2.Location = new Point(28, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1025, 76);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información del comprador";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(70, 35);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(129, 23);
            txtDNI.TabIndex = 21;
            // 
            // btnBuscarClienteDNI
            // 
            btnBuscarClienteDNI.BackColor = SystemColors.ButtonFace;
            btnBuscarClienteDNI.BackgroundImage = Properties.Resources.lupa;
            btnBuscarClienteDNI.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarClienteDNI.Location = new Point(977, 29);
            btnBuscarClienteDNI.Name = "btnBuscarClienteDNI";
            btnBuscarClienteDNI.Size = new Size(33, 33);
            btnBuscarClienteDNI.TabIndex = 18;
            btnBuscarClienteDNI.UseVisualStyleBackColor = false;
            btnBuscarClienteDNI.Click += btnBuscarClienteDNI_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(576, 37);
            label16.Name = "label16";
            label16.Size = new Size(59, 15);
            label16.TabIndex = 1;
            label16.Text = "Apellidos:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(255, 37);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 1;
            label15.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // lblApellidos
            // 
            lblApellidos.BorderStyle = BorderStyle.FixedSingle;
            lblApellidos.Location = new Point(642, 32);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(323, 25);
            lblApellidos.TabIndex = 17;
            lblApellidos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombres
            // 
            lblNombres.BorderStyle = BorderStyle.FixedSingle;
            lblNombres.Location = new Point(334, 32);
            lblNombres.Margin = new Padding(4, 0, 4, 0);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(222, 25);
            lblNombres.TabIndex = 17;
            lblNombres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(20, 9);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(284, 37);
            label21.TabIndex = 46;
            label21.Text = "BOLETA ELECTRONICA";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(98, 766);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 48;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 770);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 47;
            label10.Text = "Registros:";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(891, 411);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(147, 68);
            btnEliminarProducto.TabIndex = 49;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // frmVentaBoletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1074, 804);
            Controls.Add(btnEliminarProducto);
            Controls.Add(lblRegistros);
            Controls.Add(label10);
            Controls.Add(label21);
            Controls.Add(dtgListaProductos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblTotalPagar);
            Controls.Add(button2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVentaBoletas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaProductos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label lblTotalPagar;
        private Label label2;
        private Button button1;
        private Button button3;
        private GroupBox groupBox1;
        private Label lblNombre;
        private Label label4;
        private Label label3;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label label6;
        private Label label7;
        private Label label11;
        private Label lblUM;
        private Label label9;
        private DataGridView dtgListaProductos;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblApellidos;
        private Label lblNombres;
        private Label label16;
        private Label label15;
        private Label label21;
        private Label lblStock;
        private Label lblRegistros;
        private Label label10;
        private TextBox txtCantidad;
        private Button btnBuscarClienteDNI;
        private TextBox txtDNI;
        private Button btnEliminarProducto;
        private DataGridViewTextBoxColumn Cod_Producto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaBoletas));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTotalPagar = new Label();
            label2 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
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
            IGV = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            txtDNI = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label1 = new Label();
            lblApellidos = new Label();
            lblNombres = new Label();
            lblRegistros = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            radioButtonTarjeta = new RadioButton();
            radiobuttonEfectivo = new RadioButton();
            rtxtbEfectivo = new RichTextBox();
            lblDevolucion = new Label();
            label8 = new Label();
            label12 = new Label();
            label5 = new Label();
            btnInsertar = new Button();
            btnInhabilitar = new Button();
            button1 = new Button();
            txtCantidad = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaProductos).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.BorderStyle = BorderStyle.FixedSingle;
            lblTotalPagar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPagar.ForeColor = Color.Red;
            lblTotalPagar.Location = new Point(1004, 321);
            lblTotalPagar.Margin = new Padding(4, 0, 4, 0);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(127, 35);
            lblTotalPagar.TabIndex = 4;
            lblTotalPagar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1004, 288);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 5;
            label2.Text = "TOTAL A PAGAR";
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(112, 67);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(69, 39);
            button3.TabIndex = 7;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
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
            groupBox1.Font = new Font("Segoe UI", 8F);
            groupBox1.Location = new Point(28, 150);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(957, 122);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLE DE PRODUCTO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(583, 45);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(65, 13);
            label11.TabIndex = 20;
            label11.Text = "UNIDAD M.";
            // 
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.FixedSingle;
            lblStock.Location = new Point(728, 72);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(90, 35);
            lblStock.TabIndex = 19;
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUM
            // 
            lblUM.BorderStyle = BorderStyle.FixedSingle;
            lblUM.Location = new Point(583, 69);
            lblUM.Margin = new Padding(4, 0, 4, 0);
            lblUM.Name = "lblUM";
            lblUM.Size = new Size(98, 35);
            lblUM.TabIndex = 19;
            lblUM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(728, 45);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 13);
            label9.TabIndex = 18;
            label9.Text = "STOCK";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(853, 45);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 13);
            label7.TabIndex = 15;
            label7.Text = "CANTIDAD";
            // 
            // lblPrecio
            // 
            lblPrecio.BorderStyle = BorderStyle.FixedSingle;
            lblPrecio.Location = new Point(436, 72);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(120, 35);
            lblPrecio.TabIndex = 14;
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(198, 72);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(206, 35);
            lblNombre.TabIndex = 13;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 45);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 13);
            label6.TabIndex = 9;
            label6.Text = "PRECIO (S/.)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 42);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 13);
            label4.TabIndex = 9;
            label4.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 13);
            label3.TabIndex = 9;
            label3.Text = "Codigo P.";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(16, 67);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(81, 37);
            lblCodigo.TabIndex = 8;
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgListaProductos
            // 
            dtgListaProductos.AllowUserToAddRows = false;
            dtgListaProductos.AllowUserToDeleteRows = false;
            dtgListaProductos.AllowUserToResizeColumns = false;
            dtgListaProductos.AllowUserToResizeRows = false;
            dtgListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListaProductos.BackgroundColor = SystemColors.ControlLight;
            dtgListaProductos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaProductos.Columns.AddRange(new DataGridViewColumn[] { Cod_Producto, Producto, Precio, Cantidad, IGV, SubTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgListaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dtgListaProductos.GridColor = SystemColors.ButtonHighlight;
            dtgListaProductos.Location = new Point(28, 278);
            dtgListaProductos.Margin = new Padding(4, 3, 4, 3);
            dtgListaProductos.Name = "dtgListaProductos";
            dtgListaProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgListaProductos.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListaProductos.Size = new Size(957, 374);
            dtgListaProductos.TabIndex = 9;
            dtgListaProductos.CellContentClick += dtgListaProductos_CellContentClick;
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
            dataGridViewCellStyle2.Format = "F2";
            Precio.DefaultCellStyle = dataGridViewCellStyle2;
            Precio.HeaderText = "Precio(S/.)";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Resizable = DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Precio";
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
            groupBox2.Controls.Add(guna2ImageButton3);
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblApellidos);
            groupBox2.Controls.Add(lblNombres);
            groupBox2.Font = new Font("Segoe UI", 8F);
            groupBox2.Location = new Point(28, 48);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(860, 95);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMACIÓN DEL COMPRADOR";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // guna2ImageButton3
            // 
            guna2ImageButton3.BackColor = Color.White;
            guna2ImageButton3.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Cursor = Cursors.Hand;
            guna2ImageButton3.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Image = (Image)resources.GetObject("guna2ImageButton3.Image");
            guna2ImageButton3.ImageOffset = new Point(0, 0);
            guna2ImageButton3.ImageRotate = 0F;
            guna2ImageButton3.ImageSize = new Size(28, 28);
            guna2ImageButton3.Location = new Point(210, 21);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton3.Size = new Size(40, 35);
            guna2ImageButton3.TabIndex = 27;
            guna2ImageButton3.Click += btnBuscarClienteDNI_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(49, 32);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(154, 22);
            txtDNI.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(310, 62);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(62, 13);
            label16.TabIndex = 1;
            label16.Text = "APELLIDOS";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(314, 27);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(59, 13);
            label15.TabIndex = 1;
            label15.Text = "NOMBRES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 13);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // lblApellidos
            // 
            lblApellidos.BorderStyle = BorderStyle.FixedSingle;
            lblApellidos.Location = new Point(398, 57);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(389, 27);
            lblApellidos.TabIndex = 17;
            lblApellidos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombres
            // 
            lblNombres.BorderStyle = BorderStyle.FixedSingle;
            lblNombres.Location = new Point(398, 18);
            lblNombres.Margin = new Padding(4, 0, 4, 0);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(389, 27);
            lblNombres.TabIndex = 17;
            lblNombres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(131, 672);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(100, 22);
            lblRegistros.TabIndex = 48;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 676);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 47;
            label10.Text = "REGISTROS";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonTarjeta);
            groupBox3.Controls.Add(radiobuttonEfectivo);
            groupBox3.Font = new Font("Segoe UI", 8F);
            groupBox3.Location = new Point(894, 48);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(237, 95);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "METODO DE PAGO";
            // 
            // radioButtonTarjeta
            // 
            radioButtonTarjeta.AutoSize = true;
            radioButtonTarjeta.Location = new Point(111, 48);
            radioButtonTarjeta.Margin = new Padding(4, 3, 4, 3);
            radioButtonTarjeta.Name = "radioButtonTarjeta";
            radioButtonTarjeta.Size = new Size(66, 17);
            radioButtonTarjeta.TabIndex = 1;
            radioButtonTarjeta.TabStop = true;
            radioButtonTarjeta.Text = "TARJETA";
            radioButtonTarjeta.UseVisualStyleBackColor = true;
            radioButtonTarjeta.CheckedChanged += radioButtonTarjeta_CheckedChanged;
            // 
            // radiobuttonEfectivo
            // 
            radiobuttonEfectivo.AutoSize = true;
            radiobuttonEfectivo.Location = new Point(15, 48);
            radiobuttonEfectivo.Margin = new Padding(4, 3, 4, 3);
            radiobuttonEfectivo.Name = "radiobuttonEfectivo";
            radiobuttonEfectivo.Size = new Size(75, 17);
            radiobuttonEfectivo.TabIndex = 0;
            radiobuttonEfectivo.TabStop = true;
            radiobuttonEfectivo.Text = "EFECTIVO";
            radiobuttonEfectivo.UseVisualStyleBackColor = true;
            // 
            // rtxtbEfectivo
            // 
            rtxtbEfectivo.Location = new Point(1006, 410);
            rtxtbEfectivo.Margin = new Padding(4, 3, 4, 3);
            rtxtbEfectivo.Name = "rtxtbEfectivo";
            rtxtbEfectivo.Size = new Size(126, 37);
            rtxtbEfectivo.TabIndex = 54;
            rtxtbEfectivo.Text = "";
            rtxtbEfectivo.TextChanged += rtxtbEfectivo_TextChanged;
            rtxtbEfectivo.KeyPress += rtxtbEfectivo_KeyPress;
            // 
            // lblDevolucion
            // 
            lblDevolucion.BorderStyle = BorderStyle.FixedSingle;
            lblDevolucion.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevolucion.ForeColor = Color.Red;
            lblDevolucion.Location = new Point(1007, 504);
            lblDevolucion.Margin = new Padding(4, 0, 4, 0);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(126, 35);
            lblDevolucion.TabIndex = 55;
            lblDevolucion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1004, 387);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 56;
            label8.Text = "EFECTIVO:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1006, 483);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 21);
            label12.TabIndex = 57;
            label12.Text = "DEVOLUCIÓN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(28, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(298, 32);
            label5.TabIndex = 59;
            label5.Text = "BOLETA ELECTRONICA";
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.Teal;
            btnInsertar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(1004, 160);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(127, 54);
            btnInsertar.TabIndex = 25;
            btnInsertar.Text = "Agregar Producto";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnAgregar_Click;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInhabilitar.BackColor = Color.Firebrick;
            btnInhabilitar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Location = new Point(1004, 219);
            btnInhabilitar.Margin = new Padding(4, 3, 4, 3);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(127, 54);
            btnInhabilitar.TabIndex = 25;
            btnInhabilitar.Text = "Eliminar Producto";
            btnInhabilitar.UseVisualStyleBackColor = false;
            btnInhabilitar.Click += btnEliminarProducto_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1007, 584);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(124, 68);
            button1.TabIndex = 61;
            button1.Text = "Registrar Comprobante";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRegistrarBoleta_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(853, 72);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(84, 35);
            txtCantidad.TabIndex = 24;
            txtCantidad.Text = "";
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // frmVentaBoletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1157, 717);
            Controls.Add(button1);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnInsertar);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(lblDevolucion);
            Controls.Add(rtxtbEfectivo);
            Controls.Add(groupBox3);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(lblTotalPagar);
            Controls.Add(dtgListaProductos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVentaBoletas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de compra";
            FormClosing += frmVentaBoletas_FormClosing;
            Load += frmVentaBoletas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaProductos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTotalPagar;
        private Label label2;
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
        private Label lblStock;
        private Label lblRegistros;
        private Label label10;
        private TextBox txtDNI;
        private DataGridViewTextBoxColumn Cod_Producto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn IGV;
        private DataGridViewTextBoxColumn SubTotal;
        private RichTextBox txtCantidad;
        private GroupBox groupBox3;
        private RadioButton radioButtonTarjeta;
        private RadioButton radiobuttonEfectivo;
        private RichTextBox rtxtbEfectivo;
        private Label lblDevolucion;
        private Label label8;
        private Label label12;
        private Label label5;
        private Button btnInsertar;
        private Button btnInhabilitar;
        private Button button1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
    }
}
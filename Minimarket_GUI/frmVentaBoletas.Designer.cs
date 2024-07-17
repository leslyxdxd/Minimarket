﻿namespace Minimarket_GUI
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
            lblTotalPagar = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            txtCantidad = new RichTextBox();
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
            groupBox3 = new GroupBox();
            radioButtonTarjeta = new RadioButton();
            radiobuttonEfectivo = new RadioButton();
            btnRegistrarBoleta = new Button();
            rtxtbEfectivo = new RichTextBox();
            lblDevolucion = new Label();
            label8 = new Label();
            label12 = new Label();
            button1 = new Button();
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
            lblTotalPagar.Location = new Point(1005, 321);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(127, 35);
            lblTotalPagar.TabIndex = 4;
            lblTotalPagar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1005, 288);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 5;
            label2.Text = "TOTAL A PAGAR";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.Location = new Point(1005, 159);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 51);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(112, 67);
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
            groupBox1.Location = new Point(28, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(957, 122);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLE DE PRODUCTO";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(853, 71);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(84, 35);
            txtCantidad.TabIndex = 24;
            txtCantidad.Text = "";
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(583, 45);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 20;
            label11.Text = "UNIDAD M.";
            // 
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.FixedSingle;
            lblStock.Location = new Point(728, 71);
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
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 18;
            label9.Text = "STOCK";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(853, 45);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 15;
            label7.Text = "CANTIDAD";
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
            label6.Location = new Point(436, 45);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 9;
            label6.Text = "PRECIO (S/.)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 42);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 42);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Codigo P.";
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
            dtgListaProductos.BackgroundColor = Color.Ivory;
            dtgListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaProductos.Columns.AddRange(new DataGridViewColumn[] { Cod_Producto, Producto, Precio, Cantidad, IGV, SubTotal });
            dtgListaProductos.GridColor = SystemColors.ButtonHighlight;
            dtgListaProductos.Location = new Point(28, 278);
            dtgListaProductos.Margin = new Padding(4, 3, 4, 3);
            dtgListaProductos.Name = "dtgListaProductos";
            dtgListaProductos.ReadOnly = true;
            dtgListaProductos.RowHeadersVisible = false;
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
            dataGridViewCellStyle1.Format = "F2";
            Precio.DefaultCellStyle = dataGridViewCellStyle1;
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
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(btnBuscarClienteDNI);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblApellidos);
            groupBox2.Controls.Add(lblNombres);
            groupBox2.Location = new Point(28, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(860, 95);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMACIÓN DEL COMPRADOR";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(49, 32);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(154, 23);
            txtDNI.TabIndex = 21;
            // 
            // btnBuscarClienteDNI
            // 
            btnBuscarClienteDNI.BackColor = SystemColors.ButtonFace;
            btnBuscarClienteDNI.BackgroundImage = Properties.Resources.lupa;
            btnBuscarClienteDNI.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarClienteDNI.Location = new Point(209, 26);
            btnBuscarClienteDNI.Name = "btnBuscarClienteDNI";
            btnBuscarClienteDNI.Size = new Size(33, 33);
            btnBuscarClienteDNI.TabIndex = 18;
            btnBuscarClienteDNI.UseVisualStyleBackColor = false;
            btnBuscarClienteDNI.Click += btnBuscarClienteDNI_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(310, 62);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 1;
            label16.Text = "APELLIDOS";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(314, 26);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 1;
            label15.Text = "NOMBRES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // lblApellidos
            // 
            lblApellidos.BorderStyle = BorderStyle.FixedSingle;
            lblApellidos.Location = new Point(398, 56);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(389, 27);
            lblApellidos.TabIndex = 17;
            lblApellidos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombres
            // 
            lblNombres.BorderStyle = BorderStyle.FixedSingle;
            lblNombres.Location = new Point(398, 19);
            lblNombres.Margin = new Padding(4, 0, 4, 0);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(389, 27);
            lblNombres.TabIndex = 17;
            lblNombres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(28, 9);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(296, 33);
            label21.TabIndex = 46;
            label21.Text = "BOLETA ELECTRONICA";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(131, 672);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(100, 22);
            lblRegistros.TabIndex = 48;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 676);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 47;
            label10.Text = "REGISTROS";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = SystemColors.Control;
            btnEliminarProducto.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarProducto.Location = new Point(1005, 218);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(127, 54);
            btnEliminarProducto.TabIndex = 49;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonTarjeta);
            groupBox3.Controls.Add(radiobuttonEfectivo);
            groupBox3.Location = new Point(894, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 95);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "METODO DE PAGO";
            // 
            // radioButtonTarjeta
            // 
            radioButtonTarjeta.AutoSize = true;
            radioButtonTarjeta.Location = new Point(111, 48);
            radioButtonTarjeta.Name = "radioButtonTarjeta";
            radioButtonTarjeta.Size = new Size(68, 19);
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
            radiobuttonEfectivo.Name = "radiobuttonEfectivo";
            radiobuttonEfectivo.Size = new Size(76, 19);
            radiobuttonEfectivo.TabIndex = 0;
            radiobuttonEfectivo.TabStop = true;
            radiobuttonEfectivo.Text = "EFECTIVO";
            radiobuttonEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarBoleta
            // 
            btnRegistrarBoleta.Location = new Point(1007, 594);
            btnRegistrarBoleta.Name = "btnRegistrarBoleta";
            btnRegistrarBoleta.Size = new Size(127, 58);
            btnRegistrarBoleta.TabIndex = 53;
            btnRegistrarBoleta.Text = "REGISTRAR COMPROBANTE";
            btnRegistrarBoleta.UseVisualStyleBackColor = true;
            btnRegistrarBoleta.Click += btnRegistrarBoleta_Click;
            // 
            // rtxtbEfectivo
            // 
            rtxtbEfectivo.Location = new Point(1006, 410);
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
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(126, 35);
            lblDevolucion.TabIndex = 55;
            lblDevolucion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1005, 386);
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
            label12.Name = "label12";
            label12.Size = new Size(114, 21);
            label12.TabIndex = 57;
            label12.Text = "DEVOLUCIÓN";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(277, 668);
            button1.Name = "button1";
            button1.Size = new Size(127, 31);
            button1.TabIndex = 58;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmVentaBoletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1157, 717);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(lblDevolucion);
            Controls.Add(rtxtbEfectivo);
            Controls.Add(btnRegistrarBoleta);
            Controls.Add(groupBox3);
            Controls.Add(btnEliminarProducto);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(lblTotalPagar);
            Controls.Add(label21);
            Controls.Add(dtgListaProductos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnAgregar;
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
        private Button btnBuscarClienteDNI;
        private TextBox txtDNI;
        private Button btnEliminarProducto;
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
        private Button btnRegistrarBoleta;
        private RichTextBox rtxtbEfectivo;
        private Label lblDevolucion;
        private Label label8;
        private Label label12;
        private Button button1;
    }
}
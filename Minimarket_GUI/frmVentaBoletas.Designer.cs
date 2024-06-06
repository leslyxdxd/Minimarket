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
            lblRegistros = new Label();
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
            dtgUsuario = new DataGridView();
            Cod_Producto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            label13 = new Label();
            label8 = new Label();
            label21 = new Label();
            label5 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuario).BeginInit();
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
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(897, 637);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(147, 35);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(897, 612);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Total a pagar";
            // 
            // button1
            // 
            button1.Location = new Point(891, 301);
            button1.Name = "button1";
            button1.Size = new Size(147, 71);
            button1.TabIndex = 6;
            button1.Text = "Agregar producto";
            button1.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(34, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1010, 122);
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
            // dtgUsuario
            // 
            dtgUsuario.AllowUserToAddRows = false;
            dtgUsuario.AllowUserToDeleteRows = false;
            dtgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuario.Columns.AddRange(new DataGridViewColumn[] { Cod_Producto, Producto, Precio, Cantidad, SubTotal });
            dtgUsuario.Location = new Point(28, 311);
            dtgUsuario.Margin = new Padding(4, 3, 4, 3);
            dtgUsuario.Name = "dtgUsuario";
            dtgUsuario.ReadOnly = true;
            dtgUsuario.RowHeadersVisible = false;
            dtgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuario.Size = new Size(778, 439);
            dtgUsuario.TabIndex = 9;
            // 
            // Cod_Producto
            // 
            Cod_Producto.HeaderText = "Cod_Producto";
            Cod_Producto.Name = "Cod_Producto";
            Cod_Producto.ReadOnly = true;
            Cod_Producto.Resizable = DataGridViewTriState.False;
            Cod_Producto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(28, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1010, 76);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información del comprador";
            groupBox2.Enter += groupBox2_Enter;
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
            // richTextBox2
            // 
            richTextBox2.Location = new Point(70, 35);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(148, 23);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // label13
            // 
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Location = new Point(642, 32);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(323, 25);
            label13.TabIndex = 17;
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(319, 30);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(222, 25);
            label8.TabIndex = 17;
            label8.TextAlign = ContentAlignment.MiddleCenter;
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
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(98, 766);
            label5.Name = "label5";
            label5.Size = new Size(78, 22);
            label5.TabIndex = 48;
            label5.TextAlign = ContentAlignment.MiddleRight;
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
            // frmVentaBoletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1074, 798);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label21);
            Controls.Add(dtgUsuario);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(button2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVentaBoletas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuario).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label lblRegistros;
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
        private DataGridView dtgUsuario;
        private DataGridViewTextBoxColumn Cod_Producto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private GroupBox groupBox2;
        private Label label1;
        private RichTextBox richTextBox2;
        private Label label13;
        private Label label8;
        private Label label16;
        private Label label15;
        private Label label21;
        private Label lblStock;
        private Label label5;
        private Label label10;
        private TextBox txtCantidad;
    }
}
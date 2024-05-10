namespace Minimarket_GUI
{
    partial class frmVentaProductos
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
            listView1 = new ListView();
            button2 = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            lblestado = new Label();
            label11 = new Label();
            lblUM = new Label();
            label9 = new Label();
            lblStock = new Label();
            txtCantidad = new TextBox();
            label7 = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblCodigo = new Label();
            lblcat = new Label();
            lbltienda = new Label();
            lblprove = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 188);
            listView1.Name = "listView1";
            listView1.Size = new Size(756, 437);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(807, 577);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 3;
            button2.Text = "Registrar comprobante";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(807, 515);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(147, 35);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(844, 475);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Total a pagar";
            // 
            // button1
            // 
            button1.Location = new Point(807, 218);
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
            groupBox1.Controls.Add(lblestado);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblUM);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(948, 122);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Producto ";
            // 
            // lblestado
            // 
            lblestado.BorderStyle = BorderStyle.FixedSingle;
            lblestado.Location = new Point(666, -21);
            lblestado.Margin = new Padding(4, 0, 4, 0);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(90, 35);
            lblestado.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(629, 42);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 20;
            label11.Text = "U.M.";
            // 
            // lblUM
            // 
            lblUM.BorderStyle = BorderStyle.FixedSingle;
            lblUM.Location = new Point(600, 71);
            lblUM.Margin = new Padding(4, 0, 4, 0);
            lblUM.Name = "lblUM";
            lblUM.Size = new Size(90, 35);
            lblUM.TabIndex = 19;
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
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.FixedSingle;
            lblStock.Location = new Point(708, 71);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 35);
            lblStock.TabIndex = 17;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.Location = new Point(832, 83);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(107, 23);
            txtCantidad.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(859, 45);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 15;
            label7.Text = "Cantidad ";
            // 
            // lblPrecio
            // 
            lblPrecio.BorderStyle = BorderStyle.FixedSingle;
            lblPrecio.Location = new Point(475, 71);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 35);
            lblPrecio.TabIndex = 14;
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(198, 71);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(252, 35);
            lblNombre.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 42);
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
            lblCodigo.Size = new Size(76, 37);
            lblCodigo.TabIndex = 8;
            lblCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblcat
            // 
            lblcat.BorderStyle = BorderStyle.FixedSingle;
            lblcat.Location = new Point(330, 9);
            lblcat.Margin = new Padding(4, 0, 4, 0);
            lblcat.Name = "lblcat";
            lblcat.Size = new Size(90, 35);
            lblcat.TabIndex = 21;
            // 
            // lbltienda
            // 
            lbltienda.BorderStyle = BorderStyle.FixedSingle;
            lbltienda.Location = new Point(440, 9);
            lbltienda.Margin = new Padding(4, 0, 4, 0);
            lbltienda.Name = "lbltienda";
            lbltienda.Size = new Size(90, 35);
            lbltienda.TabIndex = 22;
            // 
            // lblprove
            // 
            lblprove.BorderStyle = BorderStyle.FixedSingle;
            lblprove.Location = new Point(557, 9);
            lblprove.Margin = new Padding(4, 0, 4, 0);
            lblprove.Name = "lblprove";
            lblprove.Size = new Size(90, 35);
            lblprove.TabIndex = 23;
            // 
            // frmVentaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 660);
            Controls.Add(lblprove);
            Controls.Add(lbltienda);
            Controls.Add(lblcat);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(button2);
            Controls.Add(listView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVentaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
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
        private TextBox txtCantidad;
        private Label label11;
        private Label lblUM;
        private Label label9;
        private Label lblStock;
        private Label lblestado;
        private Label lblcat;
        private Label lbltienda;
        private Label lblprove;
    }
}
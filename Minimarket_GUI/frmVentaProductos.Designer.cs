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
            label7 = new Label();
            label5 = new Label();
            lblDir = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 210);
            listView1.Name = "listView1";
            listView1.Size = new Size(722, 415);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(771, 577);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 3;
            button2.Text = "Registrar comprobante";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(771, 513);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(147, 35);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(771, 489);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Total a pagar";
            // 
            // button1
            // 
            button1.Location = new Point(771, 210);
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblDir);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(13, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 122);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Producto ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(596, 49);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 15;
            label7.Text = "Cantidad ";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(477, 67);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 35);
            label5.TabIndex = 14;
            // 
            // lblDir
            // 
            lblDir.BorderStyle = BorderStyle.FixedSingle;
            lblDir.Location = new Point(198, 67);
            lblDir.Margin = new Padding(4, 0, 4, 0);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(252, 35);
            lblDir.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 42);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 9;
            label6.Text = "Precio de compra";
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
            label3.Location = new Point(23, 42);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 9;
            label3.Text = "Cod.Producto";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(23, 69);
            label1.Name = "label1";
            label1.Size = new Size(69, 35);
            label1.TabIndex = 8;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(591, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 16;
            // 
            // frmVentaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 660);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(button2);
            Controls.Add(listView1);
            Name = "frmVentaProductos";
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
        private Label lblDir;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
    }
}
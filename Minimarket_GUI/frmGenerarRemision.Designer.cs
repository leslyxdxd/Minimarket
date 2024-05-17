namespace Minimarket_GUI
{
    partial class frmGenerarRemision
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
            label14 = new Label();
            lblEstados = new Label();
            lblTel = new Label();
            label10 = new Label();
            lblRuc = new Label();
            label6 = new Label();
            label5 = new Label();
            cboProveeedor = new ComboBox();
            label1 = new Label();
            btnConsultar = new Button();
            label12 = new Label();
            label8 = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            cboProducto = new ComboBox();
            txtPrecioUni = new TextBox();
            UpdownCantidad = new NumericUpDown();
            txtObservacion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)UpdownCantidad).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(797, 126);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 16;
            label14.Text = "Estado:";
            // 
            // lblEstados
            // 
            lblEstados.BorderStyle = BorderStyle.FixedSingle;
            lblEstados.Location = new Point(850, 119);
            lblEstados.Margin = new Padding(4, 0, 4, 0);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(94, 26);
            lblEstados.TabIndex = 23;
            lblEstados.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTel
            // 
            lblTel.BorderStyle = BorderStyle.FixedSingle;
            lblTel.Location = new Point(92, 207);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(116, 26);
            lblTel.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 208);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 18;
            label10.Text = "Telefono:";
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.Location = new Point(92, 119);
            lblRuc.Margin = new Padding(4, 0, 4, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(116, 26);
            lblRuc.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 120);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 19;
            label6.Text = "RUC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 20;
            label5.Text = "Proveeedor";
            // 
            // cboProveeedor
            // 
            cboProveeedor.FormattingEnabled = true;
            cboProveeedor.Location = new Point(92, 25);
            cboProveeedor.Name = "cboProveeedor";
            cboProveeedor.Size = new Size(121, 23);
            cboProveeedor.TabIndex = 29;
            cboProveeedor.SelectedIndexChanged += cboProveeedor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 30;
            label1.Text = "Producto";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(395, 280);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(116, 42);
            btnConsultar.TabIndex = 31;
            btnConsultar.Text = "Generar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 162);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 17;
            label12.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 71);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 15;
            label8.Text = "Direccion:";
            // 
            // lblCorreo
            // 
            lblCorreo.BorderStyle = BorderStyle.FixedSingle;
            lblCorreo.Location = new Point(92, 161);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(156, 26);
            lblCorreo.TabIndex = 22;
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.Location = new Point(92, 70);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(162, 26);
            lblDireccion.TabIndex = 21;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(351, 25);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(121, 23);
            cboProducto.TabIndex = 32;
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.Location = new Point(351, 117);
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.Size = new Size(100, 23);
            txtPrecioUni.TabIndex = 33;
            // 
            // UpdownCantidad
            // 
            UpdownCantidad.Location = new Point(350, 168);
            UpdownCantidad.Name = "UpdownCantidad";
            UpdownCantidad.Size = new Size(120, 23);
            UpdownCantidad.TabIndex = 35;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(350, 214);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(161, 23);
            txtObservacion.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 37;
            label2.Text = "Observaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 38;
            label3.Text = "Precio Unitario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 39;
            label4.Text = "Cantidad";
            // 
            // frmGenerarRemision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 344);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtObservacion);
            Controls.Add(UpdownCantidad);
            Controls.Add(txtPrecioUni);
            Controls.Add(cboProducto);
            Controls.Add(btnConsultar);
            Controls.Add(label1);
            Controls.Add(cboProveeedor);
            Controls.Add(lblDireccion);
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(lblCorreo);
            Controls.Add(label12);
            Controls.Add(lblEstados);
            Controls.Add(lblTel);
            Controls.Add(label10);
            Controls.Add(lblRuc);
            Controls.Add(label6);
            Controls.Add(label5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGenerarRemision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Remision";
            Load += frmGenerarRemision_Load;
            ((System.ComponentModel.ISupportInitialize)UpdownCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private Label lblEstados;
        private Label lblTel;
        private Label label10;
        private Label lblRuc;
        private Label label6;
        private Label label5;
        private ComboBox cboProveeedor;
        private Label label1;
        private Button btnConsultar;
        private Label label12;
        private Label label8;
        private Label lblCorreo;
        private Label lblDireccion;
        private ComboBox cboProducto;
        private TextBox txtPrecioUni;
        private NumericUpDown UpdownCantidad;
        private TextBox txtObservacion;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
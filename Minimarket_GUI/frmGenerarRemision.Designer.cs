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
            lblTel = new Label();
            label10 = new Label();
            lblRuc = new Label();
            label6 = new Label();
            label5 = new Label();
            cboProveeedor = new ComboBox();
            label1 = new Label();
            label12 = new Label();
            label8 = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            cboProducto = new ComboBox();
            UpdownCantidad = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtObservacion = new RichTextBox();
            btnCancelar = new Button();
            groupBox2 = new GroupBox();
            lblMarcas = new Label();
            label22 = new Label();
            lblUnidad = new Label();
            label20 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            lblLicencia = new Label();
            cboTransportista = new ComboBox();
            Transporte = new Label();
            lblDirecTrans = new Label();
            lblRucTra = new Label();
            lblRucTrans = new Label();
            lblPlaca = new Label();
            label14 = new Label();
            lblMarca = new Label();
            label16 = new Label();
            label17 = new Label();
            groupBox4 = new GroupBox();
            txtPeso = new TextBox();
            label19 = new Label();
            label18 = new Label();
            txtLlegada = new TextBox();
            txtPartida = new TextBox();
            dtpFecFin = new DateTimePicker();
            label13 = new Label();
            label11 = new Label();
            dtpFecIni = new DateTimePicker();
            cboUm = new ComboBox();
            label7 = new Label();
            label15 = new Label();
            btnGenerar = new Button();
            txtNumeroGuia = new ComboBox();
            label3 = new Label();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)UpdownCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTel
            // 
            lblTel.BorderStyle = BorderStyle.FixedSingle;
            lblTel.Location = new Point(359, 68);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(166, 16);
            lblTel.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(296, 68);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 18;
            label10.Text = "Telefono:";
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.Location = new Point(337, 36);
            lblRuc.Margin = new Padding(4, 0, 4, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(188, 15);
            lblRuc.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 37);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 19;
            label6.Text = "RUC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 37);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 20;
            label5.Text = "Proveeedor";
            // 
            // cboProveeedor
            // 
            cboProveeedor.DropDownStyle = ComboBoxStyle.Simple;
            cboProveeedor.FormattingEnabled = true;
            cboProveeedor.Location = new Point(113, 34);
            cboProveeedor.Name = "cboProveeedor";
            cboProveeedor.Size = new Size(157, 23);
            cboProveeedor.TabIndex = 29;
            cboProveeedor.SelectionChangeCommitted += cboProveeedor_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 30;
            label1.Text = "Producto";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 69);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 17;
            label12.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 101);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 15;
            label8.Text = "Direccion:";
            // 
            // lblCorreo
            // 
            lblCorreo.BorderStyle = BorderStyle.FixedSingle;
            lblCorreo.Location = new Point(113, 68);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(157, 16);
            lblCorreo.TabIndex = 22;
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.Location = new Point(113, 100);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(216, 16);
            lblDireccion.TabIndex = 21;
            // 
            // cboProducto
            // 
            cboProducto.BackColor = SystemColors.Window;
            cboProducto.ForeColor = SystemColors.InactiveCaptionText;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(86, 37);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(129, 23);
            cboProducto.TabIndex = 32;
            cboProducto.SelectionChangeCommitted += cboProducto_SelectionChangeCommitted;
            // 
            // UpdownCantidad
            // 
            UpdownCantidad.Location = new Point(304, 36);
            UpdownCantidad.Name = "UpdownCantidad";
            UpdownCantidad.Size = new Size(120, 23);
            UpdownCantidad.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 37;
            label2.Text = "Observaciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 39;
            label4.Text = "Cantidad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboProveeedor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblRuc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblCorreo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblTel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 139);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACION PROVEEDOR";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(7, 165);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(426, 106);
            txtObservacion.TabIndex = 41;
            txtObservacion.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(848, 461);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 40);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMarcas);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(lblUnidad);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(cboProducto);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtObservacion);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(UpdownCantidad);
            groupBox2.Location = new Point(13, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 286);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMACION DEL PRODUCTO";
            // 
            // lblMarcas
            // 
            lblMarcas.BorderStyle = BorderStyle.FixedSingle;
            lblMarcas.Location = new Point(304, 90);
            lblMarcas.Margin = new Padding(4, 0, 4, 0);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(129, 16);
            lblMarcas.TabIndex = 53;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(253, 91);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(43, 15);
            label22.TabIndex = 52;
            label22.Text = "Marca:";
            // 
            // lblUnidad
            // 
            lblUnidad.BorderStyle = BorderStyle.FixedSingle;
            lblUnidad.Location = new Point(86, 88);
            lblUnidad.Margin = new Padding(4, 0, 4, 0);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(129, 16);
            lblUnidad.TabIndex = 30;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 88);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(61, 15);
            label20.TabIndex = 51;
            label20.Text = "U. Medida";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lblLicencia);
            groupBox3.Controls.Add(cboTransportista);
            groupBox3.Controls.Add(Transporte);
            groupBox3.Controls.Add(lblDirecTrans);
            groupBox3.Controls.Add(lblRucTra);
            groupBox3.Controls.Add(lblRucTrans);
            groupBox3.Controls.Add(lblPlaca);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblMarca);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Location = new Point(573, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(566, 139);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            groupBox3.Text = "INFORMACION TRANSPORTISTA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(261, 103);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 31;
            label9.Text = "N. Licencia";
            // 
            // lblLicencia
            // 
            lblLicencia.BorderStyle = BorderStyle.FixedSingle;
            lblLicencia.Location = new Point(334, 103);
            lblLicencia.Margin = new Padding(4, 0, 4, 0);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(157, 16);
            lblLicencia.TabIndex = 30;
            // 
            // cboTransportista
            // 
            cboTransportista.FormattingEnabled = true;
            cboTransportista.Location = new Point(101, 34);
            cboTransportista.Name = "cboTransportista";
            cboTransportista.Size = new Size(157, 23);
            cboTransportista.TabIndex = 29;
            cboTransportista.SelectionChangeCommitted += cboTransportista_SelectionChangeCommitted;
            // 
            // Transporte
            // 
            Transporte.AutoSize = true;
            Transporte.Location = new Point(28, 37);
            Transporte.Margin = new Padding(4, 0, 4, 0);
            Transporte.Name = "Transporte";
            Transporte.Size = new Size(62, 15);
            Transporte.TabIndex = 20;
            Transporte.Text = "Transporte";
            // 
            // lblDirecTrans
            // 
            lblDirecTrans.BorderStyle = BorderStyle.FixedSingle;
            lblDirecTrans.Location = new Point(101, 69);
            lblDirecTrans.Margin = new Padding(4, 0, 4, 0);
            lblDirecTrans.Name = "lblDirecTrans";
            lblDirecTrans.Size = new Size(175, 16);
            lblDirecTrans.TabIndex = 21;
            // 
            // lblRucTra
            // 
            lblRucTra.BorderStyle = BorderStyle.FixedSingle;
            lblRucTra.Location = new Point(323, 36);
            lblRucTra.Margin = new Padding(4, 0, 4, 0);
            lblRucTra.Name = "lblRucTra";
            lblRucTra.Size = new Size(163, 15);
            lblRucTra.TabIndex = 25;
            // 
            // lblRucTrans
            // 
            lblRucTrans.AutoSize = true;
            lblRucTrans.Location = new Point(282, 37);
            lblRucTrans.Margin = new Padding(4, 0, 4, 0);
            lblRucTrans.Name = "lblRucTrans";
            lblRucTrans.Size = new Size(33, 15);
            lblRucTrans.TabIndex = 19;
            lblRucTrans.Text = "RUC:";
            // 
            // lblPlaca
            // 
            lblPlaca.BorderStyle = BorderStyle.FixedSingle;
            lblPlaca.Location = new Point(101, 101);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(135, 16);
            lblPlaca.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 101);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 17;
            label14.Text = "Placa:";
            // 
            // lblMarca
            // 
            lblMarca.BorderStyle = BorderStyle.FixedSingle;
            lblMarca.Location = new Point(350, 69);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(159, 16);
            lblMarca.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(302, 70);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 18;
            label16.Text = "Marca";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(30, 69);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 15;
            label17.Text = "Direccion:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtPeso);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(txtLlegada);
            groupBox4.Controls.Add(txtPartida);
            groupBox4.Controls.Add(dtpFecFin);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(dtpFecIni);
            groupBox4.Controls.Add(cboUm);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label15);
            groupBox4.Location = new Point(469, 215);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(671, 220);
            groupBox4.TabIndex = 43;
            groupBox4.TabStop = false;
            groupBox4.Text = "INFORMACION DE CARGA";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 9.75F);
            txtPeso.Location = new Point(439, 34);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(84, 25);
            txtPeso.TabIndex = 49;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(334, 147);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(102, 15);
            label19.TabIndex = 48;
            label19.Text = "Punto de Llegada:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(21, 147);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(95, 15);
            label18.TabIndex = 47;
            label18.Text = "Punto de Partida";
            // 
            // txtLlegada
            // 
            txtLlegada.Font = new Font("Segoe UI", 9.75F);
            txtLlegada.Location = new Point(334, 174);
            txtLlegada.Name = "txtLlegada";
            txtLlegada.Size = new Size(312, 25);
            txtLlegada.TabIndex = 46;
            // 
            // txtPartida
            // 
            txtPartida.Font = new Font("Segoe UI", 9.75F);
            txtPartida.Location = new Point(21, 174);
            txtPartida.Name = "txtPartida";
            txtPartida.Size = new Size(266, 25);
            txtPartida.TabIndex = 45;
            // 
            // dtpFecFin
            // 
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(439, 86);
            dtpFecFin.Margin = new Padding(4, 3, 4, 3);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(148, 23);
            dtpFecFin.TabIndex = 44;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 41);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 40;
            label13.Text = "U. Medida Peso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(319, 92);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 43;
            label11.Text = "Fecha de Llegada:";
            // 
            // dtpFecIni
            // 
            dtpFecIni.Format = DateTimePickerFormat.Short;
            dtpFecIni.Location = new Point(124, 86);
            dtpFecIni.Margin = new Padding(4, 3, 4, 3);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(157, 23);
            dtpFecIni.TabIndex = 42;
            // 
            // cboUm
            // 
            cboUm.BackColor = SystemColors.Window;
            cboUm.ForeColor = SystemColors.InactiveCaptionText;
            cboUm.FormattingEnabled = true;
            cboUm.Location = new Point(124, 38);
            cboUm.Name = "cboUm";
            cboUm.Size = new Size(171, 23);
            cboUm.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 40);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 30;
            label7.Text = "Peso de carga:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 92);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(97, 15);
            label15.TabIndex = 41;
            label15.Text = "Fecha de Partida:";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(999, 461);
            btnGenerar.Margin = new Padding(4, 3, 4, 3);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(116, 40);
            btnGenerar.TabIndex = 44;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtNumeroGuia
            // 
            txtNumeroGuia.DropDownStyle = ComboBoxStyle.Simple;
            txtNumeroGuia.FormattingEnabled = true;
            txtNumeroGuia.Location = new Point(962, 24);
            txtNumeroGuia.Name = "txtNumeroGuia";
            txtNumeroGuia.Size = new Size(144, 23);
            txtNumeroGuia.TabIndex = 30;
            txtNumeroGuia.KeyPress += txtNumeroGuia_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(884, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 30;
            label3.Text = "Nº GUIA :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(6, 9);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(255, 37);
            label21.TabIndex = 45;
            label21.Text = " GUIA DE REMISION";
            // 
            // frmGenerarRemision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 535);
            Controls.Add(label21);
            Controls.Add(label3);
            Controls.Add(txtNumeroGuia);
            Controls.Add(btnGenerar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGenerarRemision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Remision";
            Load += frmGenerarRemision_Load;
            ((System.ComponentModel.ISupportInitialize)UpdownCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTel;
        private Label label10;
        private Label lblRuc;
        private Label label6;
        private Label label5;
        private ComboBox cboProveeedor;
        private Label label1;
        private Label label12;
        private Label label8;
        private Label lblCorreo;
        private Label lblDireccion;
        private ComboBox cboProducto;
        private NumericUpDown UpdownCantidad;
        private Label label2;
        private Label label4;
        private GroupBox groupBox1;
        private RichTextBox txtObservacion;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cboTransportista;
        private Label Transporte;
        private Label lblDirecTrans;
        private Label lblRucTra;
        private Label lblRucTrans;
        private Label lblPlaca;
        private Label label14;
        private Label lblMarca;
        private Label label16;
        private Label label17;
        private Label lblLicencia;
        private Label label9;
        private GroupBox groupBox4;
        private Label label13;
        private ComboBox cboUm;
        private Label label7;
        private DateTimePicker dtpFecFin;
        private Label label11;
        private DateTimePicker dtpFecIni;
        private Label label15;
        private Label label19;
        private Label label18;
        private TextBox txtLlegada;
        private TextBox txtPartida;
        private TextBox txtPeso;
        private Label label20;
        private Label label22;
        private Label lblUnidad;
        private Label lblMarcas;
        private Button btnGenerar;
        private ComboBox txtNumeroGuia;
        private Label label3;
        private Label label21;
    }
}
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
            cboProveedor = new ComboBox();
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
            txtNumeroGuia = new ComboBox();
            label3 = new Label();
            label23 = new Label();
            button1 = new Button();
            btnInsertar = new Button();
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
            lblTel.Font = new Font("Century Gothic", 9F);
            lblTel.Location = new Point(388, 107);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(166, 29);
            lblTel.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(295, 108);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 13);
            label10.TabIndex = 18;
            label10.Text = "Telefono:";
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.Font = new Font("Century Gothic", 9F);
            lblRuc.Location = new Point(381, 41);
            lblRuc.Margin = new Padding(4, 0, 4, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(166, 29);
            lblRuc.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 41);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 13);
            label6.TabIndex = 19;
            label6.Text = "RUC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 41);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 13);
            label5.TabIndex = 20;
            label5.Text = "Proveeedor";
            // 
            // cboProveedor
            // 
            cboProveedor.BackColor = SystemColors.ControlLight;
            cboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Items.AddRange(new object[] { "---Seleccione---" });
            cboProveedor.Location = new Point(123, 38);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(157, 21);
            cboProveedor.TabIndex = 29;
            cboProveedor.SelectionChangeCommitted += cboProveeedor_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 13);
            label1.TabIndex = 30;
            label1.Text = "Producto";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(48, 107);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(45, 13);
            label12.TabIndex = 17;
            label12.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 169);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 13);
            label8.TabIndex = 15;
            label8.Text = "Direccion:";
            // 
            // lblCorreo
            // 
            lblCorreo.BorderStyle = BorderStyle.FixedSingle;
            lblCorreo.Font = new Font("Century Gothic", 9F);
            lblCorreo.Location = new Point(123, 101);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(157, 29);
            lblCorreo.TabIndex = 22;
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.Font = new Font("Century Gothic", 9F);
            lblDireccion.Location = new Point(123, 163);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(216, 29);
            lblDireccion.TabIndex = 21;
            // 
            // cboProducto
            // 
            cboProducto.BackColor = SystemColors.ControlLight;
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.Font = new Font("Century Gothic", 9F);
            cboProducto.ForeColor = SystemColors.InactiveCaptionText;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(95, 41);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(129, 25);
            cboProducto.TabIndex = 32;
            cboProducto.SelectionChangeCommitted += cboProducto_SelectionChangeCommitted;
            // 
            // UpdownCantidad
            // 
            UpdownCantidad.Font = new Font("Century Gothic", 9F);
            UpdownCantidad.Location = new Point(324, 40);
            UpdownCantidad.Name = "UpdownCantidad";
            UpdownCantidad.Size = new Size(120, 22);
            UpdownCantidad.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 13);
            label2.TabIndex = 37;
            label2.Text = "Observaciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 46);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 13);
            label4.TabIndex = 39;
            label4.Text = "Cantidad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboProveedor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblRuc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblCorreo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblTel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 8F);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 208);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACION PROVEEDOR";
            // 
            // txtObservacion
            // 
            txtObservacion.BackColor = SystemColors.ControlLight;
            txtObservacion.Font = new Font("Century Gothic", 9F);
            txtObservacion.Location = new Point(18, 185);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(426, 120);
            txtObservacion.TabIndex = 41;
            txtObservacion.Text = "";
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
            groupBox2.Font = new Font("Segoe UI", 8F);
            groupBox2.Location = new Point(13, 339);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 319);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMACION DEL PRODUCTO";
            // 
            // lblMarcas
            // 
            lblMarcas.BorderStyle = BorderStyle.FixedSingle;
            lblMarcas.Font = new Font("Century Gothic", 9F);
            lblMarcas.Location = new Point(324, 104);
            lblMarcas.Margin = new Padding(4, 0, 4, 0);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(129, 29);
            lblMarcas.TabIndex = 53;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(253, 103);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(41, 13);
            label22.TabIndex = 52;
            label22.Text = "Marca:";
            // 
            // lblUnidad
            // 
            lblUnidad.BorderStyle = BorderStyle.FixedSingle;
            lblUnidad.Font = new Font("Century Gothic", 9F);
            lblUnidad.Location = new Point(95, 102);
            lblUnidad.Margin = new Padding(4, 0, 4, 0);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(129, 29);
            lblUnidad.TabIndex = 30;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 100);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(60, 13);
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
            groupBox3.Font = new Font("Segoe UI", 8F);
            groupBox3.Location = new Point(585, 109);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(560, 208);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            groupBox3.Text = "INFORMACION TRANSPORTISTA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 156);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 13);
            label9.TabIndex = 31;
            label9.Text = "N. Licencia";
            // 
            // lblLicencia
            // 
            lblLicencia.BorderStyle = BorderStyle.FixedSingle;
            lblLicencia.Font = new Font("Century Gothic", 9F);
            lblLicencia.Location = new Point(380, 149);
            lblLicencia.Margin = new Padding(4, 0, 4, 0);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(157, 29);
            lblLicencia.TabIndex = 30;
            // 
            // cboTransportista
            // 
            cboTransportista.BackColor = SystemColors.ControlLight;
            cboTransportista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransportista.FormattingEnabled = true;
            cboTransportista.Location = new Point(110, 36);
            cboTransportista.Name = "cboTransportista";
            cboTransportista.Size = new Size(157, 21);
            cboTransportista.TabIndex = 29;
            cboTransportista.SelectionChangeCommitted += cboTransportista_SelectionChangeCommitted;
            // 
            // Transporte
            // 
            Transporte.AutoSize = true;
            Transporte.Location = new Point(20, 39);
            Transporte.Margin = new Padding(4, 0, 4, 0);
            Transporte.Name = "Transporte";
            Transporte.Size = new Size(62, 13);
            Transporte.TabIndex = 20;
            Transporte.Text = "Transporte";
            // 
            // lblDirecTrans
            // 
            lblDirecTrans.BorderStyle = BorderStyle.FixedSingle;
            lblDirecTrans.Font = new Font("Century Gothic", 9F);
            lblDirecTrans.Location = new Point(110, 95);
            lblDirecTrans.Margin = new Padding(4, 0, 4, 0);
            lblDirecTrans.Name = "lblDirecTrans";
            lblDirecTrans.Size = new Size(175, 29);
            lblDirecTrans.TabIndex = 1;
            // 
            // lblRucTra
            // 
            lblRucTra.BorderStyle = BorderStyle.FixedSingle;
            lblRucTra.Font = new Font("Century Gothic", 9F);
            lblRucTra.Location = new Point(383, 38);
            lblRucTra.Margin = new Padding(4, 0, 4, 0);
            lblRucTra.Name = "lblRucTra";
            lblRucTra.Size = new Size(163, 29);
            lblRucTra.TabIndex = 25;
            // 
            // lblRucTrans
            // 
            lblRucTrans.AutoSize = true;
            lblRucTrans.Location = new Point(309, 41);
            lblRucTrans.Margin = new Padding(4, 0, 4, 0);
            lblRucTrans.Name = "lblRucTrans";
            lblRucTrans.Size = new Size(32, 13);
            lblRucTrans.TabIndex = 19;
            lblRucTrans.Text = "RUC:";
            // 
            // lblPlaca
            // 
            lblPlaca.BorderStyle = BorderStyle.FixedSingle;
            lblPlaca.Font = new Font("Century Gothic", 9F);
            lblPlaca.Location = new Point(110, 155);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(135, 29);
            lblPlaca.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 164);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(36, 13);
            label14.TabIndex = 17;
            label14.Text = "Placa:";
            // 
            // lblMarca
            // 
            lblMarca.BorderStyle = BorderStyle.FixedSingle;
            lblMarca.Font = new Font("Century Gothic", 9F);
            lblMarca.Location = new Point(383, 95);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(159, 29);
            lblMarca.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(303, 102);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(38, 13);
            label16.TabIndex = 18;
            label16.Text = "Marca";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(24, 102);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(58, 13);
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
            groupBox4.Font = new Font("Segoe UI", 8F);
            groupBox4.Location = new Point(503, 339);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(643, 270);
            groupBox4.TabIndex = 43;
            groupBox4.TabStop = false;
            groupBox4.Text = "INFORMACION DE CARGA";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Century Gothic", 9F);
            txtPeso.Location = new Point(480, 38);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(84, 22);
            txtPeso.TabIndex = 49;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(320, 167);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(100, 13);
            label19.TabIndex = 48;
            label19.Text = "Punto de Llegada:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(19, 156);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(93, 13);
            label18.TabIndex = 47;
            label18.Text = "Punto de Partida";
            // 
            // txtLlegada
            // 
            txtLlegada.Font = new Font("Century Gothic", 9F);
            txtLlegada.Location = new Point(320, 199);
            txtLlegada.Name = "txtLlegada";
            txtLlegada.Size = new Size(268, 22);
            txtLlegada.TabIndex = 46;
            // 
            // txtPartida
            // 
            txtPartida.Font = new Font("Century Gothic", 9F);
            txtPartida.Location = new Point(19, 199);
            txtPartida.Name = "txtPartida";
            txtPartida.Size = new Size(266, 22);
            txtPartida.TabIndex = 45;
            // 
            // dtpFecFin
            // 
            dtpFecFin.Font = new Font("Century Gothic", 9F);
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(480, 99);
            dtpFecFin.Margin = new Padding(4, 3, 4, 3);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(148, 22);
            dtpFecFin.TabIndex = 44;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 47);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(87, 13);
            label13.TabIndex = 40;
            label13.Text = "U. Medida Peso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(334, 105);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 13);
            label11.TabIndex = 43;
            label11.Text = "Fecha de Llegada:";
            // 
            // dtpFecIni
            // 
            dtpFecIni.Font = new Font("Century Gothic", 9F);
            dtpFecIni.Format = DateTimePickerFormat.Short;
            dtpFecIni.Location = new Point(151, 99);
            dtpFecIni.Margin = new Padding(4, 3, 4, 3);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(157, 22);
            dtpFecIni.TabIndex = 42;
            // 
            // cboUm
            // 
            cboUm.BackColor = SystemColors.ControlLight;
            cboUm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUm.Font = new Font("Century Gothic", 9F);
            cboUm.ForeColor = SystemColors.InactiveCaptionText;
            cboUm.FormattingEnabled = true;
            cboUm.Location = new Point(151, 44);
            cboUm.Name = "cboUm";
            cboUm.Size = new Size(171, 25);
            cboUm.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 45);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 13);
            label7.TabIndex = 30;
            label7.Text = "Peso de carga:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 104);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(95, 13);
            label15.TabIndex = 41;
            label15.Text = "Fecha de Partida:";
            // 
            // txtNumeroGuia
            // 
            txtNumeroGuia.DropDownStyle = ComboBoxStyle.Simple;
            txtNumeroGuia.FormattingEnabled = true;
            txtNumeroGuia.Location = new Point(968, 34);
            txtNumeroGuia.MaxLength = 10;
            txtNumeroGuia.Name = "txtNumeroGuia";
            txtNumeroGuia.Size = new Size(144, 27);
            txtNumeroGuia.TabIndex = 30;
            txtNumeroGuia.KeyPress += txtNumeroGuia_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(882, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 30;
            label3.Text = "Nº GUIA :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(64, 64, 64);
            label23.Location = new Point(12, 20);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(399, 32);
            label23.TabIndex = 60;
            label23.Text = "GUIA DE REMISIÓN REMITENTE";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(983, 638);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(161, 55);
            button1.TabIndex = 61;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.Teal;
            btnInsertar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(749, 638);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(211, 55);
            btnInsertar.TabIndex = 62;
            btnInsertar.Text = "Generar Remision";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnGenerar_Click;
            // 
            // frmGenerarRemision
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1157, 717);
            Controls.Add(btnInsertar);
            Controls.Add(button1);
            Controls.Add(label23);
            Controls.Add(label3);
            Controls.Add(txtNumeroGuia);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 9F);
            FormBorderStyle = FormBorderStyle.None;
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
        private ComboBox txtNumeroGuia;
        private Label label3;
        private ComboBox cboProveedor;
        private Label label23;
        internal Button button1;
        private Button btnInsertar;
    }
}
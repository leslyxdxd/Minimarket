namespace ProyVentas_GUI
{
    partial class frmGuiaRemision
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label3 = new Label();
            dtpFecIni = new DateTimePicker();
            dtpFecFin = new DateTimePicker();
            btnDetalleGuia = new Button();
            lblRegistros = new Label();
            label4 = new Label();
            dtgFacturas = new DataGridView();
            Num_fac = new DataGridViewTextBoxColumn();
            Fec_fac = new DataGridViewTextBoxColumn();
            Fec_can = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label5 = new Label();
            lblNombre = new Label();
            label6 = new Label();
            lblRuc = new Label();
            label8 = new Label();
            lblDireccion = new Label();
            label10 = new Label();
            lblTel = new Label();
            label12 = new Label();
            lblCorreo = new Label();
            label14 = new Label();
            lblEstados = new Label();
            lblCodigo = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Fin:";
            // 
            // dtpFecIni
            // 
            dtpFecIni.Format = DateTimePickerFormat.Short;
            dtpFecIni.Location = new Point(166, 173);
            dtpFecIni.Margin = new Padding(4, 3, 4, 3);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(148, 23);
            dtpFecIni.TabIndex = 3;
            // 
            // dtpFecFin
            // 
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(471, 173);
            dtpFecFin.Margin = new Padding(4, 3, 4, 3);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(148, 23);
            dtpFecFin.TabIndex = 5;
            // 
            // btnDetalleGuia
            // 
            btnDetalleGuia.Location = new Point(742, 165);
            btnDetalleGuia.Margin = new Padding(4, 3, 4, 3);
            btnDetalleGuia.Name = "btnDetalleGuia";
            btnDetalleGuia.Size = new Size(138, 42);
            btnDetalleGuia.TabIndex = 6;
            btnDetalleGuia.Text = "Detalles de Guias de remision";
            btnDetalleGuia.UseVisualStyleBackColor = true;
            btnDetalleGuia.Click += btnConsultar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(856, 498);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(57, 26);
            lblRegistros.TabIndex = 9;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(790, 504);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Registros:";
            // 
            // dtgFacturas
            // 
            dtgFacturas.AllowUserToAddRows = false;
            dtgFacturas.AllowUserToDeleteRows = false;
            dtgFacturas.Anchor = AnchorStyles.None;
            dtgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFacturas.Columns.AddRange(new DataGridViewColumn[] { Num_fac, Fec_fac, Fec_can, Total, Estado });
            dtgFacturas.Location = new Point(27, 235);
            dtgFacturas.Margin = new Padding(4, 3, 4, 3);
            dtgFacturas.Name = "dtgFacturas";
            dtgFacturas.ReadOnly = true;
            dtgFacturas.RowHeadersVisible = false;
            dtgFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgFacturas.Size = new Size(878, 245);
            dtgFacturas.TabIndex = 7;
            // 
            // Num_fac
            // 
            Num_fac.DataPropertyName = "num_fac";
            Num_fac.HeaderText = "Nro. Factura";
            Num_fac.Name = "Num_fac";
            Num_fac.ReadOnly = true;
            // 
            // Fec_fac
            // 
            Fec_fac.DataPropertyName = "Fec_fac";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "d";
            Fec_fac.DefaultCellStyle = dataGridViewCellStyle1;
            Fec_fac.HeaderText = "Fec. Facturacion";
            Fec_fac.Name = "Fec_fac";
            Fec_fac.ReadOnly = true;
            // 
            // Fec_can
            // 
            Fec_can.DataPropertyName = "fec_can";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            Fec_can.DefaultCellStyle = dataGridViewCellStyle2;
            Fec_can.HeaderText = "Fec. Cancelacion";
            Fec_can.Name = "Fec_can";
            Fec_can.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            Total.DefaultCellStyle = dataGridViewCellStyle3;
            Total.HeaderText = "Total (S/.)";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 11;
            label5.Text = "Razon social:";
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(292, 16);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(534, 26);
            lblNombre.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 57);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 11;
            label6.Text = "RUC:";
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.Location = new Point(68, 56);
            lblRuc.Margin = new Padding(4, 0, 4, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(116, 26);
            lblRuc.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 57);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 11;
            label8.Text = "Direccion:";
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.Location = new Point(280, 57);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(642, 26);
            lblDireccion.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 109);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 11;
            label10.Text = "Telefono:";
            // 
            // lblTel
            // 
            lblTel.BorderStyle = BorderStyle.FixedSingle;
            lblTel.Location = new Point(76, 102);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(94, 26);
            lblTel.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(205, 103);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 11;
            label12.Text = "Correo:";
            // 
            // lblCorreo
            // 
            lblCorreo.BorderStyle = BorderStyle.FixedSingle;
            lblCorreo.Location = new Point(280, 102);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(473, 26);
            lblCorreo.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(773, 109);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 11;
            label14.Text = "Estado:";
            // 
            // lblEstados
            // 
            lblEstados.BorderStyle = BorderStyle.FixedSingle;
            lblEstados.Location = new Point(831, 103);
            lblEstados.Margin = new Padding(4, 0, 4, 0);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(94, 26);
            lblEstados.TabIndex = 12;
            lblEstados.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(90, 19);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 14;
            label1.Text = "Codigo";
            // 
            // frmGuiaRemision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 532);
            Controls.Add(label1);
            Controls.Add(lblCodigo);
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
            Controls.Add(lblNombre);
            Controls.Add(label5);
            Controls.Add(dtgFacturas);
            Controls.Add(lblRegistros);
            Controls.Add(label4);
            Controls.Add(btnDetalleGuia);
            Controls.Add(dtpFecFin);
            Controls.Add(dtpFecIni);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(954, 571);
            MinimumSize = new Size(907, 548);
            Name = "frmGuiaRemision";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guia de Remision";
            Load += frmConsFacturasCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Button btnDetalleGuia;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_can;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEstados;
        private Label lblCodigo;
        private Label label1;
    }
}
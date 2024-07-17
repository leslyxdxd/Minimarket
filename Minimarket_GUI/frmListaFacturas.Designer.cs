namespace Minimarket_GUI
{
    partial class frmListaFacturas
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
            btnCerrar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgDatos = new DataGridView();
            Numero_Factura = new DataGridViewTextBoxColumn();
            Id_Factura = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Ruc = new DataGridViewTextBoxColumn();
            Fec_Factura = new DataGridViewTextBoxColumn();
            Usu_Registro = new DataGridViewTextBoxColumn();
            btnTraspaso = new Button();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(975, 628);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(151, 49);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(101, 645);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(167, 22);
            lblRegistros.TabIndex = 14;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 645);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "Facturas:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(121, 94);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(189, 23);
            txtFiltro.TabIndex = 12;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 97);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 11;
            label1.Text = "Filtro / RUC";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AllowUserToResizeColumns = false;
            dtgDatos.AllowUserToResizeRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.BackgroundColor = SystemColors.ControlLight;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Numero_Factura, Id_Factura, RazonSocial, Ruc, Fec_Factura, Usu_Registro });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgDatos.DefaultCellStyle = dataGridViewCellStyle1;
            dtgDatos.Location = new Point(26, 145);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1100, 452);
            dtgDatos.TabIndex = 10;
            // 
            // Numero_Factura
            // 
            Numero_Factura.DataPropertyName = "Numero_Factura";
            Numero_Factura.HeaderText = "N°. Factura";
            Numero_Factura.Name = "Numero_Factura";
            Numero_Factura.ReadOnly = true;
            // 
            // Id_Factura
            // 
            Id_Factura.DataPropertyName = "Id_Factura";
            Id_Factura.HeaderText = "Id_Factura";
            Id_Factura.Name = "Id_Factura";
            Id_Factura.ReadOnly = true;
            Id_Factura.Visible = false;
            // 
            // RazonSocial
            // 
            RazonSocial.DataPropertyName = "RazonSocial";
            RazonSocial.HeaderText = "RazonSocial";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // Ruc
            // 
            Ruc.DataPropertyName = "Ruc";
            Ruc.HeaderText = "Ruc";
            Ruc.Name = "Ruc";
            Ruc.ReadOnly = true;
            // 
            // Fec_Factura
            // 
            Fec_Factura.DataPropertyName = "Fec_Factura";
            Fec_Factura.HeaderText = "Fecha Facturada";
            Fec_Factura.Name = "Fec_Factura";
            Fec_Factura.ReadOnly = true;
            // 
            // Usu_Registro
            // 
            Usu_Registro.DataPropertyName = "Usu_Registro";
            Usu_Registro.HeaderText = "Usuario Registro";
            Usu_Registro.Name = "Usu_Registro";
            Usu_Registro.ReadOnly = true;
            // 
            // btnTraspaso
            // 
            btnTraspaso.Location = new Point(791, 628);
            btnTraspaso.Name = "btnTraspaso";
            btnTraspaso.Size = new Size(166, 49);
            btnTraspaso.TabIndex = 16;
            btnTraspaso.Text = "Ver detalle";
            btnTraspaso.UseVisualStyleBackColor = true;
            btnTraspaso.Click += btnTraspaso_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(26, 32);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(147, 32);
            label21.TabIndex = 56;
            label21.Text = "FACTURAS";
            // 
            // frmListaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1157, 717);
            Controls.Add(label21);
            Controls.Add(btnTraspaso);
            Controls.Add(btnCerrar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturas";
            Load += frmListaFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Label lblRegistros;
        private Label label2;
        private TextBox txtFiltro;
        private Label label1;
        private DataGridView dtgDatos;
        private Button btnTraspaso;
        private DataGridViewTextBoxColumn Numero_Factura;
        private DataGridViewTextBoxColumn Id_Factura;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Ruc;
        private DataGridViewTextBoxColumn Fec_Factura;
        private DataGridViewTextBoxColumn Usu_Registro;
        private Label label21;
    }
}
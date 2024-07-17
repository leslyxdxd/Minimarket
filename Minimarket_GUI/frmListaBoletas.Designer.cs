namespace Minimarket_GUI
{
    partial class frmListaBoletas
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnTraspaso = new Button();
            btnCerrar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgDatos = new DataGridView();
            Numero_Factura = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Fec_Factura = new DataGridViewTextBoxColumn();
            Ruc = new DataGridViewTextBoxColumn();
            Id_Boleta = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Usu_Registro = new DataGridViewTextBoxColumn();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // btnTraspaso
            // 
            btnTraspaso.Location = new Point(781, 641);
            btnTraspaso.Name = "btnTraspaso";
            btnTraspaso.Size = new Size(149, 46);
            btnTraspaso.TabIndex = 23;
            btnTraspaso.Text = "Ver detalle";
            btnTraspaso.UseVisualStyleBackColor = true;
            btnTraspaso.Click += btnTraspaso_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(982, 641);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(145, 46);
            btnCerrar.TabIndex = 22;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(91, 651);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 21;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 655);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 20;
            label2.Text = "Boletas:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(115, 89);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(242, 23);
            txtFiltro.TabIndex = 19;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 92);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 18;
            label1.Text = "Filtro / DNI:";
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
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Numero_Factura, RazonSocial, Fec_Factura, Ruc, Id_Boleta, Fecha, Usu_Registro });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgDatos.DefaultCellStyle = dataGridViewCellStyle5;
            dtgDatos.Location = new Point(23, 150);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1104, 466);
            dtgDatos.TabIndex = 17;
            // 
            // Numero_Factura
            // 
            Numero_Factura.DataPropertyName = "Nro_Boleta";
            Numero_Factura.HeaderText = "N°. Boleta";
            Numero_Factura.Name = "Numero_Factura";
            Numero_Factura.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.DataPropertyName = "Nombres_Cliente";
            RazonSocial.HeaderText = "Nombres";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // Fec_Factura
            // 
            Fec_Factura.DataPropertyName = "Apellidos_Cliente";
            Fec_Factura.HeaderText = "Apellidos";
            Fec_Factura.Name = "Fec_Factura";
            Fec_Factura.ReadOnly = true;
            // 
            // Ruc
            // 
            Ruc.DataPropertyName = "Dni_Cliente";
            Ruc.HeaderText = "DNI";
            Ruc.Name = "Ruc";
            Ruc.ReadOnly = true;
            // 
            // Id_Boleta
            // 
            Id_Boleta.DataPropertyName = "Id_Boleta";
            Id_Boleta.HeaderText = "Id_Factura";
            Id_Boleta.Name = "Id_Boleta";
            Id_Boleta.ReadOnly = true;
            Id_Boleta.Visible = false;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Usu_Registro
            // 
            Usu_Registro.DataPropertyName = "Usu_Registro";
            Usu_Registro.HeaderText = "Usuario Registro";
            Usu_Registro.Name = "Usu_Registro";
            Usu_Registro.ReadOnly = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(23, 22);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(124, 32);
            label21.TabIndex = 56;
            label21.Text = "BOLETAS";
            // 
            // frmListaBoletas
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
            Name = "frmListaBoletas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Boletas";
            Load += frmListaBoletas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTraspaso;
        private Button btnCerrar;
        private Label lblRegistros;
        private Label label2;
        private TextBox txtFiltro;
        private Label label1;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Id_Factura;
        private DataGridViewTextBoxColumn Numero_Factura;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Fec_Factura;
        private DataGridViewTextBoxColumn Ruc;
        private DataGridViewTextBoxColumn Id_Boleta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Usu_Registro;
        private Label label21;
    }
}
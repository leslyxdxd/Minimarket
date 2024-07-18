namespace Minimarket_GUI
{
    partial class frmBoletas
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
            lblRegistros = new Label();
            label2 = new Label();
            dtgDatos = new DataGridView();
            Numero_Factura = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Fec_Factura = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(82, 271);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 11;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 275);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 12;
            label2.Text = "Productos:";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AllowUserToResizeColumns = false;
            dtgDatos.AllowUserToResizeRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.BackgroundColor = SystemColors.ControlLight;
            dtgDatos.BorderStyle = BorderStyle.Fixed3D;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Numero_Factura, RazonSocial, Column1, Column2, Column3, Cantidad, Column6, Column5, Column4, Fec_Factura });
            dtgDatos.Location = new Point(12, 12);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(933, 222);
            dtgDatos.TabIndex = 9;
            // 
            // Numero_Factura
            // 
            Numero_Factura.DataPropertyName = "Numero_Factura";
            Numero_Factura.HeaderText = "N. Factura";
            Numero_Factura.Name = "Numero_Factura";
            Numero_Factura.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.DataPropertyName = "RazonSocial";
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Nom_Producto";
            Column1.HeaderText = "Producto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Marca";
            Column2.HeaderText = "Marca";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Des_UM";
            Column3.HeaderText = "UM";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "subtotal";
            Column6.HeaderText = "Subtotal";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "igv";
            Column5.HeaderText = "IGV";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Total";
            Column4.HeaderText = "Total";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Fec_Factura
            // 
            Fec_Factura.DataPropertyName = "Fec_Factura";
            Fec_Factura.HeaderText = "Fecha Facturada";
            Fec_Factura.Name = "Fec_Factura";
            Fec_Factura.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(803, 251);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(142, 45);
            button1.TabIndex = 63;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCerrar_Click;
            // 
            // frmBoletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 308);
            Controls.Add(button1);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBoletas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Boletas";
            Load += frmBoletas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Numero_Factura;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Fec_Factura;
        internal Button button1;
    }
}
﻿namespace Minimarket_GUI
{
    partial class frmListaProductos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtgDatos = new DataGridView();
            Nom_Producto = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Precio_Unitario = new DataGridViewTextBoxColumn();
            Id_Stock = new DataGridViewTextBoxColumn();
            Stk_Trastienda = new DataGridViewTextBoxColumn();
            Movimiento_Tras = new DataGridViewTextBoxColumn();
            Id_Producto = new DataGridViewTextBoxColumn();
            Stk_Tienda = new DataGridViewTextBoxColumn();
            Id_UM = new DataGridViewTextBoxColumn();
            Des_UM = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            label21 = new Label();
            btnFiltrar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
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
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Nom_Producto, Estado, Precio_Unitario, Id_Stock, Stk_Trastienda, Movimiento_Tras, Id_Producto, Stk_Tienda, Id_UM, Des_UM });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgDatos.Location = new Point(27, 132);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1091, 398);
            dtgDatos.TabIndex = 1;
            dtgDatos.CellDoubleClick += dtgDatos_CellDoubleClick;
            // 
            // Nom_Producto
            // 
            Nom_Producto.DataPropertyName = "Nom_Producto";
            Nom_Producto.HeaderText = "Producto";
            Nom_Producto.Name = "Nom_Producto";
            Nom_Producto.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Visible = false;
            // 
            // Precio_Unitario
            // 
            Precio_Unitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle1.Format = "N2";
            Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle1;
            Precio_Unitario.HeaderText = "Precio U. (Venta)";
            Precio_Unitario.Name = "Precio_Unitario";
            Precio_Unitario.ReadOnly = true;
            // 
            // Id_Stock
            // 
            Id_Stock.DataPropertyName = "Id_Stock";
            Id_Stock.HeaderText = "Cod_Stock";
            Id_Stock.Name = "Id_Stock";
            Id_Stock.ReadOnly = true;
            Id_Stock.Visible = false;
            // 
            // Stk_Trastienda
            // 
            Stk_Trastienda.DataPropertyName = "Stk_Trastienda";
            Stk_Trastienda.HeaderText = "Stock Trastienda";
            Stk_Trastienda.Name = "Stk_Trastienda";
            Stk_Trastienda.ReadOnly = true;
            // 
            // Movimiento_Tras
            // 
            Movimiento_Tras.DataPropertyName = "Movimiento_Tras";
            Movimiento_Tras.HeaderText = "Transaccion_Tienda";
            Movimiento_Tras.Name = "Movimiento_Tras";
            Movimiento_Tras.ReadOnly = true;
            Movimiento_Tras.Visible = false;
            // 
            // Id_Producto
            // 
            Id_Producto.DataPropertyName = "Id_Producto";
            Id_Producto.HeaderText = "Id_Producto";
            Id_Producto.Name = "Id_Producto";
            Id_Producto.ReadOnly = true;
            Id_Producto.Visible = false;
            // 
            // Stk_Tienda
            // 
            Stk_Tienda.DataPropertyName = "Stk_Tienda";
            Stk_Tienda.HeaderText = "Stock Tienda";
            Stk_Tienda.Name = "Stk_Tienda";
            Stk_Tienda.ReadOnly = true;
            // 
            // Id_UM
            // 
            Id_UM.DataPropertyName = "Id_UM";
            Id_UM.HeaderText = "Cod. U.Medida";
            Id_UM.Name = "Id_UM";
            Id_UM.ReadOnly = true;
            Id_UM.Visible = false;
            // 
            // Des_UM
            // 
            Des_UM.DataPropertyName = "Des_UM";
            Des_UM.HeaderText = "U.Medida";
            Des_UM.Name = "Des_UM";
            Des_UM.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 98);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Filtro / Nombre:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(153, 95);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(220, 23);
            txtFiltro.TabIndex = 4;
            txtFiltro.TextChanged += txtFiltro_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 557);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Productos:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(110, 553);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 6;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(27, 37);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(274, 32);
            label21.TabIndex = 54;
            label21.Text = "PRODUCTOS TIENDA";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.SteelBlue;
            btnFiltrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(749, 563);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(163, 48);
            btnFiltrar.TabIndex = 55;
            btnFiltrar.Text = "Traspasar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnTraspaso_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(967, 563);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(151, 48);
            btnCancelar.TabIndex = 59;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCerrar_Click;
            // 
            // frmListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1157, 634);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(label21);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos Tienda";
            Load += frmListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Nom_Producto;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Precio_Unitario;
        private DataGridViewTextBoxColumn Id_Stock;
        private DataGridViewTextBoxColumn Stk_Trastienda;
        private DataGridViewTextBoxColumn Movimiento_Tras;
        private DataGridViewTextBoxColumn Id_Producto;
        private DataGridViewTextBoxColumn Stk_Tienda;
        private DataGridViewTextBoxColumn Id_UM;
        private DataGridViewTextBoxColumn Des_UM;
        private Label label21;
        private Button btnFiltrar;
        internal Button btnCancelar;
    }
}
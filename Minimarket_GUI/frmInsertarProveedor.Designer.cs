namespace Minimarket_GUI
{
    partial class frmInsertarProveedor
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
            label12 = new Label();
            label8 = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            lblLicencia = new Label();
            Transporte = new Label();
            lblDirecTrans = new Label();
            lblRucTra = new Label();
            lblRucTrans = new Label();
            lblPlaca = new Label();
            label14 = new Label();
            lblMarca = new Label();
            label16 = new Label();
            label17 = new Label();
            label23 = new Label();
            button1 = new Button();
            btnInsertar = new Button();
            label3 = new Label();
            label21 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
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
            label10.Size = new Size(61, 17);
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
            label6.Size = new Size(36, 17);
            label6.TabIndex = 19;
            label6.Text = "RUC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 41);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 20;
            label5.Text = "Proveeedor";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(48, 107);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(52, 17);
            label12.TabIndex = 17;
            label12.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 169);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 17);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblRuc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblCorreo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblTel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 208);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = " PROVEEDOR";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lblLicencia);
            groupBox3.Controls.Add(Transporte);
            groupBox3.Controls.Add(lblDirecTrans);
            groupBox3.Controls.Add(lblRucTra);
            groupBox3.Controls.Add(lblRucTrans);
            groupBox3.Controls.Add(lblPlaca);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblMarca);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Font = new Font("Segoe UI", 9.75F);
            groupBox3.Location = new Point(586, 79);
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
            label9.Size = new Size(70, 17);
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
            // Transporte
            // 
            Transporte.AutoSize = true;
            Transporte.Location = new Point(20, 39);
            Transporte.Margin = new Padding(4, 0, 4, 0);
            Transporte.Name = "Transporte";
            Transporte.Size = new Size(71, 17);
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
            lblRucTrans.Size = new Size(36, 17);
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
            label14.Size = new Size(41, 17);
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
            label16.Size = new Size(45, 17);
            label16.TabIndex = 18;
            label16.Text = "Marca";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(24, 102);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(65, 17);
            label17.TabIndex = 15;
            label17.Text = "Direccion:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(64, 64, 64);
            label23.Location = new Point(12, 20);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(540, 32);
            label23.TabIndex = 60;
            label23.Text = "AGREGAR PROVEEDOR / TRANSPORTISTA";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(985, 314);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(161, 55);
            button1.TabIndex = 61;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.Teal;
            btnInsertar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(782, 314);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(170, 55);
            btnInsertar.TabIndex = 62;
            btnInsertar.Text = "Guardar";
            btnInsertar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(123, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 29);
            label3.TabIndex = 30;
            // 
            // label21
            // 
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("Century Gothic", 9F);
            label21.Location = new Point(110, 32);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(175, 29);
            label21.TabIndex = 32;
            // 
            // frmInsertarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 399);
            Controls.Add(btnInsertar);
            Controls.Add(button1);
            Controls.Add(label23);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInsertarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Remision";
            Load += frmInsertarProveedor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Label label12;
        private Label label8;
        private Label lblCorreo;
        private Label lblDireccion;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
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
        private Label label23;
        internal Button button1;
        private Button btnInsertar;
        private Label label3;
        private Label label21;
    }
}
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
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label12 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtDireccion = new RichTextBox();
            txtCorreo = new RichTextBox();
            txtProveedor = new RichTextBox();
            txtProRUC = new MaskedTextBox();
            txtTelefono = new MaskedTextBox();
            groupBox3 = new GroupBox();
            txtTraMarca = new RichTextBox();
            txtTranDireccion = new RichTextBox();
            txtTransporte = new RichTextBox();
            txtTransRUC = new MaskedTextBox();
            label9 = new Label();
            Transporte = new Label();
            lblRucTrans = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label23 = new Label();
            button1 = new Button();
            btnInsertar = new Button();
            txtLicencia = new MaskedTextBox();
            txtPlaca = new MaskedTextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtProveedor);
            groupBox1.Controls.Add(txtProRUC);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label12);
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
            // txtDireccion
            // 
            txtDireccion.Location = new Point(108, 161);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(174, 30);
            txtDireccion.TabIndex = 65;
            txtDireccion.Text = "";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(108, 104);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(174, 30);
            txtCorreo.TabIndex = 64;
            txtCorreo.Text = "";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(112, 36);
            txtProveedor.Margin = new Padding(4, 3, 4, 3);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(174, 30);
            txtProveedor.TabIndex = 63;
            txtProveedor.Text = "";
            // 
            // txtProRUC
            // 
            txtProRUC.Location = new Point(364, 36);
            txtProRUC.Margin = new Padding(4, 3, 4, 3);
            txtProRUC.Mask = "99999999999";
            txtProRUC.Name = "txtProRUC";
            txtProRUC.Size = new Size(175, 25);
            txtProRUC.TabIndex = 39;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(364, 100);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Mask = "999999999";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(175, 25);
            txtTelefono.TabIndex = 26;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtPlaca);
            groupBox3.Controls.Add(txtLicencia);
            groupBox3.Controls.Add(txtTraMarca);
            groupBox3.Controls.Add(txtTranDireccion);
            groupBox3.Controls.Add(txtTransporte);
            groupBox3.Controls.Add(txtTransRUC);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(Transporte);
            groupBox3.Controls.Add(lblRucTrans);
            groupBox3.Controls.Add(label14);
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
            // txtTraMarca
            // 
            txtTraMarca.Location = new Point(356, 89);
            txtTraMarca.Margin = new Padding(4, 3, 4, 3);
            txtTraMarca.Name = "txtTraMarca";
            txtTraMarca.Size = new Size(174, 30);
            txtTraMarca.TabIndex = 70;
            txtTraMarca.Text = "";
            // 
            // txtTranDireccion
            // 
            txtTranDireccion.Location = new Point(97, 97);
            txtTranDireccion.Margin = new Padding(4, 3, 4, 3);
            txtTranDireccion.Name = "txtTranDireccion";
            txtTranDireccion.Size = new Size(174, 30);
            txtTranDireccion.TabIndex = 67;
            txtTranDireccion.Text = "";
            // 
            // txtTransporte
            // 
            txtTransporte.Location = new Point(98, 36);
            txtTransporte.Margin = new Padding(4, 3, 4, 3);
            txtTransporte.Name = "txtTransporte";
            txtTransporte.Size = new Size(174, 30);
            txtTransporte.TabIndex = 66;
            txtTransporte.Text = "";
            // 
            // txtTransRUC
            // 
            txtTransRUC.Location = new Point(356, 36);
            txtTransRUC.Margin = new Padding(4, 3, 4, 3);
            txtTransRUC.Mask = "99999999999";
            txtTransRUC.Name = "txtTransRUC";
            txtTransRUC.Size = new Size(177, 25);
            txtTransRUC.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 164);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 17);
            label9.TabIndex = 31;
            label9.Text = "N. Licencia";
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
            button1.Click += button1_Click;
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
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtLicencia
            // 
            txtLicencia.Location = new Point(358, 161);
            txtLicencia.Margin = new Padding(4, 3, 4, 3);
            txtLicencia.Mask = "9999999";
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(177, 25);
            txtLicencia.TabIndex = 71;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(98, 161);
            txtPlaca.Margin = new Padding(4, 3, 4, 3);
            txtPlaca.Mask = "999999";
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(143, 25);
            txtPlaca.TabIndex = 72;
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
        private Label label10;
        private Label label6;
        private Label label5;
        private ComboBox cboProveeedor;
        private Label label12;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label Transporte;
        private Label lblRucTrans;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label9;
        private Label label23;
        internal Button button1;
        private Button btnInsertar;
        private MaskedTextBox txtProRUC;
        private MaskedTextBox txtTelefono;
        private MaskedTextBox txtTransRUC;
        private RichTextBox txtProveedor;
        private RichTextBox txtCorreo;
        private RichTextBox txtDireccion;
        private RichTextBox txtTraMarca;
        private RichTextBox txtTranDireccion;
        private RichTextBox txtTransporte;
        private MaskedTextBox txtLicencia;
        private MaskedTextBox txtPlaca;
    }
}
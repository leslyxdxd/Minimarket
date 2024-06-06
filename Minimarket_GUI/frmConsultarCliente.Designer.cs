namespace Minimarket_GUI
{
    partial class frmConsultarCliente
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
            lblNombre = new Label();
            lblApellidoPa = new Label();
            lblApellidoMA = new Label();
            lblNomCompleto = new Label();
            lblCodVeri = new Label();
            txtDni = new TextBox();
            lblNumero = new Label();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(226, 178);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(140, 26);
            lblNombre.TabIndex = 13;
            // 
            // lblApellidoPa
            // 
            lblApellidoPa.BorderStyle = BorderStyle.FixedSingle;
            lblApellidoPa.Location = new Point(226, 276);
            lblApellidoPa.Margin = new Padding(4, 0, 4, 0);
            lblApellidoPa.Name = "lblApellidoPa";
            lblApellidoPa.Size = new Size(109, 26);
            lblApellidoPa.TabIndex = 15;
            // 
            // lblApellidoMA
            // 
            lblApellidoMA.BorderStyle = BorderStyle.FixedSingle;
            lblApellidoMA.Location = new Point(226, 228);
            lblApellidoMA.Margin = new Padding(4, 0, 4, 0);
            lblApellidoMA.Name = "lblApellidoMA";
            lblApellidoMA.Size = new Size(140, 26);
            lblApellidoMA.TabIndex = 16;
            // 
            // lblNomCompleto
            // 
            lblNomCompleto.BorderStyle = BorderStyle.FixedSingle;
            lblNomCompleto.Location = new Point(226, 133);
            lblNomCompleto.Margin = new Padding(4, 0, 4, 0);
            lblNomCompleto.Name = "lblNomCompleto";
            lblNomCompleto.Size = new Size(235, 26);
            lblNomCompleto.TabIndex = 17;
            // 
            // lblCodVeri
            // 
            lblCodVeri.BorderStyle = BorderStyle.FixedSingle;
            lblCodVeri.Location = new Point(226, 322);
            lblCodVeri.Margin = new Padding(4, 0, 4, 0);
            lblCodVeri.Name = "lblCodVeri";
            lblCodVeri.Size = new Size(123, 26);
            lblCodVeri.TabIndex = 18;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 9.75F);
            txtDni.Location = new Point(44, 81);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(115, 25);
            txtDni.TabIndex = 19;
            // 
            // lblNumero
            // 
            lblNumero.BorderStyle = BorderStyle.FixedSingle;
            lblNumero.Location = new Point(226, 81);
            lblNumero.Margin = new Padding(4, 0, 4, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(155, 26);
            lblNumero.TabIndex = 20;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.SeaShell;
            btnConsultar.Font = new Font("Segoe UI", 9.75F);
            btnConsultar.Location = new Point(365, 405);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 31);
            btnConsultar.TabIndex = 23;
            btnConsultar.Text = "Grabar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // frmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 463);
            Controls.Add(btnConsultar);
            Controls.Add(lblNumero);
            Controls.Add(txtDni);
            Controls.Add(lblCodVeri);
            Controls.Add(lblNomCompleto);
            Controls.Add(lblApellidoMA);
            Controls.Add(lblApellidoPa);
            Controls.Add(lblNombre);
            Name = "frmConsultarCliente";
            Text = "frmConsultarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellidoPa;
        private Label lblApellidoMA;
        private Label lblNomCompleto;
        private Label lblCodVeri;
        private TextBox txtDni;
        private Label lblNumero;
        private Button btnConsultar;
    }
}
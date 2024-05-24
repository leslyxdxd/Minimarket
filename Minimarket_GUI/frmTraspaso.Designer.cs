namespace Minimarket_GUI
{
    partial class frmTraspaso
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
            lblProducto = new Label();
            groupBox2 = new GroupBox();
            lb = new Label();
            lblUNI = new Label();
            lblStockDis = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            btnTransferir = new Button();
            btnCancelar = new Button();
            lblCodigo = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.BorderStyle = BorderStyle.FixedSingle;
            lblProducto.Location = new Point(118, 36);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(113, 23);
            lblProducto.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lb);
            groupBox2.Controls.Add(lblUNI);
            groupBox2.Controls.Add(lblStockDis);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(lblProducto);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(27, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(552, 143);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Producto a Transferir";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(321, 44);
            lb.Margin = new Padding(4, 0, 4, 0);
            lb.Name = "lb";
            lb.Size = new Size(64, 15);
            lb.TabIndex = 44;
            lb.Text = "U. Medida:";
            // 
            // lblUNI
            // 
            lblUNI.BorderStyle = BorderStyle.FixedSingle;
            lblUNI.Location = new Point(396, 36);
            lblUNI.Margin = new Padding(4, 0, 4, 0);
            lblUNI.Name = "lblUNI";
            lblUNI.Size = new Size(116, 26);
            lblUNI.TabIndex = 44;
            // 
            // lblStockDis
            // 
            lblStockDis.BorderStyle = BorderStyle.FixedSingle;
            lblStockDis.Location = new Point(118, 88);
            lblStockDis.Name = "lblStockDis";
            lblStockDis.Size = new Size(113, 23);
            lblStockDis.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 41;
            label3.Text = "Cantidad a Transferir:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(392, 94);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 30;
            label2.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 89);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 39;
            label4.Text = "Stock Disponible";
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(331, 198);
            btnTransferir.Margin = new Padding(4, 3, 4, 3);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(120, 34);
            btnTransferir.TabIndex = 44;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(459, 198);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 34);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(145, 198);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(113, 23);
            lblCodigo.TabIndex = 45;
            // 
            // frmTraspaso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 257);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnTransferir);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTraspaso";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Traspasar Producto";
            Load += frmTraspaso_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblProducto;
        private GroupBox groupBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label4;
        private Label lb;
        private Label lblUNI;
        private Label lblStockDis;
        private Button btnTransferir;
        private Button btnCancelar;
        private Label lblCodigo;
    }
}
using Minimarket_GUI;

namespace ProyVentas_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaProveedores prov01 = new frmListaProveedores();
            prov01.MdiParent = this;
            prov01.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VendedorMan01 vend01 = new VendedorMan01();
            //vend01.MdiParent = this;
            //vend01.Show();
        }

        private void facturasClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmConsFacturasCliente frmc1 = new frmConsFacturasCliente();
            //frmc1.MdiParent = this;
            //frmc1.Show();

        }

        private void listadosXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmXMLDemo_01 frmxml01 = new frmXMLDemo_01();
            //frmxml01.MdiParent = this;
            //frmxml01.Show();
        }

        private void listadosExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmListadosExcel frmExcel = new frmListadosExcel();
            //frmExcel.MdiParent = this;
            //frmExcel.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            /* this.lblUsuario.Text = clsCredenciales.Usuario;
             //Definimos la seguridad por roles..
             if (clsCredenciales.Nivel == 1)
             {
                 mantenimientosToolStripMenuItem.Visible = true;
                 consultasToolStripMenuItem.Visible = true;
                 listadosToolStripMenuItem.Visible = true;
                 salirDelSistemasToolStripMenuItem.Visible = true;

             }
             else if (clsCredenciales.Nivel == 2)
             {

                 mantenimientosToolStripMenuItem.Visible = true;
                 consultasToolStripMenuItem.Visible = true;
                 listadosToolStripMenuItem.Visible = false;
                 salirDelSistemasToolStripMenuItem.Visible = true;

             }*/


        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ProductoMan01 prod01 = new ProductoMan01();
            prod01.MdiParent = this;
            prod01.Show();*/
        }
    }
}

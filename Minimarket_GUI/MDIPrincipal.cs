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
            // Obtener el nombre de usuario
            string nombreUsuario = clsCredenciales.Login_Usuario;

            // Definir los nombres personalizados para ciertos usuarios
            string nombrePersonalizado;

            switch (nombreUsuario)
            {
                case "sa":
                    nombrePersonalizado = "Administrador";
                    break;
                case "jordan":
                    nombrePersonalizado = "Gerente de Tienda";
                    break;
                case "lesly":
                    nombrePersonalizado = "Gerente de Almacén";
                    break;
                default:
                    nombrePersonalizado = nombreUsuario; // Si no coincide con ningún usuario específico, mostrar el nombre de usuario normal
                    break;
            }

            // Asignar el nombre personalizado al campo de texto
            this.lblUsuario.Text = nombrePersonalizado;

            if (clsCredenciales.Niv_Usuario == 1)
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                gestionarUsuariosToolStripMenuItem.Visible = true;
                salirDelSistemasToolStripMenuItem.Visible = true;
                generarGuiaToolStripMenuItem.Visible = true;



            }
            else if (clsCredenciales.Niv_Usuario == 3)
            {

                mantenimientosToolStripMenuItem.Visible = false;
                consultasToolStripMenuItem.Visible = true;
                gestionarUsuariosToolStripMenuItem.Visible = false;
                salirDelSistemasToolStripMenuItem.Visible = true;
                generarGuiaToolStripMenuItem.Visible = false;
                facturasClienteToolStripMenuItem.Visible = true;
                facturasVendedorToolStripMenuItem.Visible = false;

            }
            else if (clsCredenciales.Niv_Usuario == 2)
            {

                mantenimientosToolStripMenuItem.Visible = false;
                consultasToolStripMenuItem.Visible = true;
                gestionarUsuariosToolStripMenuItem.Visible = false;
                salirDelSistemasToolStripMenuItem.Visible = true;
                generarGuiaToolStripMenuItem.Visible = false;
                facturasClienteToolStripMenuItem.Visible = false;
                facturasVendedorToolStripMenuItem.Visible = true;
                generarGuiaToolStripMenuItem.Visible = true;
                gestionarVentaToolStripMenuItem.Visible = false;



            }


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

        private void proveeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmListaProveedores prov01 = new frmListaProveedores();
            prov01.MdiParent = this;
            prov01.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para que se cierre
            this.Close();

        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUsuario listausu = new frmListaUsuario();
            listausu.MdiParent = this;
            listausu.Show();

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertarUsuario usu = new frmInsertarUsuario();
            usu.MdiParent = this;
            usu.Show();
        }

        private void gestionarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaProductos prov01 = new frmVentaProductos();
            prov01.MdiParent = this;
            prov01.Show();

        }
    }
}

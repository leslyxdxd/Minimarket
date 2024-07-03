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
            frmListaProductos frmc1 = new frmListaProductos();
            frmc1.MdiParent = this;
            frmc1.Show();

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

                consultasToolStripMenuItem.Visible = true;
                gestionarUsuariosToolStripMenuItem.Visible = true;
                salirDelSistemasToolStripMenuItem.Visible = true;
                generarGuiaToolStripMenuItem.Visible = true;



            }
            else if (clsCredenciales.Niv_Usuario == 2)
            {


                consultasToolStripMenuItem.Visible = true;
                gestionarUsuariosToolStripMenuItem.Visible = false;
                salirDelSistemasToolStripMenuItem.Visible = true;
                generarGuiaToolStripMenuItem.Visible = false;
                StokTienda.Visible = true;
                stokAlmacen.Visible = false;
                generarRemisionToolStripMenuItem.Visible = false;
                gestionarVentaToolStripMenuItem.Visible = true;


            }
            else if (clsCredenciales.Niv_Usuario == 3)
            {


                consultasToolStripMenuItem.Visible = true;
                gestionarUsuariosToolStripMenuItem.Visible = false;
                salirDelSistemasToolStripMenuItem.Visible = true;
                StokTienda.Visible = false;
                stokAlmacen.Visible = true;
                generarRemisionToolStripMenuItem.Visible = true;
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

        }

        private void generarRemisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaRemision prov01 = new frmListaRemision();
            prov01.MdiParent = this;
            prov01.Show();
        }

        private void stokAlmacen_Click(object sender, EventArgs e)
        {
            frmListaProductosTras frmc1 = new frmListaProductosTras();
            frmc1.MdiParent = this;
            frmc1.Show();

        }


        private void boletaToolStripMenuItem_Click(object sender, EventArgs e)
        {



            frmVentaBoletas frmBoletas = new frmVentaBoletas();
            frmBoletas.MdiParent = this;
            frmBoletas.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmVentaFacturas frmFacturas = new frmVentaFacturas();
            frmFacturas.MdiParent = this;
            frmFacturas.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmListaFacturas frmFacturas = new frmListaFacturas();
            frmFacturas.MdiParent = this;
            frmFacturas.Show();

        }

        private void boletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaBoletas frmFacturas = new frmListaBoletas();
            frmFacturas.MdiParent = this;
            frmFacturas.Show();
        }

        private void salirDelSistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

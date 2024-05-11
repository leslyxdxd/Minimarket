using ProyVentas_GUI;
using System;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;
using System.Data;

namespace Minimarket_GUI
{
    public partial class frmVentaProductos : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();

        public string Codigo { get; set; }

        public frmVentaProductos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario frmListaProductos
            frmListaProductos listaProducto = new frmListaProductos();
            listaProducto.ShowDialog();
        }

        private void frmVentaProductos_Load(object sender, EventArgs e)
        {
            try
            {

                // Cargamos los combos...

                //codifique
                //invocamos la methodo consultar..
                objProductoBE = objProductoBL.ConsultarProducto(this.Codigo);



                lblCodigo.Text = objProductoBE.Id_Producto;
                lblNombre.Text = objProductoBE.Nom_Producto;
                lblPrecio.Text = objProductoBE.Precio_Unitario.ToString(); ;
                lblUM.Text = objProductoBE.Des_UM;
                lblStock.Text = objProductoBE.Stk_Tienda.ToString(); ;

             


               
                DataTable dt2 = objProductoBL.ListarProducto();
                DataRow dtr;
                dtr = dt2.NewRow();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
using ProyVentas_GUI;
using System;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;

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
                // Verificar si se proporcionó un código válido
                if (!string.IsNullOrEmpty(Codigo))
                {
                    // Invocamos el método ConsultarProducto con el código proporcionado
                    objProductoBE = objProductoBL.ConsultarProducto(Codigo);

                    // Asignamos los valores a los controles del formulario
                    lblCodigo.Text = objProductoBE.Id_Producto;
                    lblNombre.Text = objProductoBE.Nom_Producto;
                    lblPrecio.Text = objProductoBE.Precio_Unitario.ToString();
                    lblUM.Text = objProductoBE.Id_UM.ToString();
                    lblStock.Text = objProductoBE.Stk_Tienda.ToString();
                    lblprove.Text = objProductoBE.Id_Proveedor.ToString();
                    lblcat.Text = objProductoBE.Id_Cat.ToString();
                    lbltienda.Text = objProductoBE.Stk_Trastienda.ToString();
                    lblestado.Text = objProductoBE.Estado.ToString();





      


                }
                else
                {
                    MessageBox.Show("No se proporcionó un código de producto válido.");
                }
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
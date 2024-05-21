using System;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;
using System.Data;
using ProyVentas_BL;

namespace Minimarket_GUI
{
    public partial class frmVentaProductos : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        StockBE objStockBE = new StockBE();
        StockBL objStockBL = new StockBL();
        UnidadMedidaBE objUnidadMedidaBE = new UnidadMedidaBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();    

        public string Codigo { get; set; }

        public frmVentaProductos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario frmListaProductos
            using (var listaProducto = new frmListaProductos())
            {
                if (listaProducto.ShowDialog() == DialogResult.OK)
                {
                    var producto = listaProducto.ProductoSeleccionado;
                    if (producto != null)
                    {
                        lblCodigo.Text = producto["id_Producto"].ToString();
                        lblNombre.Text = producto["Nom_Producto"].ToString();
                        lblPrecio.Text = producto["Precio_Unitario"].ToString();
                        lblUM.Text = producto["Des_UM"].ToString();
                        lblStock.Text = producto["Stk_Tienda"].ToString();
                    }
                }
            }
        }

        private void frmVentaProductos_Load(object sender, EventArgs e)
        {
            try
            {
                // Aquí se puede cargar información inicial si es necesario

                // Cargamos los combos...
                // Codifique para cargar los datos del producto si ya se ha seleccionado un código anteriormente
                if (!string.IsNullOrEmpty(this.Codigo))
                {
                    objProductoBE = objProductoBL.ConsultarProducto(this.Codigo);
                    lblCodigo.Text = objProductoBE.Id_Producto;
                    lblNombre.Text = objProductoBE.Nom_Producto;
                    lblPrecio.Text = objProductoBE.Precio_Unitario.ToString();
                    lblUM.Text = objUnidadMedidaBE.Des_UM;
                    lblStock.Text = objStockBE.Stk_Tienda.ToString();


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
                // Codifique la lógica para consultar el producto
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

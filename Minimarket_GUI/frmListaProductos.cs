using System;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;
using System.Data;

namespace Minimarket_GUI
{
    public partial class frmListaProductos : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        DataView dtv;

        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void CargarDatos(string Nom_Producto)
        {
            dtv = new DataView(objProductoBL.ListarProducto());
            dtv.RowFilter = "Nom_Producto LIKE '%" + Nom_Producto + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuiasRemision_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dtgDatos.SelectedRows.Count > 0)
                {
                    // Obtener el código del producto seleccionado
                    string codigoProducto = dtgDatos.SelectedRows[0].Cells["Id_Producto"].Value.ToString();

                    // Crear una instancia del formulario frmVentaProductos
                    frmVentaProductos seleccionarProductos = new frmVentaProductos();

                    // Asignar el código del producto seleccionado a la propiedad Codigo del formulario frmVentaProductos
                    seleccionarProductos.Codigo = codigoProducto;

                    // Mostrar el formulario frmVentaProductos
                    seleccionarProductos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto primero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
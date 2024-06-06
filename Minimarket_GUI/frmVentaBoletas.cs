using System;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;
using System.Data;
using ProyVentas_BL;

namespace Minimarket_GUI
{
    public partial class frmVentaBoletas : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        StockBE objStockBE = new StockBE();
        StockBL objStockBL = new StockBL();
        UnidadMedidaBE objUnidadMedidaBE = new UnidadMedidaBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        ClienteBL objClienteBL = new ClienteBL();

        public string Codigo { get; set; }

        public frmVentaBoletas()
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void btnBuscarClienteDNI_Click(object sender, EventArgs e)
        {

            try
            {
                string dni = txtDNI.Text.Trim();
                if (!string.IsNullOrEmpty(dni))
                {
                    ClienteBE cliente = await objClienteBL.ObtenerClientePorDniAsync(dni);
                    if (cliente != null)
                    {
                        // Concatenar apellido paterno y materno con un espacio entre ellos
                        lblApellidos.Text = cliente.apellido_paterno + " " + cliente.apellido_materno;
                        lblNombres.Text = cliente.nombres;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información para el DNI proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al consultar el DNI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dtgListaProductos);
            file.Cells[0].Value = lblCodigo.Text;
            file.Cells[1].Value = lblNombre.Text;
            file.Cells[2].Value = lblPrecio.Text;
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = (float.Parse(lblPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

            dtgListaProductos.Rows.Add(file);
            lblRegistros.Text = dtgListaProductos.Rows.Count.ToString();
            lblNombre.Text = lblPrecio.Text = txtCantidad.Text = lblCodigo.Text =lblUM.Text = lblStock.Text = "";

            obtenerTotal();

        }

        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;

            contador = dtgListaProductos.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dtgListaProductos.Rows[i].Cells[4].Value.ToString());
            }

            lblTotalPagar.Text = costot.ToString();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dtgListaProductos.Rows.Remove(dtgListaProductos.CurrentRow);
                    lblRegistros.Text = dtgListaProductos.Rows.Count.ToString();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            obtenerTotal();

        }
    }
}

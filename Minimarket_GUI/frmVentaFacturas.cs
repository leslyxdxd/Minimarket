using System;
using System.Data;
using System.Windows.Forms;
using Minimarket_BE;
using Minimarket_BL;
using ProyVentas_BL;

namespace Minimarket_GUI
{
    public partial class frmVentaFacturas : Form
    {
        FacturaBL objFacturaBL = new FacturaBL();
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        StockBE objStockBE = new StockBE();
        StockBL objStockBL = new StockBL();
        UnidadMedidaBE objUnidadMedidaBE = new UnidadMedidaBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();

        decimal total = 0; // Variable para almacenar el total de los subtotales

        public string Codigo { get; set; }

        public frmVentaFacturas()
        {
            InitializeComponent();
        }

        // Método para buscar información de la factura basada en el RUC
        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string ruc = txtRuc.Text.Trim();
                if (!string.IsNullOrEmpty(ruc))
                {
                    FacturaBE factura = await objFacturaBL.ObtenerFacturaPorRucAsync(ruc);
                    if (factura != null)
                    {
                        lblRazonSocial.Text = factura.nombre_o_razon_social;
                        lblDireccion.Text = factura.direccion;
                        lblEstado.Text = factura.estado;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información para el RUC proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un RUC.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al consultar el RUC: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar productos y seleccionarlos
        private void button3_Click(object sender, EventArgs e)
        {
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
                else
                {
                    MessageBox.Show("Error al cargar los datos");
                }
            }
        }

        // Método para cargar datos iniciales en el formulario
        private void frmVentaFacturas_Load(object sender, EventArgs e)
        {
            try
            {
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

        // Método para agregar productos a la lista de la factura
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCantidad2.Text))
                {
                    MessageBox.Show("La cantidad no puede estar en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCantidad2.Text, out int cantidad))
                {
                    MessageBox.Show("La cantidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(lblStock.Text, out int stock))
                {
                    MessageBox.Show("El valor del stock no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cantidad > stock)
                {
                    MessageBox.Show("La cantidad no puede ser mayor que el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cantidad == stock)
                {
                    MessageBox.Show("La cantidad no puede ser igual al stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal precioUnitario = Convert.ToDecimal(lblPrecio.Text);
                decimal subtotal = precioUnitario * cantidad;

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dtgProducto);
                fila.Cells[0].Value = lblCodigo.Text;
                fila.Cells[1].Value = lblNombre.Text;
                fila.Cells[2].Value = lblPrecio.Text;
                fila.Cells[3].Value = txtCantidad2.Text;
                fila.Cells[4].Value = subtotal;

                dtgProducto.Rows.Add(fila);
                lblRegistros.Text = dtgProducto.Rows.Count.ToString();
                CalcularTotal();
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para eliminar productos de la lista de la factura
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dtgProducto.Rows.Remove(dtgProducto.SelectedRows[0]);
                        lblRegistros.Text = dtgProducto.Rows.Count.ToString();
                        CalcularTotal();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular el total de la factura
        private void CalcularTotal()
        {
            total = 0;
            foreach (DataGridViewRow fila in dtgProducto.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[4].Value);
                }
            }
            lblTotal.Text = total.ToString("0.00");
        }

        // Método para limpiar los datos del producto después de agregarlo
        private void LimpiarDatos()
        {
            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblPrecio.Text = "";
            lblUM.Text = "";
            lblStock.Text = "";
            txtCantidad2.Text = "";
        }

        // Método para registrar la factura
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgProducto.Rows.Count < 1)
                {
                    MessageBox.Show("Debe agregar al menos un producto a la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable detalleVenta = new DataTable();
                detalleVenta.Columns.Add("IdProducto", typeof(string));
                detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
                detalleVenta.Columns.Add("Cantidad", typeof(int));
                detalleVenta.Columns.Add("SubTotal", typeof(decimal));

                foreach (DataGridViewRow row in dtgProducto.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataRow dataRow = detalleVenta.NewRow();
                    dataRow["IdProducto"] = row.Cells[0].Value.ToString();
                    dataRow["PrecioVenta"] = Convert.ToDecimal(row.Cells[2].Value);
                    dataRow["Cantidad"] = Convert.ToInt32(row.Cells[3].Value);
                    dataRow["SubTotal"] = Convert.ToDecimal(row.Cells[4].Value);

                    detalleVenta.Rows.Add(dataRow);
                }

                FacturaBE factura = new FacturaBE
                {
                    ruc = txtRuc.Text,
                    nombre_o_razon_social = lblRazonSocial.Text,
                    direccion_completa = lblDireccion.Text,
                    estado = lblEstado.Text,
                    Usu_Registro = clsCredenciales.Login_Usuario
                };

                string mensaje;
                bool registrado = objFacturaBL.RegistrarFactura(factura, detalleVenta, out mensaje);

                if (registrado)
                {
                    MessageBox.Show("Factura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show($"Error al registrar la factura: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar el formulario después de registrar la factura
        private void LimpiarFormulario()
        {
            txtRuc.Text = "";
            lblRazonSocial.Text = "";
            lblDireccion.Text = "";
            lblEstado.Text = "";
            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblPrecio.Text = "";
            lblUM.Text = "";
            lblStock.Text = "";
            txtCantidad2.Text = "";
            lblRegistros.Text = "";
            lblTotal.Text = "";
            dtgProducto.Rows.Clear();
        }
    }
}

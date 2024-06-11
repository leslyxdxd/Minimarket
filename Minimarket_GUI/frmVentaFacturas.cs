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
                        // Mostrar los datos de la factura en etiquetas de texto
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
                else
                
                {
                    MessageBox.Show("Error al cargar los datos");
                
                }
            }
        }

        private void frmVentaFacturas_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado una cantidad válida
            if (!string.IsNullOrEmpty(txtCantidad2.Text) && int.TryParse(txtCantidad2.Text, out int cantidad))
            {
                // Calcular el subtotal
                decimal precioUnitario = Convert.ToDecimal(lblPrecio.Text);
                decimal subtotal = precioUnitario * cantidad;

                // Crear una nueva fila para el DataGridView
                DataGridViewRow fila = new DataGridViewRow();

                // Agregar las celdas a la fila
                fila.CreateCells(dtgProducto);

                // Asignar los valores a las celdas de la fila
                fila.Cells[0].Value = lblNombre.Text; // Primera columna
                fila.Cells[1].Value = lblPrecio.Text; // Segunda columna
                fila.Cells[2].Value = txtCantidad2.Text; // Tercera columna
                fila.Cells[3].Value = subtotal; // Cuarta columna
                lblRegistros.Text = dtgProducto.Rows.Count.ToString();
                // Agregar la fila al DataGridView
                dtgProducto.Rows.Add(fila);

                // Calcular el total
                CalcularTotal();

                // Limpiar los labels y el TextBox
                LimpiarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dtgProducto.SelectedRows.Count > 0)
            {
                // Mostrar un mensaje de advert
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Obtener la fila seleccionada y eliminarla
                    dtgProducto.Rows.Remove(dtgProducto.SelectedRows[0]);
                    lblRegistros.Text = dtgProducto.Rows.Count.ToString();
                    // Calcular el total después de eliminar
                    CalcularTotal();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalcularTotal()
        {
            // Reiniciar el total
            total = 0;
            // Calcular el total sumando los subtotales de todas las filas
            foreach (DataGridViewRow fila in dtgProducto.Rows)
            {
                if (fila.Cells[3].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[3].Value);
                }
            }
            // Actualizar el valor del label lblTotal
            lblTotal.Text = total.ToString();
        }

        private void LimpiarDatos()
        {
            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblPrecio.Text = "";
            lblUM.Text = "";
            lblStock.Text = "";
            txtCantidad2.Text = "";
        }

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
                detalleVenta.Columns.Add("IdProducto", typeof(int));
                detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
                detalleVenta.Columns.Add("Cantidad", typeof(int));
                detalleVenta.Columns.Add("SubTotal", typeof(decimal));

                foreach (DataGridViewRow row in dtgProducto.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells[0].Value);
                    decimal precioVenta = Convert.ToDecimal(row.Cells[1].Value);
                    int cantidad = Convert.ToInt32(row.Cells[2].Value);
                    decimal subTotal = Convert.ToDecimal(row.Cells[3].Value);

                    detalleVenta.Rows.Add(idProducto, precioVenta, cantidad, subTotal);
                }

                // Aquí debes completar la instancia de la factura con los datos correspondientes de tu formulario
                FacturaBE factura = new FacturaBE
                {
                    // Asigna los valores correspondientes a los atributos de la factura
                    // por ejemplo: factura.Ruc = txtRuc.Text;
                    // Completa con el resto de los atributos necesarios
                };

                // Llama al método para registrar la factura
                string mensaje;
                bool registrado = objFacturaBL.RegistrarFactura(factura, detalleVenta, out mensaje);

                if (registrado)
                {
                    MessageBox.Show("Factura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aquí puedes realizar otras acciones luego de registrar la factura, como limpiar los controles del formulario, etc.
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
    }
}


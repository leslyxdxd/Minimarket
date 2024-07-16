using System;
using System.Data;
using System.Windows.Forms;
using Minimarket_ADO;
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
                    lblPrecio.Text = objProductoBE.Precio_Unitario.ToString("0.00,###");
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
            bool producto_existe = false;
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
                    MessageBox.Show("La cantidad no puede ser igual que el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                int cantidadExistente = 0;

                // Verificar si el producto ya existe en el DataGridView
                foreach (DataGridViewRow fila in dtgProducto.Rows)
                {
                    if (fila.Cells["Cod_Producto"].Value.ToString() == lblCodigo.Text)
                    {
                        producto_existe = true;
                        cantidadExistente = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                        break;
                    }
                }

                if (producto_existe)
                {
                    // Actualizar cantidad y recalcular valores si el producto ya existe
                    foreach (DataGridViewRow fila in dtgProducto.Rows)
                    {
                        if (fila.Cells["Cod_Producto"].Value.ToString() == lblCodigo.Text)
                        {
                            int nuevaCantidad = cantidadExistente + cantidad;

                            if (nuevaCantidad > stock)
                            {
                                MessageBox.Show("La cantidad total no puede ser mayor que el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (nuevaCantidad == stock)
                            {
                                MessageBox.Show("La cantidad no puede ser igual que el Stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            fila.Cells["Cantidad"].Value = nuevaCantidad;

                            decimal precioUnitario = Convert.ToDecimal(lblPrecio.Text);
                            decimal subtotal = precioUnitario * nuevaCantidad;
                            decimal tasaIGV = 0.18m; // Tasa del 18%
                            decimal igv = subtotal * tasaIGV;
                            decimal total = subtotal + igv;

                            fila.Cells["IGV"].Value = igv;
                            fila.Cells["SubTotal"].Value = total;


                            // Restar el stock
                            bool respuesta = new BoletaADO().RestarStock(
                                Convert.ToString(lblCodigo.Text), Convert.ToInt16(txtCantidad2.Text)
                            );
                            break;
                        }
                    }
                }
                else
                {
                    // Agregar nueva fila si el producto no existe
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dtgProducto);
                    fila.Cells[0].Value = lblCodigo.Text;
                    fila.Cells[1].Value = lblNombre.Text;
                    fila.Cells[2].Value = decimal.Parse(lblPrecio.Text).ToString("N2");
                    fila.Cells[3].Value = txtCantidad2.Text;

                    decimal precioUnitario = Convert.ToDecimal(lblPrecio.Text);
                    decimal subtotal = precioUnitario * cantidad;
                    decimal tasaIGV = 0.18m; // Tasa del 18%
                    decimal igv = subtotal * tasaIGV;
                    decimal total = subtotal + igv;

                    fila.Cells[4].Value = igv.ToString("F2");
                    fila.Cells[5].Value = total.ToString("F2");

                    dtgProducto.Rows.Add(fila);

                    // Restar el stock
                    bool respuesta = new BoletaADO().RestarStock(
                        Convert.ToString(lblCodigo.Text), Convert.ToInt16(txtCantidad2.Text)
                    );
                }

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
                    DataGridViewRow fila = dtgProducto.SelectedRows[0];
                    int index = fila.Index;

                    if (index >= 0)
                    {
                        string idProducto = dtgProducto.Rows[index].Cells["Cod_Producto"].Value?.ToString();
                        string cantidadStr = dtgProducto.Rows[index].Cells["Cantidad"].Value?.ToString();

                        if (idProducto != null && cantidadStr != null)
                        {
                            int cantidad = Convert.ToInt32(cantidadStr);

                            bool respuesta = new BoletaADO().SumarStock(idProducto, cantidad);

                            if (respuesta)
                            {
                                dtgProducto.Rows.RemoveAt(index);
                                CalcularTotal();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo obtener el ID del producto o la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fila seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay filas seleccionadas para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Consulte con TI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular el total de la factura
        private void CalcularTotal()
        {
            total = 0;
            int contador = 0;

            contador = dtgProducto.RowCount;

            foreach (DataGridViewRow fila in dtgProducto.Rows)
            {
                if (fila.Cells[5].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[5].Value);
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
                    Usu_Registro = clsCredenciales.Login_Usuario,
                    
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
            rtxtEfectivo.Text = "";
            lblDevolucion.Text = "";
           
            dtgProducto.Rows.Clear();
        }

        private void frmVentaFacturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {


                // Iterar sobre todas las filas del DataGridView
                foreach (DataGridViewRow fila in dtgProducto.Rows)
                {
                    if (fila.Cells["Cod_Producto"].Value != null && fila.Cells["Cantidad"].Value != null)
                    {
                        string idProducto = fila.Cells["Cod_Producto"].Value.ToString();
                        int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value.ToString());

                        // Sumar el stock del producto
                        bool respuesta = new BoletaADO().SumarStock(idProducto, cantidad);



                        if (!respuesta)
                        {
                            MessageBox.Show($"No se pudo actualizar el stock para el producto con código {idProducto}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el ID del producto o la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Limpiar todas las filas del DataGridView
                dtgProducto.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Consulte con TI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtxtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtEfectivo.Text))
            {
                lblDevolucion.Text = "";
                return;
            }

            try
            {
                float efectivo = float.Parse(rtxtEfectivo.Text);
                float totalPagar = float.Parse(lblTotal.Text);
                float devolucion = efectivo - totalPagar;
                lblDevolucion.Text = Math.Round(devolucion, 2).ToString(); // Redondear a 2 decimales
            }
            catch (FormatException)
            {
                // Manejar el error de formato, por ejemplo, si el texto ingresado no es un número válido
                MessageBox.Show("Ingrese un valor numérico válido.");
                lblDevolucion.Text = "";
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones si es necesario
                MessageBox.Show("Consulte con TI: " + ex.Message);
                lblDevolucion.Text = "";
            }
        }

        private void rtxtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Permitir solo números y un solo punto decimal
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                // Solo permitir un punto decimal
                if ((e.KeyChar == ',') && ((sender as RichTextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Consulte con TI");
            }

        }

        private void rbtnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnTarjeta.Checked)
                {
                    rtxtEfectivo.Enabled = false;
                    lblDevolucion.Enabled = false;
                }
                else

                {
                    rtxtEfectivo.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw new Exception("Consulta con TI");
            }
        }
    }
}

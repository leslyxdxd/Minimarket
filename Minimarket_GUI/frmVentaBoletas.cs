﻿using System;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;
using System.Data;
using ProyVentas_BL;
using Minimarket_ADO;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool producto_existe = false;

            try
            {
                // Validación de la cantidad
                if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("La cantidad no puede estar en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad))
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

                // Variable para almacenar la cantidad existente si el producto ya está en el DataGridView
                int cantidadExistente = 0;

                // Iterar sobre las filas del DataGridView para verificar si el producto ya existe
                foreach (DataGridViewRow fila in dtgListaProductos.Rows)
                {
                    if (fila.Cells["Cod_Producto"].Value.ToString() == lblCodigo.Text)
                    {
                        producto_existe = true;
                        cantidadExistente = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                        break;
                    }
                }

                // Si el producto ya existe, actualizar la cantidad y el total
                if (producto_existe)
                {
                    foreach (DataGridViewRow fila in dtgListaProductos.Rows)
                    {
                        if (fila.Cells["Cod_Producto"].Value.ToString() == lblCodigo.Text)
                        {
                            int nuevaCantidad = cantidadExistente + cantidad;

                            // Validar que la nueva cantidad no exceda el stock disponible
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

                            // Actualizar la cantidad en el DataGridView
                            fila.Cells["Cantidad"].Value = nuevaCantidad;

                            // Calcular el nuevo subtotal, IGV y total
                            float precio = float.Parse(lblPrecio.Text);
                            float subtotal = precio * nuevaCantidad;
                            float tasaIGV = 0.18f; // Tasa del 18%
                            float igv = subtotal * tasaIGV;
                            float total = subtotal + igv;

                            // Asignar los valores a las celdas correspondientes    
                            fila.Cells["IGV"].Value = igv.ToString("F2");      // IGV
                            fila.Cells["SubTotal"].Value = total.ToString("F2");  // Total con IGV

                            // Restar el stock
                            bool respuesta = new BoletaADO().RestarStock(
                                Convert.ToString(lblCodigo.Text), Convert.ToInt16(txtCantidad.Text)
                            );
                            break;
                        }
                    }
                }
                else
                {
                    // Si el producto no existe, agregar una nueva fila y restar stock
                    DataGridViewRow file = new DataGridViewRow();
                    file.CreateCells(dtgListaProductos);
                    file.Cells[0].Value = lblCodigo.Text;
                    file.Cells[1].Value = lblNombre.Text;
                    file.Cells[2].Value = decimal.Parse(lblPrecio.Text).ToString("N2");

                    file.Cells[3].Value = txtCantidad.Text;

                    // Calcular el subtotal, IGV y total
                    float precio = float.Parse(lblPrecio.Text);
                    float subtotal = precio * cantidad;
                    float tasaIGV = 0.18f; // Tasa del 18%
                    float igv = subtotal * tasaIGV;
                    float total = subtotal + igv;

                    // Asignar los valores a las celdas correspondientes    
                    file.Cells[4].Value = igv.ToString("F2");      // IGV
                    file.Cells[5].Value = total.ToString("F2");    // Total con IGV

                    dtgListaProductos.Rows.Add(file);

                    // Restar el stock
                    bool respuesta = new BoletaADO().RestarStock(
                        Convert.ToString(lblCodigo.Text), Convert.ToInt16(txtCantidad.Text)
                    );
                }

                lblRegistros.Text = dtgListaProductos.Rows.Count.ToString();
                lblNombre.Text = lblPrecio.Text = txtCantidad.Text = lblCodigo.Text = lblUM.Text = lblStock.Text = "";

                obtenerTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;

            contador = dtgListaProductos.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dtgListaProductos.Rows[i].Cells[5].Value.ToString());
            }

            lblTotalPagar.Text = costot.ToString("F2");
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            try
            {
                if (dtgListaProductos.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dtgListaProductos.SelectedRows[0];
                    int index = fila.Index;

                    if (index >= 0)
                    {
                        string idProducto = dtgListaProductos.Rows[index].Cells["Cod_Producto"].Value?.ToString();
                        string cantidadStr = dtgListaProductos.Rows[index].Cells["Cantidad"].Value?.ToString();

                        if (idProducto != null && cantidadStr != null)
                        {
                            int cantidad = Convert.ToInt32(cantidadStr);

                            bool respuesta = new BoletaADO().SumarStock(idProducto, cantidad);

                            if (respuesta)
                            {
                                dtgListaProductos.Rows.RemoveAt(index);
                                obtenerTotal();
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

        private void btnRegistrarBoleta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgListaProductos.Rows.Count < 1)
                {
                    MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataTable Detalle_Boleta = new DataTable();
                Detalle_Boleta.Columns.Add("Id_Producto", typeof(string));
                Detalle_Boleta.Columns.Add("Cantidad", typeof(int));


                foreach (DataGridViewRow row in dtgListaProductos.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataRow dataRow = Detalle_Boleta.NewRow();
                    dataRow["Id_Producto"] = row.Cells["Cod_Producto"].Value.ToString().Trim(); // Aquí asignamos el Id_Producto de la fila actual
                    dataRow["Cantidad"] = Convert.ToInt16(row.Cells["Cantidad"].Value);
                    Detalle_Boleta.Rows.Add(dataRow);
                }

                BoletaBE BoletaBE = new BoletaBE
                {
                    Dni_Cliente = txtDNI.Text,
                    Nombres_Cliente = lblNombres.Text,
                    Apellidos_Cliente = lblApellidos.Text,
                    Usu_Registro = clsCredenciales.Login_Usuario
                };

                string mensaje = string.Empty;
                bool respuesta = new BoletaBL().Registrar(BoletaBE, Detalle_Boleta, out mensaje);
                if (respuesta)
                {
                    MessageBox.Show("El registro de la boleta se realizo con exito");
                    txtDNI.Text = "";
                    lblApellidos.Text = "";
                    lblNombres.Text = "";
                    lblCodigo.Text = "";
                    lblPrecio.Text = "";
                    lblUM.Text = "";
                    lblStock.Text = "";
                    txtCantidad.Text = "";
                    lblRegistros.Text = "";
                    lblTotalPagar.Text = "";
                    dtgListaProductos.Rows.Clear();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema consulte con TI", ex.Message);
            }


        }

        private void dtgListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVentaBoletas_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {


                // Iterar sobre todas las filas del DataGridView
                foreach (DataGridViewRow fila in dtgListaProductos.Rows)
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
                dtgListaProductos.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Consulte con TI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

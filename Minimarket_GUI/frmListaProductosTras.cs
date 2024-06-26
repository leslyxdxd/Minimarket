using Minimarket_BE;
using Minimarket_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmListaProductosTras : Form
    {
        ProductoBL objProductoBL = new ProductoBL();

        StockBL objStock = new StockBL();
        DataView dtv;
        public frmListaProductosTras()
        {
            InitializeComponent();
        }

        private void CargarDatos(string Nom_Producto)
        {
            dtv = new DataView(objStock.ListarStock());
            dtv.RowFilter = "Nom_Producto LIKE '%" + Nom_Producto + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmListaProductosTras_Load(object sender, EventArgs e)
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

        private void btnInabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el producto seleccionado en la grilla
                if (dtgDatos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dtgDatos.SelectedRows[0];
                    string estadoProducto = filaSeleccionada.Cells["Estado"].Value.ToString();
                    string idProducto = filaSeleccionada.Cells["Id_Producto"].Value.ToString();

                    // Verificar si el producto ya está inhabilitado
                    if (estadoProducto.Equals("No disponible", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("El producto ya está inhabilitado.");
                        return; // Salir del método sin hacer nada más
                    }

                    // Crear objeto ProductoBE con el Id_Producto seleccionado
                    ProductoBE producto = new ProductoBE();
                    producto.Id_Producto = idProducto;

                    // Llamar al método de negocio para inhabilitar el producto
                    bool exito = objProductoBL.InhabilitarProducto(producto);

                    if (exito)
                    {
                        MessageBox.Show("Producto inhabilitado correctamente.");
                        CargarDatos(txtFiltro.Text.Trim()); // Actualizar la grilla después de la operación
                    }
                    else
                    {
                        MessageBox.Show("No se pudo inhabilitar el producto.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para inhabilitar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el producto seleccionado en la grilla
                if (dtgDatos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dtgDatos.SelectedRows[0];
                    string estadoProducto = filaSeleccionada.Cells["Estado"].Value.ToString();
                    string idProducto = filaSeleccionada.Cells["Id_Producto"].Value.ToString();

                    // Verificar si el producto ya está habilitado
                    if (estadoProducto.Equals("Disponible", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("El producto ya está habilitado.");
                        return; // Salir del método sin hacer nada más
                    }

                    // Crear objeto ProductoBE con el Id_Producto seleccionado
                    ProductoBE producto = new ProductoBE();
                    producto.Id_Producto = idProducto;

                    // Llamar al método de negocio para habilitar el producto
                    bool exito = objProductoBL.HabilitarProducto(producto);

                    if (exito)
                    {
                        MessageBox.Show("Producto habilitado correctamente.");
                        CargarDatos(txtFiltro.Text.Trim()); // Actualizar la grilla después de la operación
                    }
                    else
                    {
                        MessageBox.Show("No se pudo habilitar el producto.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para habilitar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

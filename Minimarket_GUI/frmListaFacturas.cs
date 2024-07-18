using Minimarket_BL;
using ProyVentas_GUI;
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
    public partial class frmListaFacturas : Form
    {
        FacturaBL objFactura = new FacturaBL();
        DataView dtv;
        public frmListaFacturas()
        {
            InitializeComponent();
        }


        private void CargarDatos(string Ruc)
        {
            dtv = new DataView(objFactura.ListarFactura());
            dtv.RowFilter = "Ruc LIKE '%" + Ruc + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
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

        private void btnTraspaso_Click(object sender, EventArgs e)
        {
            // Obtener el código de factura seleccionada en la grilla
            string codigoFacturaSeleccionada = dtgDatos.CurrentRow.Cells["Id_Factura"].Value.ToString();

            // Crear instancia del formulario para mostrar detalles de factura
            frmFacturas detalleFacturaForm = new frmFacturas();

            // Llamar método en frmFacturasDetalle para cargar detalles de la factura
            detalleFacturaForm.CargarDetalleFactura(codigoFacturaSeleccionada);

            // Mostrar el formulario de detalles de factura
            detalleFacturaForm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Minimarket_BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmListaBoletas : Form
    {
        BoletaBL objBoleta = new BoletaBL();
        DataView dtv;

        public frmListaBoletas()
        {
            InitializeComponent();
        }

        private void btnTraspaso_Click(object sender, EventArgs e)
        {
            // Obtener el código de factura seleccionada en la grilla
            string codigoFacturaSeleccionada = dtgDatos.CurrentRow.Cells["Id_Boleta"].Value.ToString();

            // Crear instancia del formulario para mostrar detalles de factura
            frmBoletas detalleFacturaForm = new frmBoletas();

            // Llamar método en frmFacturasDetalle para cargar detalles de la factura+-
            detalleFacturaForm.CargarDetalleBoleta(codigoFacturaSeleccionada);

            // Mostrar el formulario de detalles de factura
            detalleFacturaForm.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos(string DNI)
        {
            dtv = new DataView(objBoleta.ListarBoleta());
            dtv.RowFilter = "Dni_Cliente LIKE '%" + DNI + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void frmListaBoletas_Load(object sender, EventArgs e)
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
    }
}

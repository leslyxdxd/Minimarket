using System;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;
using System.Data;
using ProyVentas_GUI;

namespace Minimarket_GUI
{
    public partial class frmListaProductos : Form
    {
        public DataRowView ProductoSeleccionado { get; private set; }
        StockBL objStock = new StockBL();
        DataView dtv;

        public frmListaProductos()
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



        private void btnGuiasRemision_Click(object sender, EventArgs e)
        {

        }

        private void dtgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                ProductoSeleccionado = (DataRowView)dtgDatos.Rows[e.RowIndex].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
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
            frmTraspaso traspasoProducto = new frmTraspaso();
            traspasoProducto.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            traspasoProducto.ShowDialog();
        }
    }
}

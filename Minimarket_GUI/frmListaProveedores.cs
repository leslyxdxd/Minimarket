// Agregar...
using Minimarket_BL;
using ProyVentas_GUI;
using System.Data; // Para los objetos DataTable, DataRow y DataView


namespace Minimarket_GUI
{
    public partial class frmListaProveedores : Form
    {
        // Instancias
        ProveedorBL objProveedorBL = new ProveedorBL();
        DataView dtv;

        public frmListaProveedores()
        {
            InitializeComponent();
        }
        private void CargarDatos(String RUC)
        {


            dtv = new DataView(objProveedorBL.ListarProveedor());
            dtv.RowFilter = "RUC like '%" + RUC + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

        }

        private void frmListaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos("");

            }
            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex.Message);

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
                MessageBox.Show("Error:" + ex.Message);
            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGuiaRemision actualizarUsuario = new frmGuiaRemision();
            actualizarUsuario.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            actualizarUsuario.ShowDialog();
        }

        private void dtgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                frmActualizarProveedor prov03 = new frmActualizarProveedor();
                //Se toma el valor de la columna cero de la fila seleccionada 
                //en el datagriv
                prov03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                prov03.ShowDialog();
                //Al retornar, resfrescamos la vista y cargamos los datos para ver los cambios 
                //del proveedor actualizado 
                dtv = new DataView(objProveedorBL.ListarProveedor());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }
    }
}

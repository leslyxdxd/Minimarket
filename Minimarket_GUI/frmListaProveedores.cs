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

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Codifique
        //        frmIngresarUsuario insertarUsuario = new frmIngresarUsuario();
        //        insertarUsuario.ShowDialog();


        //        dtv = new DataView(objUsuariosBL.ListarUsuarios());
        //        CargarDatos(txtFiltro.Text.Trim());

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error:" + ex.Message);
        //    }
        //}

        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Codifique
        //        frmActualizarUsuario actualizarUsuario = new frmActualizarUsuario();
        //        actualizarUsuario.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
        //        actualizarUsuario.ShowDialog();


        //        dtv = new DataView(objUsuariosBL.ListarUsuarios());
        //        CargarDatos(txtFiltro.Text.Trim());

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error:" + ex.Message);
        //    }

        //}

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    DialogResult vrpta;

        //    vrpta = MessageBox.Show("¿Seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo);

        //    if (vrpta == DialogResult.Yes)
        //    {
        //        //Obtenemos el codigo que se va a eliminar
        //        String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
        //        if (objUsuariosBL.EliminarUsuario(strCodigo) == true)
        //        {

        //            CargarDatos(txtFiltro.Text.Trim());
        //        }
        //        else
        //        {
        //            throw new Exception("Registro no se puede elimnar por estar referenciado a otra tabla");
        //        }

        //    }

        //}

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {

            frmGuiaRemision objActualizarEstudiante = new frmGuiaRemision();

        }
    }
}

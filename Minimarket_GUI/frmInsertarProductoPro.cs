using Minimarket_BE;
using Minimarket_BL;
using ProyVentas_BL;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmInsertarProductoPro : Form
    {
        private ProveedorBL objProveedorBL = new ProveedorBL();
        private ProveedorBE objProveedorBE = new ProveedorBE();
        private CategoriaBL objCategoriaBL = new CategoriaBL();
        private ProductoBL objProductoBL = new ProductoBL();
        private ProductoBE objProductoBE = new ProductoBE();
        private UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();

        public frmInsertarProductoPro()
        {
            InitializeComponent();
        }

        public string Codigo { get; set; }

        private void frmInsertarProductoPro_Load(object sender, EventArgs e)
        {
            // Cargamos los combos y consultamos el proveedor
            objProveedorBE = objProveedorBL.ConsultarProveedor(this.Codigo);

            lblCodigo.Text = objProveedorBE.Id_Proveedor;
            lblNombre.Text = objProveedorBE.Nom_Proveedor;
            lblRuc.Text = objProveedorBE.RUC;

            CargarCombos();
        }

        private void CargarCombos()
        {
            // Categoria
            DataTable dtCategoria = objCategoriaBL.ListarCat();
            DataRow drCategoria = dtCategoria.NewRow();
            drCategoria["Id_Cat"] = 0;
            drCategoria["Des_Cat"] = "--Seleccione--";
            dtCategoria.Rows.InsertAt(drCategoria, 0);

            cboCategoria.DataSource = dtCategoria;
            cboCategoria.ValueMember = "Id_Cat";
            cboCategoria.DisplayMember = "Des_Cat";

            // Unidad de Medida
            DataTable dtUnidadMedida = objUnidadMedidaBL.ListarUM_Pro();
            DataRow drUnidadMedida = dtUnidadMedida.NewRow();
            drUnidadMedida["Id_UM"] = 0;
            drUnidadMedida["Des_UM"] = "--Seleccione--";
            dtUnidadMedida.Rows.InsertAt(drUnidadMedida, 0);

            cboUnidad.DataSource = dtUnidadMedida;
            cboUnidad.ValueMember = "Id_UM";
            cboUnidad.DisplayMember = "Des_UM";
        }
        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            objProductoBE.Nom_Producto = txtProducto.Text.Trim();
            objProductoBE.Marca = txtMarca.Text.Trim();
            objProductoBE.Id_Proveedor = Codigo; // Asignar directamente la cadena
            objProductoBE.Id_Cat = Convert.ToInt32(cboCategoria.SelectedValue);
            objProductoBE.Id_UM = Convert.ToInt32(cboUnidad.SelectedValue);
            objProductoBE.Precio_Unitario = Convert.ToDecimal(txtPrecio.Text);
            objProductoBE.Usu_Registro = clsCredenciales.Login_Usuario;

            try
            {
                objProductoBL.InsertarProducto(objProductoBE);
                MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario actual
                this.Close();

                // Abrir el formulario frmListaProductosTras
                CloseAllChildForms();
                frmListaProductosTras listaProductos = new frmListaProductosTras();
                listaProductos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarCampos()
        {
            // Validar que los campos de nombre no contengan números
            if (Regex.IsMatch(txtProducto.Text, @"\d") || Regex.IsMatch(txtMarca.Text, @"\d"))
            {
                MessageBox.Show("Los campos de nombre no pueden contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que los campos numéricos no contengan letras
            if (!Regex.IsMatch(txtPrecio.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("El campo de precio debe ser numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado una categoría y una unidad de medida
            if (Convert.ToInt32(cboCategoria.SelectedValue) == 0 || Convert.ToInt32(cboUnidad.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría y una unidad de medida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

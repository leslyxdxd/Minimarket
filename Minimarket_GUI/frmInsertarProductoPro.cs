using Minimarket_BE;
using Minimarket_BL;
using ProyVentas_BL;
using System;
using System.Data;
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            objProductoBE.Nom_Producto = txtProducto.Text.Trim();
            objProductoBE.Marca = txtMarca.Text.Trim();
            objProductoBE.Marca = txtMarca.Text.Trim();
        

        }
    }
}

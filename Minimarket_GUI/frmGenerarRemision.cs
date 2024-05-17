using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minimarket_BE;
using Minimarket_BL;
using Minimarket_GUI;

using System;
using System.Data;
using System.Windows.Forms;
namespace Minimarket_GUI
{
    public partial class frmGenerarRemision : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();

        public frmGenerarRemision()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void cboProveeedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboProveeedor.SelectedValue != null)
                {
                    // Obtener el ID del proveedor seleccionado
                    string selectedProviderId = cboProveeedor.SelectedValue.ToString(); // Asegúrate de que el tipo de datos coincida con el ID del proveedor en tu origen de datos

                    // Obtener los datos del proveedor
                    objProveedorBE = objProveedorBL.ConsultarProveedor(selectedProviderId);

                    // Llenar los labels con los datos del proveedor
                    lblDireccion.Text = objProveedorBE.Direc_Proveedor;
                    lblRuc.Text = objProveedorBE.RUC;
                    lblCorreo.Text = objProveedorBE.Correo;
                    lblTel.Text = objProveedorBE.Telefono;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGenerarRemision_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de productos por proveedor
                DataTable da = objProductoBL.ListarProductoxProveedor();

                // Crear una nueva fila y agregarla al DataTable de productos
                DataRow dc = da.NewRow();
                dc["Id_Producto"] = 0;
                dc["Nom_Producto"] = "--Seleccione---";
                da.Rows.InsertAt(dc, 0);

                // Asignar el DataTable al ComboBox de productos
                cboProducto.DataSource = da;
                cboProducto.ValueMember = "Id_Producto";
                cboProducto.DisplayMember = "Nom_Producto";
                cboProducto.DropDownStyle = ComboBoxStyle.DropDownList; // Establecer el estilo DropDownList

                // Obtener la lista de proveedores
                DataTable dt = objProveedorBL.ListarProveedor();

                // Crear una nueva fila y agregarla al DataTable de proveedores
                DataRow dr = dt.NewRow();
                dr["Id_Proveedor"] = 0;
                dr["Nom_Proveedor"] = "--Seleccione---";
                dt.Rows.InsertAt(dr, 0);

                // Asignar el DataTable al ComboBox de proveedores
                cboProveeedor.DataSource = dt;
                cboProveeedor.ValueMember = "Id_Proveedor";
                cboProveeedor.DisplayMember = "Nom_Proveedor";
                cboProveeedor.DropDownStyle = ComboBoxStyle.DropDownList; // Establecer el estilo DropDownList

                // Asociar el evento SelectedIndexChanged al método de manejo del evento
                cboProveeedor.SelectedIndexChanged += cboProveeedor_SelectedIndexChanged;

                // Establecer el valor seleccionado del ComboBox de productos, verificando si Id_Producto no es nulo
                if (objProductoBE != null && objProductoBE.Id_Producto != null)
                {
                    cboProducto.SelectedValue = objProductoBE.Id_Producto;
                }
                else
                {
                    // Opcional: seleccionar un valor predeterminado o mostrar un mensaje
                    cboProducto.SelectedIndex = 0; // Esto seleccionará el primer elemento (el que tiene el texto "--Seleccione---")
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}

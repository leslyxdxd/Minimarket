using System;
using System.Data;
using System.Windows.Forms;
using Minimarket_BE;
using Minimarket_BL;
using ProyVentas_BL;

namespace Minimarket_GUI
{
    public partial class frmGenerarRemision : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
        RemisionBL objRemisionBL = new RemisionBL();
        RemisionBE objRemisionBE = new RemisionBE();
        TransportistaBL objTransportistaBL = new TransportistaBL();
        TransportistaBE objTransportistaBE = new TransportistaBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        UnidadMedidaBE objUnidadMedidaBE = new UnidadMedidaBE();

        public frmGenerarRemision()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void CargarCombos(string strIdCodigo)
        {


            //Categoria
            DataTable dt = new DataTable();

            //Crear una nueva fila 
            DataRow dr;


            //De unidad de medida
            dt = objUnidadMedidaBL.ListarUM();
            dr = dt.NewRow();//Nueva fila
            dr["Id_UM"] = 0;
            dr["Des_UM"] = "--Seleccione--";
            dt.Rows.InsertAt(dr, 0);//La fila se inserta en la posicion 0 de la tabla

            //Llenamos el combo 
            cboUm.DataSource = dt;
            cboUm.ValueMember = "Id_UM";
            cboUm.DisplayMember = "Des_UM";

            cboProveeedor.DataSource = objProveedorBL.ListarProveedor();
            cboProveeedor.ValueMember = "Id_Proveedor";
            cboProveeedor.DisplayMember = "Nom_Proveedor";
            cboProveeedor.SelectedValue = strIdCodigo;

            // Para cboProducto
            DataTable productoData = objProveedorBL.ConsultarProductoxProveedor(strIdCodigo);
            DataRow productoRow = productoData.NewRow();
            productoRow["Id_Producto"] = DBNull.Value;  // O un valor especial que indiques como 'Seleccione'
            productoRow["Nom_Producto"] = "--Seleccione--";
            productoData.Rows.InsertAt(productoRow, 0);

            cboProducto.DataSource = productoData;
            cboProducto.ValueMember = "Id_Producto";
            cboProducto.DisplayMember = "Nom_Producto";
            cboProducto.SelectedIndex = 0; // Seleccionar el primer ítem (Seleccione)

            // Para cboTransportista
            DataTable transportistaData = objProveedorBL.ConsultarTransportistaxProveedor(strIdCodigo);
            DataRow transportistaRow = transportistaData.NewRow();
            transportistaRow["Id_Transporte"] = DBNull.Value;  // O un valor especial que indiques como 'Seleccione'
            transportistaRow["Empresa_Transporte"] = "--Seleccione--";
            transportistaData.Rows.InsertAt(transportistaRow, 0);

            cboTransportista.DataSource = transportistaData;
            cboTransportista.ValueMember = "Id_Transporte";
            cboTransportista.DisplayMember = "Empresa_Transporte";
            cboTransportista.SelectedIndex = 0; // Seleccionar el primer ítem (Seleccione)

        }
            
            private void frmGenerarRemision_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos("02");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                objProveedorBE.Id_Proveedor = Convert.ToString(cboProveeedor.SelectedValue);
                objProductoBE.Id_Producto = Convert.ToString(cboProducto.SelectedValue);
                objTransportistaBE.Id_Transporte = Convert.ToString(cboTransportista.SelectedValue);
                objUnidadMedidaBE.Id_UM = Convert.ToInt16(cboUm.SelectedValue);

                objRemisionBE.Cantidad = Convert.ToInt16(UpdownCantidad.Text.Trim());
                objRemisionBE.Peso_Carga = Convert.ToDecimal(txtPeso.Text.Trim());
                objRemisionBE.FechaIni = Convert.ToDateTime(dtpFecIni.Text.Trim());
                objRemisionBE.FechaFin = Convert.ToDateTime(dtpFecFin.Text.Trim());
                objRemisionBE.Punto_Partida = txtPartida.Text.Trim();
                objRemisionBE.Punto_Llegada = txtLlegada.Text.Trim();

                objRemisionBE.Observaciones = txtObservacion.Text.Trim();
                objRemisionBE.Usu_Registro = clsCredenciales.Login_Usuario;

                if (objRemisionBL.InsertarRemision(objRemisionBE))
                {
                    // Si se insertó correctamente
                    this.Close();
                }
                else
                {
                    throw new Exception("Error en el proceso, contacte con TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboProveeedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCombos(cboProveeedor.SelectedValue.ToString());
        }

        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboTransportista_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
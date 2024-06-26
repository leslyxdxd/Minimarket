using Minimarket_BE;
using Minimarket_BL;
using ProyVentas_BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmActualizarRemision : Form
    {
        RemisionBL objRemisionBL = new RemisionBL();
        RemisionBE objRemisionBE = new RemisionBE();
        ProductoBL objProductoBL = new ProductoBL();
        ProveedorBL objProveedorBL = new ProveedorBL();
        TransportistaBL objTransportistaBL = new TransportistaBL();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        UnidadMedidaBE objUnidadMedidaBE = new UnidadMedidaBE();

        public frmActualizarRemision()
        {
            InitializeComponent();
        }

        public string Id_Remision { get; set; }

        private void CargarCombos()
        {
            try
            {
                // Cargar datos en los ComboBox de Unidad de Medida
                DataTable dtUM = objUnidadMedidaBL.ListarUM();
                DataRow drUM = dtUM.NewRow();
                drUM["Id_UM"] = DBNull.Value;
                drUM["Des_UM"] = "--Seleccione--";
                dtUM.Rows.InsertAt(drUM, 0);
                cboUm.DataSource = dtUM;
                cboUm.ValueMember = "Id_UM";
                cboUm.DisplayMember = "Des_UM";

                // Cargar datos en los ComboBox de Proveedores
                DataTable dtProveedor = objProveedorBL.ListarProveedorActivos();
                DataRow drProveedor = dtProveedor.NewRow();
                drProveedor["Id_Proveedor"] = DBNull.Value;
                drProveedor["Nom_Proveedor"] = "--Seleccione--";
                dtProveedor.Rows.InsertAt(drProveedor, 0);
                cboProveeedor.DataSource = dtProveedor;
                cboProveeedor.ValueMember = "Id_Proveedor";
                cboProveeedor.DisplayMember = "Nom_Proveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void CargarProductos(string idProveedor)
        {
            try
            {
                // Cargar datos en los ComboBox de Productos en función del proveedor seleccionado
                DataTable dtProducto = objProveedorBL.ConsultarProductoxProveedor(idProveedor);
                DataRow drProducto = dtProducto.NewRow();
                drProducto["Id_Producto"] = DBNull.Value;
                drProducto["Nom_Producto"] = "--Seleccione--";
                dtProducto.Rows.InsertAt(drProducto, 0);
                cboProducto.DataSource = dtProducto;
                cboProducto.ValueMember = "Id_Producto";
                cboProducto.DisplayMember = "Nom_Producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarTransportistas(string idProveedor)
        {
            try
            {
                // Cargar datos en los ComboBox de Transportistas en función del proveedor seleccionado
                DataTable dtTransportista = objProveedorBL.ConsultarTransportistaxProveedor(idProveedor);
                DataRow drTransportista = dtTransportista.NewRow();
                drTransportista["Id_Transporte"] = DBNull.Value;
                drTransportista["Empresa_Transporte"] = "--Seleccione--";
                dtTransportista.Rows.InsertAt(drTransportista, 0);
                cboTransportista.DataSource = dtTransportista;
                cboTransportista.ValueMember = "Id_Transporte";
                cboTransportista.DisplayMember = "Empresa_Transporte";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar transportistas: " + ex.Message);
            }
        }

        private void CargarUM(string Id_Remision)
        {
            try
            {
                // Cargar datos en el ComboBox de Unidad de Medida en función de la remisión seleccionada
                DataTable dtUM = objUnidadMedidaBL.ConsultarUMXRemision(Id_Remision);
                if (dtUM == null || dtUM.Rows.Count == 0)
                {
                    throw new Exception("No se encontraron datos de unidad de medida para la remisión.");
                }

                cboUm.DataSource = dtUM;
                cboUm.ValueMember = "Id_UM_Remision";
                cboUm.DisplayMember = "Des_UM_Remision";

                // Establecer el texto del ComboBox para mostrar la unidad de medida seleccionada
                DataRowView selectedItem = (DataRowView)cboUm.SelectedItem;
                if (selectedItem != null)
                {
                    cboUm.Text = selectedItem["Des_UM_Remision"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Unidades de Medida: " + ex.Message);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar los datos de la remisión
                objRemisionBE.Id_Remision = this.Id_Remision; // Asumiendo que Id_Remision es una propiedad válida en RemisionBE
                objRemisionBE.Id_Proveedor = Convert.ToString(cboProveeedor.SelectedValue);
                objRemisionBE.Id_Producto = Convert.ToString(cboProducto.SelectedValue);
                objRemisionBE.Id_Transporte = Convert.ToString(cboTransportista.SelectedValue);
                objRemisionBE.Id_UM = Convert.ToInt16(cboUm.SelectedValue);
                objRemisionBE.Num_Guia = lblNumeroGuia.Text.Trim(); // Asegúrate de que lblNumeroGuia esté correctamente vinculado en el formulario

                objRemisionBE.Cantidad = Convert.ToInt16(UpdownCantidad.Value);
                objRemisionBE.Peso_Carga = Convert.ToDecimal(txtPeso.Text.Trim());
                objRemisionBE.FechaIni = dtpFecIni.Value;
                objRemisionBE.FechaFin = dtpFecFin.Value;
                objRemisionBE.Punto_Partida = txtPartida.Text.Trim();
                objRemisionBE.Punto_Llegada = txtLlegada.Text.Trim();
                objRemisionBE.Observaciones = txtObservacion.Text.Trim();

                if (objRemisionBL.ActualizarRemision(objRemisionBE))
                {
                    MessageBox.Show("Remisión actualizada correctamente.");
                    this.Close(); // Cierra el formulario después de la actualización exitosa
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
            try
            {
                string idProveedorSeleccionado = cboProveeedor.SelectedValue.ToString();
                CargarProductos(idProveedorSeleccionado);
                CargarTransportistas(idProveedorSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos y transportistas: " + ex.Message);
            }
        }

        private void frmActualizarRemision_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Cargar datos en los ComboBox
                CargarCombos();

                // Obtener los datos de la remisión a actualizar
                objRemisionBE = objRemisionBL.ConsultarGuiaRemision(Id_Remision);

                // Cargar y seleccionar la Unidad de Medida
                CargarUM(Id_Remision);

                // Seleccionar los datos en los ComboBox y otros controles
                cboProveeedor.SelectedValue = objRemisionBE.Id_Proveedor;
                CargarProductos(objRemisionBE.Id_Proveedor);
                cboProducto.SelectedValue = objRemisionBE.Id_Producto;
                CargarTransportistas(objRemisionBE.Id_Proveedor);
                cboTransportista.SelectedValue = objRemisionBE.Id_Transporte;

                // Otros datos de la remisión
                lblNumeroGuia.Text = objRemisionBE.Num_Guia;
                lblDireccion.Text = objRemisionBE.Direc_Proveedor;
                lblRuc.Text = objRemisionBE.RUC;
                lblUnidad.Text = objRemisionBE.Des_UM_Producto;
                lblMarcas.Text = objRemisionBE.Marca;
                lblCorreo.Text = objRemisionBE.Correo;
                lblTel.Text = objRemisionBE.Telefono;
                lblRucTra.Text = objRemisionBE.Ruc_Transporte;
                lblDirecTrans.Text = objRemisionBE.Direccion_Empresa;
                lblMarca.Text = objRemisionBE.Marca_Trasporte;
                lblPlaca.Text = objRemisionBE.Placa_Trasporte;
                lblLicencia.Text = objRemisionBE.Licencia_Transporte;
                UpdownCantidad.Value = objRemisionBE.Cantidad;
                txtPeso.Text = objRemisionBE.Peso_Carga.ToString("N2");
                dtpFecIni.Value = objRemisionBE.FechaIni;
                dtpFecFin.Value = objRemisionBE.FechaFin;
                txtPartida.Text = objRemisionBE.Punto_Partida;
                txtLlegada.Text = objRemisionBE.Punto_Llegada;
                txtObservacion.Text = objRemisionBE.Observaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cboUm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Lógica para manejar cambios en la selección del ComboBox de Unidad de Medida si es necesario
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

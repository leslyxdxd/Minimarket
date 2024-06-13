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
            // Establecer DropDownStyle para que los ComboBox sean solo de lectura
            cboUm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProveeedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransportista.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establecer el valor predeterminado y agregar el controlador de eventos KeyPress y TextChanged
            txtNumeroGuia.Text = "001-";
            txtNumeroGuia.KeyPress += new KeyPressEventHandler(txtNumeroGuia_KeyPress);
            txtNumeroGuia.TextChanged += new EventHandler(txtNumeroGuia_TextChanged);
        }

        private void txtNumeroGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevenir la eliminación del prefijo "001-"
            if (txtNumeroGuia.SelectionStart < 4 && (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroGuia_TextChanged(object sender, EventArgs e)
        {
            // Asegurarse de que el prefijo "001-" esté siempre presente
            if (!txtNumeroGuia.Text.StartsWith("001-"))
            {
                txtNumeroGuia.Text = "001-";
                txtNumeroGuia.SelectionStart = txtNumeroGuia.Text.Length; // Mover el cursor al final
            }
        }

        private void CargarCombos(string strIdCodigo)
        {
            //Categoria
            DataTable dt = new DataTable();
            DataRow dr;

            //De unidad de medida
            dt = objUnidadMedidaBL.ListarUM();
            dr = dt.NewRow();
            dr["Id_UM"] = 0;
            dr["Des_UM"] = "--Seleccione--";
            dt.Rows.InsertAt(dr, 0);

            //Llenamos el combo 
            cboUm.DataSource = dt;
            cboUm.ValueMember = "Id_UM";
            cboUm.DisplayMember = "Des_UM";



            cboProveeedor.DataSource = objProveedorBL.ListarProveedorActivos();
            cboProveeedor.ValueMember = "Id_Proveedor";
            cboProveeedor.DisplayMember = "Nom_Proveedor";
            cboProveeedor.SelectedValue = strIdCodigo;



            // Para cboProducto
            DataTable productoData = objProveedorBL.ConsultarProductoxProveedor(strIdCodigo);
            DataRow productoRow = productoData.NewRow();
            productoRow["Id_Producto"] = DBNull.Value;
            productoRow["Nom_Producto"] = "--Seleccione--";
            productoData.Rows.InsertAt(productoRow, 0);

            cboProducto.DataSource = productoData;
            cboProducto.ValueMember = "Id_Producto";
            cboProducto.DisplayMember = "Nom_Producto";
            cboProducto.SelectedIndex = 0;

            // Para cboTransportista
            DataTable transportistaData = objProveedorBL.ConsultarTransportistaxProveedor(strIdCodigo);
            DataRow transportistaRow = transportistaData.NewRow();
            transportistaRow["Id_Transporte"] = DBNull.Value;
            transportistaRow["Empresa_Transporte"] = "--Seleccione--";
            transportistaData.Rows.InsertAt(transportistaRow, 0);

            cboTransportista.DataSource = transportistaData;
            cboTransportista.ValueMember = "Id_Transporte";
            cboTransportista.DisplayMember = "Empresa_Transporte";
            cboTransportista.SelectedIndex = 0;
        }

        private void LimpiarLabels()
        {
            lblDireccion.Text = string.Empty;
            lblRuc.Text = string.Empty;
            lblCorreo.Text = string.Empty;
            lblTel.Text = string.Empty;

            lblUnidad.Text = string.Empty;
            lblMarcas.Text = string.Empty;

            lblDirecTrans.Text = string.Empty;
            lblRucTra.Text = string.Empty;
            lblMarca.Text = string.Empty;
            lblPlaca.Text = string.Empty;
            lblLicencia.Text = string.Empty;
        }

        private void frmGenerarRemision_Load(object sender, EventArgs e)
        {
            try
            {
                string codigoInicial = "02";
                CargarCombos(codigoInicial);
                CargarProveedor(codigoInicial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarProveedor(string codigoProveedor)
        {
            try
            {
                objProveedorBE = objProveedorBL.ConsultarProveedor(codigoProveedor);

                lblDireccion.Text = objProveedorBE.Direc_Proveedor;
                lblRuc.Text = objProveedorBE.RUC;
                lblCorreo.Text = objProveedorBE.Correo;
                lblTel.Text = objProveedorBE.Telefono;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarProducto(string codigoProducto)
        {
            try
            {
                objProductoBE = objProductoBL.ConsultarProducto(codigoProducto);

                lblUnidad.Text = objProductoBE.Des_UM;
                lblMarcas.Text = objProductoBE.Marca;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarTransportista(string codigoTransportista)
        {
            try
            {
                objTransportistaBE = objTransportistaBL.ConsultarTransportista(codigoTransportista);

                lblDirecTrans.Text = objTransportistaBE.Direccion_Empresa;
                lblRucTra.Text = objTransportistaBE.Ruc_Transporte;
                lblMarca.Text = objTransportistaBE.Marca_Transporte;
                lblPlaca.Text = objTransportistaBE.Marca_Transporte;
                lblLicencia.Text = objTransportistaBE.Licencia_Transporte;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                objRemisionBE.Id_Proveedor = Convert.ToString(cboProveeedor.SelectedValue);
                objRemisionBE.Id_Producto = Convert.ToString(cboProducto.SelectedValue);
                objRemisionBE.Id_Transporte = Convert.ToString(cboTransportista.SelectedValue);
                objRemisionBE.Id_UM = Convert.ToInt16(cboUm.SelectedValue);
                objRemisionBE.Num_Guia = txtNumeroGuia.Text.Trim();

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
                    MessageBox.Show("Remisión generada correctamente.");
                    this.Close(); // Cierra el formulario después de la inserción exitosa
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
            string codigoProveedorSeleccionado = cboProveeedor.SelectedValue.ToString();
            LimpiarLabels(); // Llamar al método para limpiar los labels
            CargarCombos(codigoProveedorSeleccionado);
            CargarProveedor(codigoProveedorSeleccionado);
        }

        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codigoProductoSeleccionado = cboProducto.SelectedValue.ToString();
            CargarProducto(codigoProductoSeleccionado);
        }

        private void cboTransportista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codigoTransportistaSeleccionado = cboTransportista.SelectedValue.ToString();
            CargarTransportista(codigoTransportistaSeleccionado);
        }

    
    }
}

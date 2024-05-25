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

        private void cboProveeedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmGenerarRemision_Load(object sender, EventArgs e)
        {
            try
            {

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


                if (objRemisionBL.InsertarRemision(objRemisionBE) == true)
                {
                    // si se inserto correctamente
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

    
    }
}

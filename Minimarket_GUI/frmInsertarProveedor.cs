using Minimarket_BE;
using Minimarket_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmInsertarProveedor : Form
    {
        ProveedorBE objProveedorBE = new ProveedorBE();
        ProveedorBL objProveedorBL = new ProveedorBL();
        TransportistaBE objTransporteBE = new TransportistaBE();
        TransportistaBL objTransporteBL = new TransportistaBL();


        public frmInsertarProveedor()
        {
            InitializeComponent();
        }

        private void frmInsertarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validaciones para el Proveedor
                if (txtProveedor.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del proveedor no puede estar vacío.");
                }

                if (txtCorreo.Text.Trim() == String.Empty || !IsValidEmail(txtCorreo.Text.Trim()))
                {
                    throw new Exception("El correo del proveedor no es válido.");
                }

                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección del proveedor no puede estar vacía.");
                }

                if (txtProRUC.Text.Trim() == String.Empty || txtProRUC.Text.Length != 11 || !long.TryParse(txtProRUC.Text.Trim(), out _))
                {
                    throw new Exception("El RUC del proveedor no es válido. Debe tener 11 dígitos numéricos.");
                }

                if (txtTelefono.Text.Trim() == String.Empty || txtTelefono.Text.Length > 15)
                {
                    throw new Exception("El teléfono del proveedor no es válido.");
                }

                // Asignación de datos del Proveedor
                objProveedorBE.Nom_Proveedor = txtProveedor.Text.Trim();
                objProveedorBE.Correo = txtCorreo.Text.Trim();
                objProveedorBE.Direc_Proveedor = txtDireccion.Text.Trim();
                objProveedorBE.RUC = txtProRUC.Text.Trim();
                objProveedorBE.Telefono = txtTelefono.Text.Trim();
                objProveedorBE.Usu_Registro = clsCredenciales.Login_Usuario;

                // Validaciones para el Transporte
                if (txtTransporte.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre de la empresa de transporte no puede estar vacío.");
                }

                if (txtTranDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección de la empresa de transporte no puede estar vacía.");
                }

                if (txtPlaca.Text.Trim() == String.Empty || txtPlaca.Text.Length != 6)
                {
                    throw new Exception("La placa del transporte no es válida. Debe tener 6 caracteres.");
                }

                if (txtTransRUC.Text.Trim() == String.Empty || txtTransRUC.Text.Length != 11 || !long.TryParse(txtTransRUC.Text.Trim(), out _))
                {
                    throw new Exception("El RUC del transporte no es válido. Debe tener 11 dígitos numéricos.");
                }

                if (txtTraMarca.Text.Trim() == String.Empty)
                {
                    throw new Exception("La marca del transporte no puede estar vacía.");
                }

                if (txtLicencia.Text.Trim() == String.Empty || txtLicencia.Text.Length > 7)
                {
                    throw new Exception("La licencia del transporte no es válida. Debe tener hasta 7 caracteres.");
                }

                // Asignación de datos del Transporte
                objTransporteBE.Empresa_Transporte = txtTransporte.Text.Trim();
                objTransporteBE.Direccion_Empresa = txtTranDireccion.Text.Trim();
                objTransporteBE.Placa_Transporte = txtPlaca.Text.Trim();
                objTransporteBE.Ruc_Transporte = txtTransRUC.Text.Trim();
                objTransporteBE.Marca_Transporte = txtTraMarca.Text.Trim();
                objTransporteBE.Licencia_Transporte = txtLicencia.Text.Trim();

                // Intentar insertar los datos
                if (objProveedorBL.InsertarProveedorTransporte(objProveedorBE, objTransporteBE))
                {
                    MessageBox.Show("El registro se insertó correctamente.");
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no insertado, contacte con TI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método auxiliar para validar correos electrónicos
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

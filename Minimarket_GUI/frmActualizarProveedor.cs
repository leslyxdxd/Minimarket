using Minimarket_BE;
using Minimarket_BL;
using Minimarket_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Agregar...

namespace ProyVentas_GUI
{
    public partial class frmActualizarProveedor : Form
    {

        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();


        public frmActualizarProveedor()
        {
            InitializeComponent();
        }

        // IMPORTANTE: Creamos la propiedad Codigo ,que recepcionara el valor del codigo del proveedor
        // a actualizar enviado desde el formulario ProveedorMan01


        public String Codigo { get; set; }

        private void ProveedorMan03_Load(object sender, EventArgs e)
        {
            try
            {  //Mostramos los datos del proveedor a actualizar 
                objProveedorBE = objProveedorBL.ConsultarProveedor(this.Codigo);

                lblCod.Text = objProveedorBE.Id_Proveedor;
                lblProveedor.Text = objProveedorBE.Nom_Proveedor;
                lblRuc.Text = objProveedorBE.RUC;
                txtCorreo.Text = objProveedorBE.Correo;
                txtDir.Text = objProveedorBE.Direc_Proveedor;
                txtTelefono.Text = objProveedorBE.Telefono;
                chkEstado.Checked = Convert.ToBoolean(objProveedorBE.Estado);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
           {
            //    Validar que este con valor la razon social
                if (txtDir.Text.Trim() == String.Empty)
              {
               throw new Exception("Ladireccion es obligatoria");
               }
            // Validamos que el ruc este lleno
             if (txtCorreo.Text.Trim() == String.Empty)
                {
                    throw new Exception("El correo no debe estar vacio");
                }

            //    Pasamos los valores a las propiedades de la instancia
            
                objProveedorBE.Direc_Proveedor = txtDir.Text.Trim();
                objProveedorBE.Telefono = txtTelefono.Text.Trim();
                objProveedorBE.Correo = txtCorreo.Text.Trim();
               

            //    Recuerde que el IdUbigeo es la concatenacion de los valores del IdDepartamento,
            //    Id Provincia y Id Distrito seleccionados de los respectivos combos
            //    objProveedorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
            //    cboProvincia.SelectedValue.ToString();

                  objProveedorBE.Usu_Ult_Mod = clsCredenciales.Login_Usuario;

                //Checked
               objProveedorBE.Estado = Convert.ToInt16(chkEstado.Checked);

                if (objProveedorBL.ActualizarProveedor(objProveedorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
